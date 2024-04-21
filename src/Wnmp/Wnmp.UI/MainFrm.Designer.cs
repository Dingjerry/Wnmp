namespace Wnmp.UI
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            WnmpMenuStrip = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            wnmpOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            setupMariaDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            hostToIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            getHTTPHeadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            reportBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            donateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            localhostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            wnmpDirButton = new System.Windows.Forms.Button();
            logRichTextBox = new System.Windows.Forms.RichTextBox();
            applicationsGroupBox = new System.Windows.Forms.GroupBox();
            phpRestartButton = new System.Windows.Forms.Button();
            mariadbRestartButton = new System.Windows.Forms.Button();
            nginxRestartButton = new System.Windows.Forms.Button();
            phpLogButton = new System.Windows.Forms.Button();
            mariadbLogButton = new System.Windows.Forms.Button();
            nginxLogButton = new System.Windows.Forms.Button();
            phpConfigButton = new System.Windows.Forms.Button();
            mariadbConfigButton = new System.Windows.Forms.Button();
            nginxConfigButton = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            phprunning = new System.Windows.Forms.Label();
            mariadbrunning = new System.Windows.Forms.Label();
            optionsLabel = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            applicationLabel = new System.Windows.Forms.Label();
            nginxrunning = new System.Windows.Forms.Label();
            runningLabel = new System.Windows.Forms.Label();
            mariadbStopButton = new System.Windows.Forms.Button();
            mariadbStartButton = new System.Windows.Forms.Button();
            phpStartButton = new System.Windows.Forms.Button();
            phpStopButton = new System.Windows.Forms.Button();
            nginxStartButton = new System.Windows.Forms.Button();
            nginxStopButton = new System.Windows.Forms.Button();
            startAllButton = new System.Windows.Forms.Button();
            stopAllButton = new System.Windows.Forms.Button();
            openMariaDBShellButton = new System.Windows.Forms.Button();
            AppsRunningTimer = new System.Windows.Forms.Timer(components);
            wwwDirButton = new System.Windows.Forms.Button();
            WnmpMenuStrip.SuspendLayout();
            applicationsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // WnmpMenuStrip
            // 
            WnmpMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            WnmpMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem, localhostToolStripMenuItem });
            WnmpMenuStrip.Location = new System.Drawing.Point(0, 0);
            WnmpMenuStrip.Name = "WnmpMenuStrip";
            WnmpMenuStrip.Padding = new System.Windows.Forms.Padding(11, 3, 0, 3);
            WnmpMenuStrip.Size = new System.Drawing.Size(1186, 34);
            WnmpMenuStrip.TabIndex = 0;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { wnmpOptionsToolStripMenuItem, checkForUpdatesToolStripMenuItem, setupMariaDBToolStripMenuItem, toolStripSeparator1, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(56, 28);
            fileToolStripMenuItem.Text = "&File";
            // 
            // wnmpOptionsToolStripMenuItem
            // 
            wnmpOptionsToolStripMenuItem.Name = "wnmpOptionsToolStripMenuItem";
            wnmpOptionsToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            wnmpOptionsToolStripMenuItem.Text = "Wnmp Options";
            wnmpOptionsToolStripMenuItem.Click += WnmpOptionsToolStripMenuItem_Click;
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            checkForUpdatesToolStripMenuItem.Click += CheckForUpdatesToolStripMenuItem_Click;
            // 
            // setupMariaDBToolStripMenuItem
            // 
            setupMariaDBToolStripMenuItem.Name = "setupMariaDBToolStripMenuItem";
            setupMariaDBToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            setupMariaDBToolStripMenuItem.Text = "Setup MariaDB";
            setupMariaDBToolStripMenuItem.Click += setupMariaDBToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(269, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(272, 34);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { hostToIPToolStripMenuItem, getHTTPHeadersToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new System.Drawing.Size(71, 28);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // hostToIPToolStripMenuItem
            // 
            hostToIPToolStripMenuItem.Name = "hostToIPToolStripMenuItem";
            hostToIPToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            hostToIPToolStripMenuItem.Text = "Host To IP";
            hostToIPToolStripMenuItem.Click += HostToIPToolStripMenuItem_Click;
            // 
            // getHTTPHeadersToolStripMenuItem
            // 
            getHTTPHeadersToolStripMenuItem.Name = "getHTTPHeadersToolStripMenuItem";
            getHTTPHeadersToolStripMenuItem.Size = new System.Drawing.Size(266, 34);
            getHTTPHeadersToolStripMenuItem.Text = "Get HTTP Headers";
            getHTTPHeadersToolStripMenuItem.Click += GetHTTPHeadersToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { supportToolStripMenuItem, reportBugToolStripMenuItem, toolStripSeparator2, websiteToolStripMenuItem, donateToolStripMenuItem, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(67, 28);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // supportToolStripMenuItem
            // 
            supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            supportToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            supportToolStripMenuItem.Text = "Community Support";
            supportToolStripMenuItem.Click += SupportToolStripMenuItem_Click;
            // 
            // reportBugToolStripMenuItem
            // 
            reportBugToolStripMenuItem.Name = "reportBugToolStripMenuItem";
            reportBugToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            reportBugToolStripMenuItem.Text = "Report Bug";
            reportBugToolStripMenuItem.Click += ReportBugToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(283, 6);
            // 
            // websiteToolStripMenuItem
            // 
            websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            websiteToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            websiteToolStripMenuItem.Text = "Website";
            websiteToolStripMenuItem.Click += WebsiteToolStripMenuItem_Click;
            // 
            // donateToolStripMenuItem
            // 
            donateToolStripMenuItem.Name = "donateToolStripMenuItem";
            donateToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            donateToolStripMenuItem.Text = "Donate";
            donateToolStripMenuItem.Click += DonateToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(286, 34);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // localhostToolStripMenuItem
            // 
            localhostToolStripMenuItem.Name = "localhostToolStripMenuItem";
            localhostToolStripMenuItem.Size = new System.Drawing.Size(103, 28);
            localhostToolStripMenuItem.Text = "localhost";
            localhostToolStripMenuItem.Click += LocalhostToolStripMenuItem_Click;
            // 
            // wnmpDirButton
            // 
            wnmpDirButton.Location = new System.Drawing.Point(1044, 243);
            wnmpDirButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            wnmpDirButton.Name = "wnmpDirButton";
            wnmpDirButton.Size = new System.Drawing.Size(116, 60);
            wnmpDirButton.TabIndex = 65;
            wnmpDirButton.Text = "Wnmp Directory";
            wnmpDirButton.UseVisualStyleBackColor = true;
            wnmpDirButton.Click += WnmpDirButton_Click;
            // 
            // logRichTextBox
            // 
            logRichTextBox.BackColor = System.Drawing.Color.White;
            logRichTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            logRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            logRichTextBox.Location = new System.Drawing.Point(0, 425);
            logRichTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            logRichTextBox.Name = "logRichTextBox";
            logRichTextBox.ReadOnly = true;
            logRichTextBox.Size = new System.Drawing.Size(1186, 242);
            logRichTextBox.TabIndex = 61;
            logRichTextBox.Text = "";
            // 
            // applicationsGroupBox
            // 
            applicationsGroupBox.Controls.Add(phpRestartButton);
            applicationsGroupBox.Controls.Add(mariadbRestartButton);
            applicationsGroupBox.Controls.Add(nginxRestartButton);
            applicationsGroupBox.Controls.Add(phpLogButton);
            applicationsGroupBox.Controls.Add(mariadbLogButton);
            applicationsGroupBox.Controls.Add(nginxLogButton);
            applicationsGroupBox.Controls.Add(phpConfigButton);
            applicationsGroupBox.Controls.Add(mariadbConfigButton);
            applicationsGroupBox.Controls.Add(nginxConfigButton);
            applicationsGroupBox.Controls.Add(label8);
            applicationsGroupBox.Controls.Add(label7);
            applicationsGroupBox.Controls.Add(phprunning);
            applicationsGroupBox.Controls.Add(mariadbrunning);
            applicationsGroupBox.Controls.Add(optionsLabel);
            applicationsGroupBox.Controls.Add(label4);
            applicationsGroupBox.Controls.Add(applicationLabel);
            applicationsGroupBox.Controls.Add(nginxrunning);
            applicationsGroupBox.Controls.Add(runningLabel);
            applicationsGroupBox.Controls.Add(mariadbStopButton);
            applicationsGroupBox.Controls.Add(mariadbStartButton);
            applicationsGroupBox.Controls.Add(phpStartButton);
            applicationsGroupBox.Controls.Add(phpStopButton);
            applicationsGroupBox.Controls.Add(nginxStartButton);
            applicationsGroupBox.Controls.Add(nginxStopButton);
            applicationsGroupBox.Location = new System.Drawing.Point(22, 50);
            applicationsGroupBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            applicationsGroupBox.Name = "applicationsGroupBox";
            applicationsGroupBox.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            applicationsGroupBox.Size = new System.Drawing.Size(996, 323);
            applicationsGroupBox.TabIndex = 60;
            applicationsGroupBox.TabStop = false;
            applicationsGroupBox.Text = "Applications";
            // 
            // phpRestartButton
            // 
            phpRestartButton.Location = new System.Drawing.Point(506, 243);
            phpRestartButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            phpRestartButton.Name = "phpRestartButton";
            phpRestartButton.Size = new System.Drawing.Size(91, 51);
            phpRestartButton.TabIndex = 78;
            phpRestartButton.Text = "Restart";
            phpRestartButton.UseVisualStyleBackColor = true;
            phpRestartButton.Click += PhpRestartButton_Click;
            // 
            // mariadbRestartButton
            // 
            mariadbRestartButton.Location = new System.Drawing.Point(506, 163);
            mariadbRestartButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            mariadbRestartButton.Name = "mariadbRestartButton";
            mariadbRestartButton.Size = new System.Drawing.Size(91, 51);
            mariadbRestartButton.TabIndex = 77;
            mariadbRestartButton.Text = "Restart";
            mariadbRestartButton.UseVisualStyleBackColor = true;
            mariadbRestartButton.Click += MariadbRestartButton_Click;
            // 
            // nginxRestartButton
            // 
            nginxRestartButton.Location = new System.Drawing.Point(506, 83);
            nginxRestartButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            nginxRestartButton.Name = "nginxRestartButton";
            nginxRestartButton.Size = new System.Drawing.Size(91, 51);
            nginxRestartButton.TabIndex = 76;
            nginxRestartButton.Text = "Restart";
            nginxRestartButton.UseVisualStyleBackColor = true;
            nginxRestartButton.Click += NginxRestartButton_Click;
            // 
            // phpLogButton
            // 
            phpLogButton.Location = new System.Drawing.Point(772, 243);
            phpLogButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            phpLogButton.Name = "phpLogButton";
            phpLogButton.Size = new System.Drawing.Size(91, 51);
            phpLogButton.TabIndex = 75;
            phpLogButton.Text = "Logs";
            phpLogButton.UseVisualStyleBackColor = true;
            phpLogButton.Click += PhpLogButton_Click;
            // 
            // mariadbLogButton
            // 
            mariadbLogButton.Location = new System.Drawing.Point(772, 163);
            mariadbLogButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            mariadbLogButton.Name = "mariadbLogButton";
            mariadbLogButton.Size = new System.Drawing.Size(91, 51);
            mariadbLogButton.TabIndex = 74;
            mariadbLogButton.Text = "Logs";
            mariadbLogButton.UseVisualStyleBackColor = true;
            mariadbLogButton.Click += MariadbLogButton_Click;
            // 
            // nginxLogButton
            // 
            nginxLogButton.Location = new System.Drawing.Point(772, 85);
            nginxLogButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            nginxLogButton.Name = "nginxLogButton";
            nginxLogButton.Size = new System.Drawing.Size(91, 51);
            nginxLogButton.TabIndex = 73;
            nginxLogButton.Text = "Logs";
            nginxLogButton.UseVisualStyleBackColor = true;
            nginxLogButton.Click += NginxLogButton_Click;
            // 
            // phpConfigButton
            // 
            phpConfigButton.Location = new System.Drawing.Point(608, 243);
            phpConfigButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            phpConfigButton.Name = "phpConfigButton";
            phpConfigButton.Size = new System.Drawing.Size(152, 51);
            phpConfigButton.TabIndex = 72;
            phpConfigButton.Text = "Configuration";
            phpConfigButton.UseVisualStyleBackColor = true;
            phpConfigButton.Click += PhpConfigButton_Click;
            // 
            // mariadbConfigButton
            // 
            mariadbConfigButton.Location = new System.Drawing.Point(608, 163);
            mariadbConfigButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            mariadbConfigButton.Name = "mariadbConfigButton";
            mariadbConfigButton.Size = new System.Drawing.Size(152, 51);
            mariadbConfigButton.TabIndex = 71;
            mariadbConfigButton.Text = "Configuration";
            mariadbConfigButton.UseVisualStyleBackColor = true;
            mariadbConfigButton.Click += MariadbConfigButton_Click;
            // 
            // nginxConfigButton
            // 
            nginxConfigButton.Location = new System.Drawing.Point(608, 83);
            nginxConfigButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            nginxConfigButton.Name = "nginxConfigButton";
            nginxConfigButton.Size = new System.Drawing.Size(152, 51);
            nginxConfigButton.TabIndex = 70;
            nginxConfigButton.Text = "Configuration";
            nginxConfigButton.UseVisualStyleBackColor = true;
            nginxConfigButton.Click += NginxConfigButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(145, 254);
            label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(52, 25);
            label8.TabIndex = 69;
            label8.Text = "PHP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(145, 176);
            label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(88, 25);
            label7.TabIndex = 68;
            label7.Text = "MariaDB";
            // 
            // phprunning
            // 
            phprunning.AutoSize = true;
            phprunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            phprunning.ForeColor = System.Drawing.Color.DarkRed;
            phprunning.Location = new System.Drawing.Point(41, 250);
            phprunning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            phprunning.Name = "phprunning";
            phprunning.Size = new System.Drawing.Size(31, 29);
            phprunning.TabIndex = 67;
            phprunning.Text = "X";
            // 
            // mariadbrunning
            // 
            mariadbrunning.AutoSize = true;
            mariadbrunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            mariadbrunning.ForeColor = System.Drawing.Color.DarkRed;
            mariadbrunning.Location = new System.Drawing.Point(41, 168);
            mariadbrunning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            mariadbrunning.Name = "mariadbrunning";
            mariadbrunning.Size = new System.Drawing.Size(31, 29);
            mariadbrunning.TabIndex = 66;
            mariadbrunning.Text = "X";
            // 
            // optionsLabel
            // 
            optionsLabel.AutoSize = true;
            optionsLabel.BackColor = System.Drawing.Color.Transparent;
            optionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            optionsLabel.Location = new System.Drawing.Point(300, 43);
            optionsLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            optionsLabel.Name = "optionsLabel";
            optionsLabel.Size = new System.Drawing.Size(74, 20);
            optionsLabel.TabIndex = 65;
            optionsLabel.Text = "Options";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(145, 94);
            label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(62, 25);
            label4.TabIndex = 63;
            label4.Text = "Nginx";
            // 
            // applicationLabel
            // 
            applicationLabel.AutoSize = true;
            applicationLabel.BackColor = System.Drawing.Color.Transparent;
            applicationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            applicationLabel.Location = new System.Drawing.Point(145, 43);
            applicationLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            applicationLabel.Name = "applicationLabel";
            applicationLabel.Size = new System.Drawing.Size(102, 20);
            applicationLabel.TabIndex = 62;
            applicationLabel.Text = "Application";
            // 
            // nginxrunning
            // 
            nginxrunning.AutoSize = true;
            nginxrunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            nginxrunning.ForeColor = System.Drawing.Color.DarkRed;
            nginxrunning.Location = new System.Drawing.Point(41, 86);
            nginxrunning.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            nginxrunning.Name = "nginxrunning";
            nginxrunning.Size = new System.Drawing.Size(31, 29);
            nginxrunning.TabIndex = 61;
            nginxrunning.Text = "X";
            // 
            // runningLabel
            // 
            runningLabel.AutoSize = true;
            runningLabel.BackColor = System.Drawing.Color.Transparent;
            runningLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            runningLabel.Location = new System.Drawing.Point(11, 43);
            runningLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            runningLabel.Name = "runningLabel";
            runningLabel.Size = new System.Drawing.Size(77, 20);
            runningLabel.TabIndex = 60;
            runningLabel.Text = "Running";
            // 
            // mariadbStopButton
            // 
            mariadbStopButton.Location = new System.Drawing.Point(404, 165);
            mariadbStopButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            mariadbStopButton.Name = "mariadbStopButton";
            mariadbStopButton.Size = new System.Drawing.Size(91, 51);
            mariadbStopButton.TabIndex = 57;
            mariadbStopButton.Text = "Stop";
            mariadbStopButton.UseVisualStyleBackColor = true;
            mariadbStopButton.Click += MariadbStopButton_Click;
            // 
            // mariadbStartButton
            // 
            mariadbStartButton.Location = new System.Drawing.Point(300, 165);
            mariadbStartButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            mariadbStartButton.Name = "mariadbStartButton";
            mariadbStartButton.Size = new System.Drawing.Size(91, 51);
            mariadbStartButton.TabIndex = 56;
            mariadbStartButton.Text = "Start";
            mariadbStartButton.UseVisualStyleBackColor = true;
            mariadbStartButton.Click += MariadbStartButton_Click;
            // 
            // phpStartButton
            // 
            phpStartButton.Location = new System.Drawing.Point(300, 243);
            phpStartButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            phpStartButton.Name = "phpStartButton";
            phpStartButton.Size = new System.Drawing.Size(91, 51);
            phpStartButton.TabIndex = 55;
            phpStartButton.Text = "Start";
            phpStartButton.UseVisualStyleBackColor = true;
            phpStartButton.Click += PhpStartButton_Click;
            // 
            // phpStopButton
            // 
            phpStopButton.Location = new System.Drawing.Point(404, 243);
            phpStopButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            phpStopButton.Name = "phpStopButton";
            phpStopButton.Size = new System.Drawing.Size(91, 51);
            phpStopButton.TabIndex = 54;
            phpStopButton.Text = "Stop";
            phpStopButton.UseVisualStyleBackColor = true;
            phpStopButton.Click += PhpStopButton_Click;
            // 
            // nginxStartButton
            // 
            nginxStartButton.Location = new System.Drawing.Point(300, 83);
            nginxStartButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            nginxStartButton.Name = "nginxStartButton";
            nginxStartButton.Size = new System.Drawing.Size(91, 51);
            nginxStartButton.TabIndex = 53;
            nginxStartButton.Text = "Start";
            nginxStartButton.UseVisualStyleBackColor = true;
            nginxStartButton.Click += NginxStartButton_Click;
            // 
            // nginxStopButton
            // 
            nginxStopButton.Location = new System.Drawing.Point(404, 83);
            nginxStopButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            nginxStopButton.Name = "nginxStopButton";
            nginxStopButton.Size = new System.Drawing.Size(91, 51);
            nginxStopButton.TabIndex = 52;
            nginxStopButton.Text = "Stop";
            nginxStopButton.UseVisualStyleBackColor = true;
            nginxStopButton.Click += NginxStopButton_Click;
            // 
            // startAllButton
            // 
            startAllButton.Location = new System.Drawing.Point(1044, 53);
            startAllButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            startAllButton.Name = "startAllButton";
            startAllButton.Size = new System.Drawing.Size(116, 50);
            startAllButton.TabIndex = 62;
            startAllButton.Text = "Start all";
            startAllButton.UseVisualStyleBackColor = true;
            startAllButton.Click += StartAllButton_Click;
            // 
            // stopAllButton
            // 
            stopAllButton.Location = new System.Drawing.Point(1044, 113);
            stopAllButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            stopAllButton.Name = "stopAllButton";
            stopAllButton.Size = new System.Drawing.Size(116, 50);
            stopAllButton.TabIndex = 63;
            stopAllButton.Text = "Stop all";
            stopAllButton.UseVisualStyleBackColor = true;
            stopAllButton.Click += StopAllButton_Click;
            // 
            // openMariaDBShellButton
            // 
            openMariaDBShellButton.Location = new System.Drawing.Point(1044, 173);
            openMariaDBShellButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            openMariaDBShellButton.Name = "openMariaDBShellButton";
            openMariaDBShellButton.Size = new System.Drawing.Size(116, 60);
            openMariaDBShellButton.TabIndex = 64;
            openMariaDBShellButton.Text = "MariaDB Shell";
            openMariaDBShellButton.UseVisualStyleBackColor = true;
            openMariaDBShellButton.Click += OpenMariaDBShellButton_Click;
            // 
            // AppsRunningTimer
            // 
            AppsRunningTimer.Enabled = true;
            AppsRunningTimer.Interval = 1000;
            AppsRunningTimer.Tick += AppsRunningTimer_Tick;
            // 
            // wwwDirButton
            // 
            wwwDirButton.Location = new System.Drawing.Point(1044, 313);
            wwwDirButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            wwwDirButton.Name = "wwwDirButton";
            wwwDirButton.Size = new System.Drawing.Size(116, 60);
            wwwDirButton.TabIndex = 66;
            wwwDirButton.Text = "Wnmp Directory";
            wwwDirButton.UseVisualStyleBackColor = true;
            wwwDirButton.Click += wwwDirButton_Click;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1186, 667);
            Controls.Add(wwwDirButton);
            Controls.Add(wnmpDirButton);
            Controls.Add(logRichTextBox);
            Controls.Add(applicationsGroupBox);
            Controls.Add(startAllButton);
            Controls.Add(stopAllButton);
            Controls.Add(openMariaDBShellButton);
            Controls.Add(WnmpMenuStrip);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = WnmpMenuStrip;
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            MaximizeBox = false;
            Name = "MainFrm";
            Text = "Wnmp Control Panel";
            FormClosing += MainFrm_FormClosing;
            Shown += MainFrm_Shown;
            Resize += MainFrm_Resize;
            WnmpMenuStrip.ResumeLayout(false);
            WnmpMenuStrip.PerformLayout();
            applicationsGroupBox.ResumeLayout(false);
            applicationsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip WnmpMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button wnmpDirButton;
        public System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.GroupBox applicationsGroupBox;
        private System.Windows.Forms.Button phpLogButton;
        private System.Windows.Forms.Button mariadbLogButton;
        private System.Windows.Forms.Button nginxLogButton;
        private System.Windows.Forms.Button phpConfigButton;
        private System.Windows.Forms.Button mariadbConfigButton;
        private System.Windows.Forms.Button nginxConfigButton;
        private System.Windows.Forms.Label optionsLabel;
        private System.Windows.Forms.Label applicationLabel;
        private System.Windows.Forms.Label runningLabel;
        private System.Windows.Forms.ToolStripMenuItem wnmpOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localhostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hostToIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getHTTPHeadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem donateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button nginxRestartButton;
        private System.Windows.Forms.Button mariadbStopButton;
        private System.Windows.Forms.Button mariadbStartButton;
        private System.Windows.Forms.Button phpStartButton;
        private System.Windows.Forms.Button phpStopButton;
        private System.Windows.Forms.Button nginxStartButton;
        private System.Windows.Forms.Button nginxStopButton;
        private System.Windows.Forms.Button phpRestartButton;
        private System.Windows.Forms.Button mariadbRestartButton;
        private System.Windows.Forms.Button startAllButton;
        private System.Windows.Forms.Button stopAllButton;
        private System.Windows.Forms.Button openMariaDBShellButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label phprunning;
        private System.Windows.Forms.Label mariadbrunning;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nginxrunning;
        private System.Windows.Forms.Timer AppsRunningTimer;
        private System.Windows.Forms.ToolStripMenuItem setupMariaDBToolStripMenuItem;
        private System.Windows.Forms.Button wwwDirButton;
    }
}