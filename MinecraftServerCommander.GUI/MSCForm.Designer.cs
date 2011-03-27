/*
 * Copyright (C) 2011 by Adam Hellberg
 * 
 * This file is part of Minecraft Server Commander.
 *
 * Minecraft Server Commander is free software: you can redistribute it
 * and/or modify it under the terms of the GNU General Public License as
 * published by the Free Software Foundation, either version 3 of the
 * License, or (at your option) any later version.
 * 
 * Minecraft Server Commander is distributed in the hope that it
 * will be useful, but WITHOUT ANY WARRANTY; without even the implied
 * warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 * See the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License along
 * with Minecraft Server Commander.  If not, see <http://www.gnu.org/licenses/>.
 * 
 */

namespace MinecraftServerCommander.GUI
{
	partial class MscForm
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
			if (disposing && (components != null))
			{
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
			this.label1 = new System.Windows.Forms.Label();
			this.pathBox = new System.Windows.Forms.TextBox();
			this.browseButton = new System.Windows.Forms.Button();
			this.MinecraftSFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.secondsBox = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.clearListButton = new System.Windows.Forms.Button();
			this.removeCmdButton = new System.Windows.Forms.Button();
			this.addCmdButton = new System.Windows.Forms.Button();
			this.commandBox = new System.Windows.Forms.TextBox();
			this.stopACSButton = new System.Windows.Forms.Button();
			this.startACSButton = new System.Windows.Forms.Button();
			this.commandList = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.itemBox = new System.Windows.Forms.ComboBox();
			this.giveButton = new System.Windows.Forms.Button();
			this.quantityBox = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.namesBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.mainGroup = new System.Windows.Forms.Panel();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.execFileLog = new System.Windows.Forms.TextBox();
			this.execFileButton = new System.Windows.Forms.Button();
			this.execFileLabel = new System.Windows.Forms.Label();
			this.execFileProgress = new System.Windows.Forms.ProgressBar();
			this.execFileBox = new System.Windows.Forms.TextBox();
			this.execFileBrowse = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.creditCheckBox = new System.Windows.Forms.CheckBox();
			this.exitButton = new System.Windows.Forms.Button();
			this.stopMCButton = new System.Windows.Forms.Button();
			this.startMCButton = new System.Windows.Forms.Button();
			this.execFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.execFileWorker = new System.ComponentModel.BackgroundWorker();
			this.MscTabControl = new System.Windows.Forms.TabControl();
			this.mainTab = new System.Windows.Forms.TabPage();
			this.BackupTab = new System.Windows.Forms.TabPage();
			this.BackupPanel = new System.Windows.Forms.Panel();
			this.BackupListGroup = new System.Windows.Forms.GroupBox();
			this.ArchBackupBtn = new System.Windows.Forms.Button();
			this.DelBackupBtn = new System.Windows.Forms.Button();
			this.RestoreBackupBtn = new System.Windows.Forms.Button();
			this.BackupListBox = new System.Windows.Forms.ListBox();
			this.BackupStatusGroup = new System.Windows.Forms.GroupBox();
			this.CurrActionShort = new System.Windows.Forms.Label();
			this.CurrActionDesc = new System.Windows.Forms.Label();
			this.CurrActLabel = new System.Windows.Forms.Label();
			this.BackupProgress = new System.Windows.Forms.ProgressBar();
			this.BackupLogBox = new System.Windows.Forms.TextBox();
			this.WorldBrowseButton = new System.Windows.Forms.Button();
			this.WorldFolderBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.worldFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.backupWorker = new System.ComponentModel.BackgroundWorker();
			this.mscMenu = new System.Windows.Forms.MenuStrip();
			this.helpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.licenseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.secondsBox)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
			this.mainGroup.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.MscTabControl.SuspendLayout();
			this.mainTab.SuspendLayout();
			this.BackupTab.SuspendLayout();
			this.BackupPanel.SuspendLayout();
			this.BackupListGroup.SuspendLayout();
			this.BackupStatusGroup.SuspendLayout();
			this.mscMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Minecraft Server exe location:";
			// 
			// pathBox
			// 
			this.pathBox.Location = new System.Drawing.Point(166, 29);
			this.pathBox.Name = "pathBox";
			this.pathBox.ReadOnly = true;
			this.pathBox.Size = new System.Drawing.Size(242, 20);
			this.pathBox.TabIndex = 1;
			// 
			// browseButton
			// 
			this.browseButton.Location = new System.Drawing.Point(414, 27);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(75, 23);
			this.browseButton.TabIndex = 2;
			this.browseButton.Text = "Browse...";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
			// 
			// MinecraftSFileDialog
			// 
			this.MinecraftSFileDialog.Filter = "exe files (*.exe)|*.exe";
			this.MinecraftSFileDialog.Title = "Browse to and select your minecraft server executable...";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.secondsBox);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.clearListButton);
			this.groupBox1.Controls.Add(this.removeCmdButton);
			this.groupBox1.Controls.Add(this.addCmdButton);
			this.groupBox1.Controls.Add(this.commandBox);
			this.groupBox1.Controls.Add(this.stopACSButton);
			this.groupBox1.Controls.Add(this.startACSButton);
			this.groupBox1.Controls.Add(this.commandList);
			this.groupBox1.Location = new System.Drawing.Point(3, 144);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(283, 217);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Auto Command System";
			// 
			// secondsBox
			// 
			this.secondsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.secondsBox.Location = new System.Drawing.Point(161, 133);
			this.secondsBox.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.secondsBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.secondsBox.Name = "secondsBox";
			this.secondsBox.Size = new System.Drawing.Size(91, 20);
			this.secondsBox.TabIndex = 6;
			this.secondsBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.secondsBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(58, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Delay (in seconds):";
			// 
			// clearListButton
			// 
			this.clearListButton.Location = new System.Drawing.Point(161, 104);
			this.clearListButton.Name = "clearListButton";
			this.clearListButton.Size = new System.Drawing.Size(117, 23);
			this.clearListButton.TabIndex = 1;
			this.clearListButton.Text = "Clear List";
			this.clearListButton.UseVisualStyleBackColor = true;
			this.clearListButton.Click += new System.EventHandler(this.ClearListButtonClick);
			// 
			// removeCmdButton
			// 
			this.removeCmdButton.Location = new System.Drawing.Point(161, 74);
			this.removeCmdButton.Name = "removeCmdButton";
			this.removeCmdButton.Size = new System.Drawing.Size(117, 23);
			this.removeCmdButton.TabIndex = 1;
			this.removeCmdButton.Text = "Remove Command";
			this.removeCmdButton.UseVisualStyleBackColor = true;
			this.removeCmdButton.Click += new System.EventHandler(this.RemoveCmdButtonClick);
			// 
			// addCmdButton
			// 
			this.addCmdButton.Location = new System.Drawing.Point(161, 45);
			this.addCmdButton.Name = "addCmdButton";
			this.addCmdButton.Size = new System.Drawing.Size(117, 23);
			this.addCmdButton.TabIndex = 1;
			this.addCmdButton.Text = "Add Command";
			this.addCmdButton.UseVisualStyleBackColor = true;
			this.addCmdButton.Click += new System.EventHandler(this.AddCmdButtonClick);
			// 
			// commandBox
			// 
			this.commandBox.Location = new System.Drawing.Point(161, 19);
			this.commandBox.Name = "commandBox";
			this.commandBox.Size = new System.Drawing.Size(117, 20);
			this.commandBox.TabIndex = 1;
			// 
			// stopACSButton
			// 
			this.stopACSButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.stopACSButton.Location = new System.Drawing.Point(6, 188);
			this.stopACSButton.Name = "stopACSButton";
			this.stopACSButton.Size = new System.Drawing.Size(272, 23);
			this.stopACSButton.TabIndex = 1;
			this.stopACSButton.Text = "Stop Auto Command System";
			this.stopACSButton.UseVisualStyleBackColor = true;
			this.stopACSButton.Click += new System.EventHandler(this.StopAcsButtonClick);
			// 
			// startACSButton
			// 
			this.startACSButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.startACSButton.Enabled = false;
			this.startACSButton.Location = new System.Drawing.Point(6, 159);
			this.startACSButton.Name = "startACSButton";
			this.startACSButton.Size = new System.Drawing.Size(272, 23);
			this.startACSButton.TabIndex = 1;
			this.startACSButton.Text = "Start Auto Command System";
			this.startACSButton.UseVisualStyleBackColor = true;
			this.startACSButton.Click += new System.EventHandler(this.StartAcsButtonClick);
			// 
			// commandList
			// 
			this.commandList.FormattingEnabled = true;
			this.commandList.Location = new System.Drawing.Point(6, 19);
			this.commandList.Name = "commandList";
			this.commandList.Size = new System.Drawing.Size(149, 108);
			this.commandList.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.itemBox);
			this.groupBox2.Controls.Add(this.giveButton);
			this.groupBox2.Controls.Add(this.quantityBox);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.namesBox);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(238, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(235, 135);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Give Helper";
			// 
			// itemBox
			// 
			this.itemBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.itemBox.DropDownWidth = 150;
			this.itemBox.FormattingEnabled = true;
			this.itemBox.Location = new System.Drawing.Point(107, 59);
			this.itemBox.Name = "itemBox";
			this.itemBox.Size = new System.Drawing.Size(117, 21);
			this.itemBox.TabIndex = 7;
			// 
			// giveButton
			// 
			this.giveButton.Location = new System.Drawing.Point(6, 105);
			this.giveButton.Name = "giveButton";
			this.giveButton.Size = new System.Drawing.Size(218, 23);
			this.giveButton.TabIndex = 6;
			this.giveButton.Text = "Click button to give!";
			this.giveButton.UseVisualStyleBackColor = true;
			this.giveButton.Click += new System.EventHandler(this.GiveButtonClick);
			// 
			// quantityBox
			// 
			this.quantityBox.Location = new System.Drawing.Point(107, 82);
			this.quantityBox.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
			this.quantityBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.quantityBox.Name = "quantityBox";
			this.quantityBox.Size = new System.Drawing.Size(117, 20);
			this.quantityBox.TabIndex = 5;
			this.quantityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.quantityBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 84);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Quantity (1 - 64):";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Select an item:";
			// 
			// namesBox
			// 
			this.namesBox.Location = new System.Drawing.Point(6, 35);
			this.namesBox.Name = "namesBox";
			this.namesBox.Size = new System.Drawing.Size(218, 20);
			this.namesBox.TabIndex = 1;
			this.namesBox.TextChanged += new System.EventHandler(this.NamesBoxTextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Give to who? (separate with \';\')";
			// 
			// mainGroup
			// 
			this.mainGroup.Controls.Add(this.groupBox4);
			this.mainGroup.Controls.Add(this.groupBox3);
			this.mainGroup.Controls.Add(this.groupBox2);
			this.mainGroup.Controls.Add(this.groupBox1);
			this.mainGroup.Location = new System.Drawing.Point(6, 6);
			this.mainGroup.Name = "mainGroup";
			this.mainGroup.Size = new System.Drawing.Size(477, 372);
			this.mainGroup.TabIndex = 3;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.execFileLog);
			this.groupBox4.Controls.Add(this.execFileButton);
			this.groupBox4.Controls.Add(this.execFileLabel);
			this.groupBox4.Controls.Add(this.execFileProgress);
			this.groupBox4.Controls.Add(this.execFileBox);
			this.groupBox4.Controls.Add(this.execFileBrowse);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Location = new System.Drawing.Point(292, 144);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(181, 217);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Execute a File";
			// 
			// execFileLog
			// 
			this.execFileLog.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.execFileLog.Location = new System.Drawing.Point(6, 87);
			this.execFileLog.Multiline = true;
			this.execFileLog.Name = "execFileLog";
			this.execFileLog.ReadOnly = true;
			this.execFileLog.Size = new System.Drawing.Size(169, 85);
			this.execFileLog.TabIndex = 6;
			// 
			// execFileButton
			// 
			this.execFileButton.Location = new System.Drawing.Point(6, 58);
			this.execFileButton.Name = "execFileButton";
			this.execFileButton.Size = new System.Drawing.Size(169, 23);
			this.execFileButton.TabIndex = 5;
			this.execFileButton.Text = "Execute File!";
			this.execFileButton.UseVisualStyleBackColor = true;
			this.execFileButton.Click += new System.EventHandler(this.ExecFileButtonClick);
			// 
			// execFileLabel
			// 
			this.execFileLabel.Location = new System.Drawing.Point(6, 175);
			this.execFileLabel.Name = "execFileLabel";
			this.execFileLabel.Size = new System.Drawing.Size(169, 13);
			this.execFileLabel.TabIndex = 4;
			this.execFileLabel.Text = "Progress...";
			this.execFileLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// execFileProgress
			// 
			this.execFileProgress.Location = new System.Drawing.Point(6, 191);
			this.execFileProgress.Name = "execFileProgress";
			this.execFileProgress.Size = new System.Drawing.Size(169, 20);
			this.execFileProgress.Step = 1;
			this.execFileProgress.TabIndex = 3;
			// 
			// execFileBox
			// 
			this.execFileBox.Location = new System.Drawing.Point(6, 32);
			this.execFileBox.Name = "execFileBox";
			this.execFileBox.ReadOnly = true;
			this.execFileBox.Size = new System.Drawing.Size(104, 20);
			this.execFileBox.TabIndex = 2;
			// 
			// execFileBrowse
			// 
			this.execFileBrowse.Location = new System.Drawing.Point(116, 30);
			this.execFileBrowse.Name = "execFileBrowse";
			this.execFileBrowse.Size = new System.Drawing.Size(59, 23);
			this.execFileBrowse.TabIndex = 1;
			this.execFileBrowse.Text = "Browse...";
			this.execFileBrowse.UseVisualStyleBackColor = true;
			this.execFileBrowse.Click += new System.EventHandler(this.ExecFileBrowseClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "File (*.mcfg)";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.creditCheckBox);
			this.groupBox3.Controls.Add(this.exitButton);
			this.groupBox3.Controls.Add(this.stopMCButton);
			this.groupBox3.Controls.Add(this.startMCButton);
			this.groupBox3.Location = new System.Drawing.Point(3, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(229, 135);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Main";
			// 
			// creditCheckBox
			// 
			this.creditCheckBox.AutoSize = true;
			this.creditCheckBox.Checked = true;
			this.creditCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.creditCheckBox.Location = new System.Drawing.Point(54, 110);
			this.creditCheckBox.Name = "creditCheckBox";
			this.creditCheckBox.Size = new System.Drawing.Size(122, 17);
			this.creditCheckBox.TabIndex = 3;
			this.creditCheckBox.Text = "Show credits in chat";
			this.creditCheckBox.UseVisualStyleBackColor = true;
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(7, 79);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(216, 23);
			this.exitButton.TabIndex = 2;
			this.exitButton.Text = "Exit MSC and stop Server";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// stopMCButton
			// 
			this.stopMCButton.Location = new System.Drawing.Point(7, 50);
			this.stopMCButton.Name = "stopMCButton";
			this.stopMCButton.Size = new System.Drawing.Size(216, 23);
			this.stopMCButton.TabIndex = 1;
			this.stopMCButton.Text = "Stop Minecraft Server";
			this.stopMCButton.UseVisualStyleBackColor = true;
			this.stopMCButton.Click += new System.EventHandler(this.StopMcButtonClick);
			// 
			// startMCButton
			// 
			this.startMCButton.Location = new System.Drawing.Point(7, 20);
			this.startMCButton.Name = "startMCButton";
			this.startMCButton.Size = new System.Drawing.Size(216, 23);
			this.startMCButton.TabIndex = 0;
			this.startMCButton.Text = "Start Minecraft Server";
			this.startMCButton.UseVisualStyleBackColor = true;
			this.startMCButton.Click += new System.EventHandler(this.StartMcButtonClick);
			// 
			// execFileDialog
			// 
			this.execFileDialog.Filter = "MSC Config File (*.mcfg)|*.mcfg";
			// 
			// execFileWorker
			// 
			this.execFileWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ExecFileWorkerDoWork);
			// 
			// MscTabControl
			// 
			this.MscTabControl.Controls.Add(this.mainTab);
			this.MscTabControl.Controls.Add(this.BackupTab);
			this.MscTabControl.Enabled = false;
			this.MscTabControl.Location = new System.Drawing.Point(0, 55);
			this.MscTabControl.Name = "MscTabControl";
			this.MscTabControl.SelectedIndex = 0;
			this.MscTabControl.Size = new System.Drawing.Size(496, 411);
			this.MscTabControl.TabIndex = 4;
			// 
			// mainTab
			// 
			this.mainTab.Controls.Add(this.mainGroup);
			this.mainTab.Location = new System.Drawing.Point(4, 22);
			this.mainTab.Name = "mainTab";
			this.mainTab.Padding = new System.Windows.Forms.Padding(3);
			this.mainTab.Size = new System.Drawing.Size(488, 385);
			this.mainTab.TabIndex = 0;
			this.mainTab.Text = "Main";
			this.mainTab.UseVisualStyleBackColor = true;
			// 
			// BackupTab
			// 
			this.BackupTab.Controls.Add(this.BackupPanel);
			this.BackupTab.Controls.Add(this.WorldBrowseButton);
			this.BackupTab.Controls.Add(this.WorldFolderBox);
			this.BackupTab.Controls.Add(this.label7);
			this.BackupTab.Location = new System.Drawing.Point(4, 22);
			this.BackupTab.Name = "BackupTab";
			this.BackupTab.Padding = new System.Windows.Forms.Padding(3);
			this.BackupTab.Size = new System.Drawing.Size(488, 385);
			this.BackupTab.TabIndex = 1;
			this.BackupTab.Text = "Backup";
			this.BackupTab.UseVisualStyleBackColor = true;
			// 
			// BackupPanel
			// 
			this.BackupPanel.Controls.Add(this.BackupListGroup);
			this.BackupPanel.Controls.Add(this.BackupStatusGroup);
			this.BackupPanel.Enabled = false;
			this.BackupPanel.Location = new System.Drawing.Point(3, 32);
			this.BackupPanel.Name = "BackupPanel";
			this.BackupPanel.Size = new System.Drawing.Size(482, 350);
			this.BackupPanel.TabIndex = 5;
			// 
			// BackupListGroup
			// 
			this.BackupListGroup.Controls.Add(this.ArchBackupBtn);
			this.BackupListGroup.Controls.Add(this.DelBackupBtn);
			this.BackupListGroup.Controls.Add(this.RestoreBackupBtn);
			this.BackupListGroup.Controls.Add(this.BackupListBox);
			this.BackupListGroup.Location = new System.Drawing.Point(3, 3);
			this.BackupListGroup.Name = "BackupListGroup";
			this.BackupListGroup.Size = new System.Drawing.Size(144, 220);
			this.BackupListGroup.TabIndex = 3;
			this.BackupListGroup.TabStop = false;
			this.BackupListGroup.Text = "Backup List";
			// 
			// ArchBackupBtn
			// 
			this.ArchBackupBtn.Location = new System.Drawing.Point(3, 191);
			this.ArchBackupBtn.Name = "ArchBackupBtn";
			this.ArchBackupBtn.Size = new System.Drawing.Size(137, 23);
			this.ArchBackupBtn.TabIndex = 4;
			this.ArchBackupBtn.Text = "Archive Backup";
			this.ArchBackupBtn.UseVisualStyleBackColor = true;
			// 
			// DelBackupBtn
			// 
			this.DelBackupBtn.Location = new System.Drawing.Point(3, 162);
			this.DelBackupBtn.Name = "DelBackupBtn";
			this.DelBackupBtn.Size = new System.Drawing.Size(137, 23);
			this.DelBackupBtn.TabIndex = 4;
			this.DelBackupBtn.Text = "Remove Backup";
			this.DelBackupBtn.UseVisualStyleBackColor = true;
			// 
			// RestoreBackupBtn
			// 
			this.RestoreBackupBtn.Location = new System.Drawing.Point(3, 133);
			this.RestoreBackupBtn.Name = "RestoreBackupBtn";
			this.RestoreBackupBtn.Size = new System.Drawing.Size(137, 23);
			this.RestoreBackupBtn.TabIndex = 4;
			this.RestoreBackupBtn.Text = "Restore Backup";
			this.RestoreBackupBtn.UseVisualStyleBackColor = true;
			// 
			// BackupListBox
			// 
			this.BackupListBox.FormattingEnabled = true;
			this.BackupListBox.Location = new System.Drawing.Point(3, 19);
			this.BackupListBox.Name = "BackupListBox";
			this.BackupListBox.Size = new System.Drawing.Size(137, 108);
			this.BackupListBox.TabIndex = 4;
			// 
			// BackupStatusGroup
			// 
			this.BackupStatusGroup.Controls.Add(this.CurrActionShort);
			this.BackupStatusGroup.Controls.Add(this.CurrActionDesc);
			this.BackupStatusGroup.Controls.Add(this.CurrActLabel);
			this.BackupStatusGroup.Controls.Add(this.BackupProgress);
			this.BackupStatusGroup.Controls.Add(this.BackupLogBox);
			this.BackupStatusGroup.Location = new System.Drawing.Point(3, 223);
			this.BackupStatusGroup.Name = "BackupStatusGroup";
			this.BackupStatusGroup.Size = new System.Drawing.Size(476, 124);
			this.BackupStatusGroup.TabIndex = 4;
			this.BackupStatusGroup.TabStop = false;
			this.BackupStatusGroup.Text = "Status";
			// 
			// CurrActionShort
			// 
			this.CurrActionShort.AutoEllipsis = true;
			this.CurrActionShort.Location = new System.Drawing.Point(259, 84);
			this.CurrActionShort.Name = "CurrActionShort";
			this.CurrActionShort.Size = new System.Drawing.Size(211, 16);
			this.CurrActionShort.TabIndex = 4;
			this.CurrActionShort.Text = "Progress...";
			this.CurrActionShort.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// CurrActionDesc
			// 
			this.CurrActionDesc.AutoEllipsis = true;
			this.CurrActionDesc.Location = new System.Drawing.Point(259, 32);
			this.CurrActionDesc.Name = "CurrActionDesc";
			this.CurrActionDesc.Size = new System.Drawing.Size(212, 52);
			this.CurrActionDesc.TabIndex = 3;
			this.CurrActionDesc.Text = "Waiting...";
			// 
			// CurrActLabel
			// 
			this.CurrActLabel.AutoSize = true;
			this.CurrActLabel.Location = new System.Drawing.Point(259, 16);
			this.CurrActLabel.Name = "CurrActLabel";
			this.CurrActLabel.Size = new System.Drawing.Size(82, 13);
			this.CurrActLabel.TabIndex = 2;
			this.CurrActLabel.Text = "Current action...";
			// 
			// BackupProgress
			// 
			this.BackupProgress.Location = new System.Drawing.Point(259, 103);
			this.BackupProgress.Name = "BackupProgress";
			this.BackupProgress.Size = new System.Drawing.Size(211, 15);
			this.BackupProgress.TabIndex = 1;
			// 
			// BackupLogBox
			// 
			this.BackupLogBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BackupLogBox.Location = new System.Drawing.Point(3, 19);
			this.BackupLogBox.Multiline = true;
			this.BackupLogBox.Name = "BackupLogBox";
			this.BackupLogBox.ReadOnly = true;
			this.BackupLogBox.Size = new System.Drawing.Size(250, 99);
			this.BackupLogBox.TabIndex = 0;
			// 
			// WorldBrowseButton
			// 
			this.WorldBrowseButton.Location = new System.Drawing.Point(410, 4);
			this.WorldBrowseButton.Name = "WorldBrowseButton";
			this.WorldBrowseButton.Size = new System.Drawing.Size(75, 23);
			this.WorldBrowseButton.TabIndex = 2;
			this.WorldBrowseButton.Text = "Browse...";
			this.WorldBrowseButton.UseVisualStyleBackColor = true;
			this.WorldBrowseButton.Click += new System.EventHandler(this.WorldBrowseButtonClick);
			// 
			// WorldFolderBox
			// 
			this.WorldFolderBox.Location = new System.Drawing.Point(116, 6);
			this.WorldFolderBox.Name = "WorldFolderBox";
			this.WorldFolderBox.ReadOnly = true;
			this.WorldFolderBox.Size = new System.Drawing.Size(288, 20);
			this.WorldFolderBox.TabIndex = 1;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(107, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Path to server world: ";
			// 
			// worldFolderDialog
			// 
			this.worldFolderDialog.Description = "Select the world folder.";
			this.worldFolderDialog.SelectedPath = "world";
			this.worldFolderDialog.ShowNewFolderButton = false;
			// 
			// mscMenu
			// 
			this.mscMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMenuItem});
			this.mscMenu.Location = new System.Drawing.Point(0, 0);
			this.mscMenu.Name = "mscMenu";
			this.mscMenu.Size = new System.Drawing.Size(493, 24);
			this.mscMenu.TabIndex = 5;
			this.mscMenu.Text = "menuStrip1";
			// 
			// helpMenuItem
			// 
			this.helpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licenseMenuItem,
            this.aboutMenuItem});
			this.helpMenuItem.Name = "helpMenuItem";
			this.helpMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpMenuItem.Text = "Help";
			// 
			// licenseMenuItem
			// 
			this.licenseMenuItem.Name = "licenseMenuItem";
			this.licenseMenuItem.Size = new System.Drawing.Size(137, 22);
			this.licenseMenuItem.Text = "License Info";
			this.licenseMenuItem.Click += new System.EventHandler(this.LicenseMenuItemClick);
			// 
			// aboutMenuItem
			// 
			this.aboutMenuItem.Name = "aboutMenuItem";
			this.aboutMenuItem.Size = new System.Drawing.Size(137, 22);
			this.aboutMenuItem.Text = "About";
			this.aboutMenuItem.Click += new System.EventHandler(this.AboutMenuItemClick);
			// 
			// MscForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 463);
			this.Controls.Add(this.MscTabControl);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.pathBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mscMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.mscMenu;
			this.MaximizeBox = false;
			this.Name = "MscForm";
			this.Text = "Minecraft Server Commander by F16Gaming";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.secondsBox)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.quantityBox)).EndInit();
			this.mainGroup.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.MscTabControl.ResumeLayout(false);
			this.mainTab.ResumeLayout(false);
			this.BackupTab.ResumeLayout(false);
			this.BackupTab.PerformLayout();
			this.BackupPanel.ResumeLayout(false);
			this.BackupListGroup.ResumeLayout(false);
			this.BackupStatusGroup.ResumeLayout(false);
			this.BackupStatusGroup.PerformLayout();
			this.mscMenu.ResumeLayout(false);
			this.mscMenu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox pathBox;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.OpenFileDialog MinecraftSFileDialog;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button clearListButton;
		private System.Windows.Forms.Button removeCmdButton;
		private System.Windows.Forms.Button addCmdButton;
		private System.Windows.Forms.TextBox commandBox;
		private System.Windows.Forms.Button stopACSButton;
		private System.Windows.Forms.Button startACSButton;
		private System.Windows.Forms.ListBox commandList;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button giveButton;
		private System.Windows.Forms.NumericUpDown quantityBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox namesBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown secondsBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel mainGroup;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.CheckBox creditCheckBox;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button stopMCButton;
		private System.Windows.Forms.Button startMCButton;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox execFileLog;
		private System.Windows.Forms.Button execFileButton;
		private System.Windows.Forms.Label execFileLabel;
		private System.Windows.Forms.ProgressBar execFileProgress;
		private System.Windows.Forms.TextBox execFileBox;
		private System.Windows.Forms.Button execFileBrowse;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.OpenFileDialog execFileDialog;
		private System.ComponentModel.BackgroundWorker execFileWorker;
		private System.Windows.Forms.ComboBox itemBox;
		private System.Windows.Forms.TabControl MscTabControl;
		private System.Windows.Forms.TabPage mainTab;
		private System.Windows.Forms.TabPage BackupTab;
		private System.Windows.Forms.GroupBox BackupStatusGroup;
		private System.Windows.Forms.Label CurrActLabel;
		private System.Windows.Forms.ProgressBar BackupProgress;
		private System.Windows.Forms.TextBox BackupLogBox;
		private System.Windows.Forms.GroupBox BackupListGroup;
		private System.Windows.Forms.Button ArchBackupBtn;
		private System.Windows.Forms.Button DelBackupBtn;
		private System.Windows.Forms.Button RestoreBackupBtn;
		private System.Windows.Forms.ListBox BackupListBox;
		private System.Windows.Forms.Button WorldBrowseButton;
		private System.Windows.Forms.TextBox WorldFolderBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.FolderBrowserDialog worldFolderDialog;
		private System.Windows.Forms.Panel BackupPanel;
		private System.Windows.Forms.Label CurrActionShort;
		private System.Windows.Forms.Label CurrActionDesc;
		private System.ComponentModel.BackgroundWorker backupWorker;
		private System.Windows.Forms.MenuStrip mscMenu;
		private System.Windows.Forms.ToolStripMenuItem helpMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
		private System.Windows.Forms.ToolStripMenuItem licenseMenuItem;
	}
}

