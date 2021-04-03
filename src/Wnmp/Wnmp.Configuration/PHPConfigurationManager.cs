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
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Wnmp.Configuration
{
    class PHPConfigurationManager
    {
        public class PHPExtension
        {
            public int LineNum;
            public string Name;
            public bool Enabled;
            public bool ZendExtension;
        }

        public List<PHPExtension> PHPExtensions;

        private string IniFilePath;
        private string[] TmpIniFile;

        public void LoadPHPExtensions(string phpBinPath)
        {
            IniFilePath = $"{Program.StartupPath}\\php-bins\\{phpBinPath}\\php.ini";
            TmpIniFile = File.ReadAllLines(IniFilePath);
            PHPExtensions = new List<PHPExtension>();

            for (int linenum = 0; linenum < TmpIniFile.Length; linenum++) {
                string str = TmpIniFile[linenum].Trim();
                if (str == String.Empty)
                    continue;
                if (str[0] == ';') {
                    string tmp = str[1..];
                    if (!tmp.StartsWith("extension") && !tmp.StartsWith("zend_extension"))
                        continue;
                }
                // (zend_extension|extension)\s*\=\s*["]?(.*?\.dll)
                var m = Regex.Match(str, @"(zend_extension|extension)(=)((?:[a-z][a-z0-9_]*))");
                if (m.Success) {
                    PHPExtension Ext = new() {
                        Name = m.Groups[3].Value,
                        ZendExtension = m.Groups[1].Value == "zend_extension",
                        Enabled = str[0] != ';',
                        LineNum = linenum,
                    };
                    PHPExtensions.Add(Ext);
                }
            }
        }

        public void SavePHPIniOptions()
        {
            foreach (PHPExtension ext in PHPExtensions) {
                string extension_token = ext.ZendExtension ? "zend_extension" : "extension";
                string enabled_char = ext.Enabled ? "" : ";";
                TmpIniFile[ext.LineNum] = $"{enabled_char}{extension_token}={ext.Name}";
            }
            File.WriteAllLines(IniFilePath, TmpIniFile);
        }
    }
}
