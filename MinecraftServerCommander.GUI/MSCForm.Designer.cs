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
			this.backupTab = new System.Windows.Forms.TabPage();
			this.backupPanel = new System.Windows.Forms.Panel();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.backupListBox = new System.Windows.Forms.ListBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.WorldBrowseButton = new System.Windows.Forms.Button();
			this.WorldFolderBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.worldFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.secondsBox)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.quantityBox)).BeginInit();
			this.mainGroup.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.MscTabControl.SuspendLayout();
			this.mainTab.SuspendLayout();
			this.backupTab.SuspendLayout();
			this.backupPanel.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Minecraft Server exe location:";
			// 
			// pathBox
			// 
			this.pathBox.Location = new System.Drawing.Point(166, 6);
			this.pathBox.Name = "pathBox";
			this.pathBox.ReadOnly = true;
			this.pathBox.Size = new System.Drawing.Size(242, 20);
			this.pathBox.TabIndex = 1;
			// 
			// browseButton
			// 
			this.browseButton.Location = new System.Drawing.Point(414, 4);
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
			this.MscTabControl.Controls.Add(this.backupTab);
			this.MscTabControl.Enabled = false;
			this.MscTabControl.Location = new System.Drawing.Point(0, 28);
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
			// backupTab
			// 
			this.backupTab.Controls.Add(this.backupPanel);
			this.backupTab.Controls.Add(this.WorldBrowseButton);
			this.backupTab.Controls.Add(this.WorldFolderBox);
			this.backupTab.Controls.Add(this.label7);
			this.backupTab.Location = new System.Drawing.Point(4, 22);
			this.backupTab.Name = "backupTab";
			this.backupTab.Padding = new System.Windows.Forms.Padding(3);
			this.backupTab.Size = new System.Drawing.Size(488, 385);
			this.backupTab.TabIndex = 1;
			this.backupTab.Text = "Backup";
			this.backupTab.UseVisualStyleBackColor = true;
			// 
			// backupPanel
			// 
			this.backupPanel.Controls.Add(this.groupBox5);
			this.backupPanel.Controls.Add(this.groupBox6);
			this.backupPanel.Enabled = false;
			this.backupPanel.Location = new System.Drawing.Point(3, 32);
			this.backupPanel.Name = "backupPanel";
			this.backupPanel.Size = new System.Drawing.Size(482, 350);
			this.backupPanel.TabIndex = 5;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.button4);
			this.groupBox5.Controls.Add(this.button3);
			this.groupBox5.Controls.Add(this.button2);
			this.groupBox5.Controls.Add(this.backupListBox);
			this.groupBox5.Location = new System.Drawing.Point(3, 3);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(144, 220);
			this.groupBox5.TabIndex = 3;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Backup List";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(3, 191);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(137, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "Archive Backup";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(3, 162);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(137, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Remove Backup";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(3, 133);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(137, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Restore Backup";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// backupListBox
			// 
			this.backupListBox.FormattingEnabled = true;
			this.backupListBox.Location = new System.Drawing.Point(3, 19);
			this.backupListBox.Name = "backupListBox";
			this.backupListBox.Size = new System.Drawing.Size(137, 108);
			this.backupListBox.TabIndex = 4;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.label8);
			this.groupBox6.Controls.Add(this.progressBar1);
			this.groupBox6.Controls.Add(this.textBox2);
			this.groupBox6.Location = new System.Drawing.Point(3, 223);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(476, 124);
			this.groupBox6.TabIndex = 4;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Status";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(259, 16);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(82, 13);
			this.label8.TabIndex = 2;
			this.label8.Text = "Current action...";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(259, 103);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(211, 15);
			this.progressBar1.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(3, 19);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(250, 99);
			this.textBox2.TabIndex = 0;
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
			// MscForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 438);
			this.Controls.Add(this.MscTabControl);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.pathBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.HelpButton = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MscForm";
			this.Text = "Minecraft Server Commander by F16Gaming";
			this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.MscFormHelpButtonClicked);
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
			this.backupTab.ResumeLayout(false);
			this.backupTab.PerformLayout();
			this.backupPanel.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
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
		private System.Windows.Forms.TabPage backupTab;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListBox backupListBox;
		private System.Windows.Forms.Button WorldBrowseButton;
		private System.Windows.Forms.TextBox WorldFolderBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.FolderBrowserDialog worldFolderDialog;
		private System.Windows.Forms.Panel backupPanel;
	}
}

