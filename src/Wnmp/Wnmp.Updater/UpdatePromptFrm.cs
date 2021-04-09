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
using System.Diagnostics;
using System.Windows.Forms;
using Wnmp.UI;

namespace Wnmp.Updater
{
    public partial class UpdatePromptFrm : Form
    {
        private readonly string changeLogUrl;

        private void SetLanguage()
        {
            Text = Language.Resource.NEW_VERSION_FOUND_EX;
            viewChangelogLabel.Text = Language.Resource.VIEW_CHANGELOG;
            wouldYouLikeToLabel.Text = Language.Resource.WOULD_YOU_LIKE_TO_DOWNLOAD_THIS_UPDATE_QM;
            yesButton.Text = Language.Resource.YES;
            noButton.Text = Language.Resource.NO;
        }

        protected override CreateParams CreateParams
        {
            get {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~0x00040000; // Remove WS_THICKFRAME (Disables resizing)
                return cp;
            }
        }

        public UpdatePromptFrm(string ChangeLogUrl, Version CurrentVersion, Version NewVersion)
        {
            InitializeComponent();
            changeLogUrl = ChangeLogUrl;
            currentVersionLabel.Text = CurrentVersion.ToString();
            newVersionLabel.Text = NewVersion.ToString();
            SetLanguage();
        }

        private void ViewChangelogLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Misc.OpenUrlInBrowser(changeLogUrl);
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }
}
