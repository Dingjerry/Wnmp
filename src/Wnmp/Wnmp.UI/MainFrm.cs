﻿/*
 * Copyright (c) 2012 - 2021, Kurt Cancemi (kurt@x64architecture.com)
 *
 * This file is part of Wnmp.
 *
 *  Wnmp is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  Wnmp is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with Wnmp.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Wnmp.Programs;
using Wnmp.Updater;
using Wnmp.Wnmp.UI;

namespace Wnmp.UI
{
    public partial class MainFrm : Form
    {
        private void SetLanguage()
        {
            Text = Language.Resource.WNMP_CONTROL_PANEL;
            fileToolStripMenuItem.Text = Language.Resource.FILE_MENU;
            toolsToolStripMenuItem.Text = Language.Resource.TOOLS_MENU;
            helpToolStripMenuItem.Text = Language.Resource.HELP_MENU;
            setupMariaDBToolStripMenuItem.Text = Language.Resource.SETUP_MARIADB;
            applicationsGroupBox.Text = Language.Resource.APPLICATIONS;
            runningLabel.Text = Language.Resource.RUNNING;
            applicationLabel.Text = Language.Resource.APPLICATION;
            optionsLabel.Text = Language.Resource.OPTIONS;
            startAllButton.Text = Language.Resource.START_ALL;
            stopAllButton.Text = Language.Resource.STOP_ALL;
            openMariaDBShellButton.Text = Language.Resource.OPEN_MARIADB_SHELL;
            wnmpDirButton.Text = Language.Resource.WNMP_DIRECTORY;
            nginxStartButton.Text = Language.Resource.START;
            mariadbStartButton.Text = Language.Resource.START;
            phpStartButton.Text = Language.Resource.START;
            nginxStopButton.Text = Language.Resource.STOP;
            mariadbStopButton.Text = Language.Resource.STOP;
            phpStopButton.Text = Language.Resource.STOP;
            nginxRestartButton.Text = Language.Resource.RESTART;
            mariadbRestartButton.Text = Language.Resource.RESTART;
            phpRestartButton.Text = Language.Resource.RESTART;
            nginxConfigButton.Text = Language.Resource.CONFIGURATION;
            mariadbConfigButton.Text = Language.Resource.CONFIGURATION;
            phpConfigButton.Text = Language.Resource.CONFIGURATION;
            nginxLogButton.Text = Language.Resource.LOGS;
            mariadbLogButton.Text = Language.Resource.LOGS;
            phpLogButton.Text = Language.Resource.LOGS;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~0x00040000; // Remove WS_THICKFRAME (Disables resizing)
                return cp;
            }
        }

        public NginxProgram Nginx;
        public MariaDBProgram MariaDB;
        public PHPProgram PHP;

        ContextMenuStrip NginxConfigContextMenuStrip, NginxLogContextMenuStrip;
        ContextMenuStrip MariaDBConfigContextMenuStrip, MariaDBLogContextMenuStrip;
        ContextMenuStrip PHPConfigContextMenuStrip, PHPLogContextMenuStrip;
        private readonly WnmpUpdater updater;
        private readonly NotifyIcon ni = new();
        private bool visiblecore = true;

        public void SetupNginx(bool deleteOldLink = false)
        {
            Misc.CreateRelativeLink($"{Program.StartupPath}\\nginx",
                $"{Program.StartupPath}\\nginx-bins\\{Properties.Settings.Default.NginxVersion}",
                Misc.SYMBOLIC_LINK_FLAG.Directory, deleteOldLink);

            Nginx = new NginxProgram($"{Program.StartupPath}\\nginx\\nginx.exe")
            {
                ProgLogSection = Log.LogSection.Nginx,
                StartArgs = "",
                StopArgs = "-s stop",
                ConfDir = $"{Program.StartupPath}\\nginx\\conf\\",
                LogDir = $"{Program.StartupPath}\\nginx\\logs\\",
                WorkingDir = $"{Program.StartupPath}\\nginx"
            };
        }

        public void SetupMariaDB(bool deleteOldLink = false)
        {
            Misc.CreateRelativeLink($"{Program.StartupPath}\\mariadb",
                $"{Program.StartupPath}\\mariadb-bins\\{Properties.Settings.Default.MariaDBVersion}",
                Misc.SYMBOLIC_LINK_FLAG.Directory, deleteOldLink);

            MariaDB = new MariaDBProgram($"{Program.StartupPath}\\mariadb\\bin\\mysqld.exe")
            {
                ProgLogSection = Log.LogSection.MariaDB,
                StartArgs = "--install-manual Wnmp-MariaDB",
                StopArgs = "/c sc delete Wnmp-MariaDB",
                ConfDir = $"{Program.StartupPath}\\mariadb\\data\\",
                LogDir = $"{Program.StartupPath}\\mariadb\\data\\",
                WorkingDir = $"{Program.StartupPath}\\mariadb"
            };
        }

        public void SetupPHP(bool deleteOldLink = false)
        {
            Misc.CreateRelativeLink($"{Program.StartupPath}\\php",
                $"{Program.StartupPath}\\php-bins\\{Properties.Settings.Default.PHPVersion}",
                Misc.SYMBOLIC_LINK_FLAG.Directory, deleteOldLink);

            PHP = new PHPProgram($"{Program.StartupPath}\\php\\php-cgi.exe")
            {
                ProgLogSection = Log.LogSection.PHP,
                ConfDir = $"{Program.StartupPath}\\php\\",
                LogDir = $"{Program.StartupPath}\\php\\logs\\",
                WorkingDir = $"{Program.StartupPath}\\php"
            };
            SetCurlCAPath();
        }

        private static void SetCurlCAPath()
        {
            string phpini = $"{Program.StartupPath}\\php\\php.ini";
            if (!File.Exists(phpini))
                return;

            string[] file = File.ReadAllLines(phpini);
            for (int i = 0; i < file.Length; i++)
            {
                if (file[i].Contains("curl.cainfo") == false)
                    continue;

                Regex reg = new("(curl\\.cainfo).*?(=)");
                string orginal = reg.Match(file[i]).ToString();
                if (orginal == String.Empty)
                    continue;
                string replace = $"curl.cainfo = \"{Program.StartupPath}\\contrib\\cacert.pem\"";
                file[i] = replace;
            }
            using var sw = new StreamWriter(phpini);
            foreach (var line in file)
                sw.WriteLine(line);
        }

        /// <summary>
        /// Adds configuration files or log files to a context menu strip
        /// </summary>
        private static void DirFiles(string path, string directory, ContextMenuStrip cms)
        {
            var dirInfo = new DirectoryInfo(path);

            if (!dirInfo.Exists)
                return;

            cms.Items.Clear();

            FileInfo[] files = dirInfo.GetFiles(directory);
            foreach (FileInfo file in files)
            {
                cms.Items.Add(file.Name);
            }
        }

        private void SetupConfigAndLogMenuStrips()
        {
            NginxConfigContextMenuStrip = new ContextMenuStrip();
            NginxConfigContextMenuStrip.ItemClicked += (s, e) =>
            {
                Misc.OpenFileEditor(Nginx.ConfDir + e.ClickedItem.ToString());
            };
            NginxLogContextMenuStrip = new ContextMenuStrip();
            NginxLogContextMenuStrip.ItemClicked += (s, e) =>
            {
                Misc.OpenFileEditor(Nginx.LogDir + e.ClickedItem.ToString());
            };
            MariaDBConfigContextMenuStrip = new ContextMenuStrip();
            MariaDBConfigContextMenuStrip.ItemClicked += (s, e) =>
            {
                Misc.OpenFileEditor(MariaDB.ConfDir + e.ClickedItem.ToString());
            };
            MariaDBLogContextMenuStrip = new ContextMenuStrip();
            MariaDBLogContextMenuStrip.ItemClicked += (s, e) =>
            {
                Misc.OpenFileEditor(MariaDB.LogDir + e.ClickedItem.ToString());
            };
            PHPConfigContextMenuStrip = new ContextMenuStrip();
            PHPConfigContextMenuStrip.ItemClicked += (s, e) =>
            {
                Misc.OpenFileEditor(PHP.ConfDir + e.ClickedItem.ToString());
            };
            PHPLogContextMenuStrip = new ContextMenuStrip();
            PHPLogContextMenuStrip.ItemClicked += (s, e) =>
            {
                Misc.OpenFileEditor(PHP.LogDir + e.ClickedItem.ToString());
            };

        }

        private void CreateWnmpCertificate()
        {
            if (!Directory.Exists(Nginx.ConfDir))
                Directory.CreateDirectory(Nginx.ConfDir);

            string keyFile = $"{Nginx.ConfDir}\\key.pem";
            string certFile = $"{Nginx.ConfDir}\\cert.pem";

            if (File.Exists(keyFile) && File.Exists(certFile))
                return;

            try
            {
                WnmpProgram.StartProcess(
                    $"{Program.StartupPath}\\nginx-bins\\default\\nginx.exe",
                    "-b",
                    $"{Program.StartupPath}\\nginx"
                    );
                Log.Notice(Language.Resource.GENERATED_SSL_KEYPAIR);
            }
            catch (Exception ex)
            {
                Log.Error($"GenerateSSLKeyPair(): {ex.Message}");
            }
        }

        private static ToolStripMenuItem CreateWnmpProgramMenuItem(WnmpProgram prog)
        {
            ToolStripMenuItem item = new();
            item.Text = Log.LogSectionToString(prog.ProgLogSection);
            ToolStripItem start = item.DropDownItems.Add(Language.Resource.START);
            start.Click += (s, e) => { prog.Start(); };
            ToolStripItem stop = item.DropDownItems.Add(Language.Resource.STOP);
            stop.Click += (s, e) => { prog.Stop(); };
            ToolStripItem restart = item.DropDownItems.Add(Language.Resource.RESTART);
            restart.Click += (s, e) => { prog.Restart(); };

            return item;
        }

        private void SetupTrayMenu()
        {
            ToolStripMenuItem controlpanel = new(Language.Resource.WNMP_CONTROL_PANEL);
            controlpanel.Click += (s, e) =>
            {
                visiblecore = true;
                base.SetVisibleCore(true);
                WindowState = FormWindowState.Normal;
                Show();
            };
            ContextMenuStrip cm = new();
            cm.Items.Add(controlpanel);
            cm.Items.Add("-");
            cm.Items.Add(CreateWnmpProgramMenuItem(Nginx));
            cm.Items.Add(CreateWnmpProgramMenuItem(MariaDB));
            cm.Items.Add(CreateWnmpProgramMenuItem(PHP));
            cm.Items.Add("-");
            ToolStripMenuItem exit = new(Language.Resource.EXIT);
            exit.Click += (s, e) => { Application.Exit(); };
            cm.Items.Add(exit);
            cm.Items.Add("-");
            ni.ContextMenuStrip = cm;
            ni.Icon = Properties.Resources.logo;
            ni.Click += (s, e) =>
            {
                visiblecore = true;
                base.SetVisibleCore(true);
                WindowState = FormWindowState.Normal;
                Show();
            };
            ni.Visible = true;
        }

        protected override void SetVisibleCore(bool value)
        {
            if (visiblecore == false)
            {
                value = false;
                if (!IsHandleCreated)
                    CreateHandle();
            }
            base.SetVisibleCore(value);
        }

        public MainFrm()
        {
            if (Properties.Settings.Default.StartMinimizedToTray)
            {
                Visible = false;
                Hide();
            }
            InitializeComponent();
            SetLanguage();
            Log.SetLogComponent(logRichTextBox);
            Log.Notice(Language.Resource.INITIALIZING_CONTROL_PANEL);
            Log.Notice(Language.Resource.WNMP_VERSION.Replace("{CURRENTVERSION}", Application.ProductVersion));
            Log.Notice($"{Language.Resource.WNMP_DIRECTORY}: {Program.StartupPath}");

            SetupNginx();
            SetupMariaDB();
            SetupPHP();
            if (!File.Exists($"{Program.StartupPath}\\www"))
            {
                Misc.CreateRelativeLink($"{Program.StartupPath}\\www", $"{Program.StartupPath}\\nginx\\www", Misc.SYMBOLIC_LINK_FLAG.Directory);
            }

            SetupConfigAndLogMenuStrips();
            SetupTrayMenu();
            updater = new WnmpUpdater(this);

            try
            {
                CreateWnmpCertificate();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }

            if (Properties.Settings.Default.StartMinimizedToTray)
            {
                visiblecore = false;
                base.SetVisibleCore(false);
            }

            if (Properties.Settings.Default.StartNginxOnLaunch)
            {
                Nginx.Start();
            }

            if (Properties.Settings.Default.StartMariaDBOnLaunch)
            {
                MariaDB.Start();
            }

            if (Properties.Settings.Default.StartPHPOnLaunch)
            {
                PHP.Start();
            }
        }

        /* Menu */

        /* File */

        private void WnmpOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var optionForm = new OptionsFrm(this);
            optionForm.ShowDialog(this);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* Applications Group Box */

        private static void CtxButton(object sender, ContextMenuStrip contextMenuStrip)
        {
            var btnSender = (Button)sender;
            var ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            contextMenuStrip.Show(ptLowerLeft);
        }

        private void NginxStartButton_Click(object sender, EventArgs e)
        {
            Nginx.Start();
        }

        private void MariadbStartButton_Click(object sender, EventArgs e)
        {
            MariaDB.Start();
        }

        private void PhpStartButton_Click(object sender, EventArgs e)
        {
            PHP.Start();
        }

        private void NginxStopButton_Click(object sender, EventArgs e)
        {
            Nginx.Stop();
        }

        private void MariadbStopButton_Click(object sender, EventArgs e)
        {
            MariaDB.Stop();
        }

        private void PhpStopButton_Click(object sender, EventArgs e)
        {
            PHP.Stop();
        }

        private void NginxRestartButton_Click(object sender, EventArgs e)
        {
            Nginx.Restart();
        }

        private void MariadbRestartButton_Click(object sender, EventArgs e)
        {
            MariaDB.Restart();
        }

        private void PhpRestartButton_Click(object sender, EventArgs e)
        {
            PHP.Restart();
        }

        private void NginxConfigButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirFiles(Nginx.ConfDir, "*.conf", NginxConfigContextMenuStrip);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            CtxButton(sender, NginxConfigContextMenuStrip);
        }

        private void MariadbConfigButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirFiles(MariaDB.ConfDir, "my.ini", MariaDBConfigContextMenuStrip);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            CtxButton(sender, MariaDBConfigContextMenuStrip);
        }

        private void PhpConfigButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirFiles(PHP.ConfDir, "php.ini", PHPConfigContextMenuStrip);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            CtxButton(sender, PHPConfigContextMenuStrip);
        }

        private void NginxLogButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirFiles(Nginx.LogDir, "*.log", NginxLogContextMenuStrip);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            CtxButton(sender, NginxLogContextMenuStrip);
        }

        private void MariadbLogButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirFiles(MariaDB.LogDir, "*.err", MariaDBLogContextMenuStrip);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            CtxButton(sender, MariaDBLogContextMenuStrip);
        }

        private void PhpLogButton_Click(object sender, EventArgs e)
        {
            try
            {
                DirFiles(PHP.LogDir, "*.log", PHPLogContextMenuStrip);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
            }
            CtxButton(sender, PHPLogContextMenuStrip);
        }

        /* */

        public void StopAll()
        {
            Nginx.Stop();
            MariaDB.Stop();
            PHP.Stop();
        }

        private void StartAllButton_Click(object sender, EventArgs e)
        {
            Nginx.Start();
            MariaDB.Start();
            PHP.Start();
        }

        private void StopAllButton_Click(object sender, EventArgs e)
        {
            StopAll();
        }

        private async void CheckForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await updater.CheckForUpdates();
        }

        private void GetHTTPHeadersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HTTPHeadersFrm httpHeadersFrm = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            httpHeadersFrm.Show(this);
        }

        private void HostToIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HostToIPFrm hostToIPFrm = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            hostToIPFrm.Show(this);
        }

        private void SupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Misc.OpenUrlInBrowser("https://groups.google.com/forum/#!forum/wnmp-users");
        }

        private void WebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Misc.OpenUrlInBrowser("https://wnmp.x64architecture.com");
        }

        private void DonateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Misc.OpenUrlInBrowser("https://wnmp.x64architecture.com/donate");
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var aboutFrm = new AboutFrm()
            {
                StartPosition = FormStartPosition.CenterParent
            };
            aboutFrm.ShowDialog(this);
        }

        private void ReportBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Misc.OpenUrlInBrowser("https://github.com/x64architecture/wnmp/issues/new");
        }

        private static void SetRunningStatusLabel(Label label, bool running)
        {
            if (running)
            {
                label.Text = "✓";
                label.ForeColor = Color.Green;
            }
            else
            {
                label.Text = "X";
                label.ForeColor = Color.DarkRed;
            }
        }

        private void AppsRunningTimer_Tick(object sender, EventArgs e)
        {
            SetRunningStatusLabel(nginxrunning, Nginx.IsRunning());
            SetRunningStatusLabel(phprunning, PHP.IsRunning());
            SetRunningStatusLabel(mariadbrunning, MariaDB.IsRunning());
        }

        private void LocalhostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Misc.OpenUrlInBrowser("http://localhost");
        }

        private void OpenMariaDBShellButton_Click(object sender, EventArgs e)
        {
            MariaDB.OpenShell();
        }

        private void setupMariaDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var setupMariaDBFrm = new SetupMariaDB(MariaDB);
            setupMariaDBFrm.StartPosition = FormStartPosition.CenterParent;
            setupMariaDBFrm.ShowDialog(this);
        }

        private void WnmpDirButton_Click(object sender, EventArgs e)
        {
            Misc.StartProcessAsync("explorer.exe", Program.StartupPath);
        }
        private void wwwDirButton_Click(object sender, EventArgs e)
        {
            string rootDirectory = Path.GetPathRoot(Program.StartupPath);
            Misc.StartProcessAsync("explorer.exe", rootDirectory + "www");
        }
        private void MainFrm_Shown(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.MariaDBIsSetup || !Directory.Exists($"{Program.StartupPath}\\mariadb\\data"))
            {
                using (var setupMariaDBFrm = new SetupMariaDB(MariaDB))
                {
                    setupMariaDBFrm.StartPosition = FormStartPosition.CenterParent;
                    setupMariaDBFrm.ShowDialog(this);
                }
                if (!Properties.Settings.Default.MariaDBIsSetup)
                {
                    Properties.Settings.Default.MariaDBIsSetup = true;
                    Properties.Settings.Default.Save();
                }
                SetupConfigAndLogMenuStrips();
            }
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && Properties.Settings.Default.MinimizeInsteadOfClosing)
            {
                e.Cancel = true;
                Hide();
            }
            else
            {
                Properties.Settings.Default.Save();
            }
        }

        private void MainFrm_Resize(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MinimizeToTray == false)
                return;

            if (WindowState == FormWindowState.Minimized)
                Hide();
        }
    }
}
