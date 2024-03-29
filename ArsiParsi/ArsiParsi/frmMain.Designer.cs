﻿namespace ArsiParsi
{
  partial class frmMain
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
      this.contextTray = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.grpReceiver = new System.Windows.Forms.GroupBox();
      this.chkTestMode = new System.Windows.Forms.CheckBox();
      this.btnReceiverConnectToggle = new System.Windows.Forms.Button();
      this.cmbReceiverPort = new System.Windows.Forms.ComboBox();
      this.lblPort = new System.Windows.Forms.Label();
      this.txtLog = new System.Windows.Forms.RichTextBox();
      this.dataActions = new System.Windows.Forms.DataGridView();
      this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colActionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colActionObject = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pnlActionControls = new System.Windows.Forms.Panel();
      this.btnDeleteAction = new System.Windows.Forms.Button();
      this.btnEditAction = new System.Windows.Forms.Button();
      this.btnNewAction = new System.Windows.Forms.Button();
      this.btnNewActionFromMessage = new System.Windows.Forms.Button();
      this.lblMessageError = new System.Windows.Forms.Label();
      this.txtRepeatGap = new System.Windows.Forms.TextBox();
      this.lblRepeatGap = new System.Windows.Forms.Label();
      this.txtToggle = new System.Windows.Forms.TextBox();
      this.lblToggle = new System.Windows.Forms.Label();
      this.txtCommand = new System.Windows.Forms.TextBox();
      this.lblCommand = new System.Windows.Forms.Label();
      this.txtAddress = new System.Windows.Forms.TextBox();
      this.lblAddress = new System.Windows.Forms.Label();
      this.txtProtocol = new System.Windows.Forms.TextBox();
      this.lblProtocol = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.grpLastMessage = new System.Windows.Forms.GroupBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.grpLog = new System.Windows.Forms.GroupBox();
      this.panel3 = new System.Windows.Forms.Panel();
      this.chkSplashOnStartup = new System.Windows.Forms.CheckBox();
      this.btnClearLog = new System.Windows.Forms.Button();
      this.chkLogRawData = new System.Windows.Forms.CheckBox();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.grpActions = new System.Windows.Forms.GroupBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.contextTray.SuspendLayout();
      this.grpReceiver.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataActions)).BeginInit();
      this.pnlActionControls.SuspendLayout();
      this.panel1.SuspendLayout();
      this.grpLastMessage.SuspendLayout();
      this.panel2.SuspendLayout();
      this.grpLog.SuspendLayout();
      this.panel3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      this.grpActions.SuspendLayout();
      this.SuspendLayout();
      // 
      // trayIcon
      // 
      this.trayIcon.ContextMenuStrip = this.contextTray;
      this.trayIcon.Text = "ArsiParsi";
      this.trayIcon.Visible = true;
      this.trayIcon.DoubleClick += new System.EventHandler(this.trayIcon_DoubleClick);
      // 
      // contextTray
      // 
      this.contextTray.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.contextTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.contextTray.Name = "contextTray";
      this.contextTray.Size = new System.Drawing.Size(112, 36);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 32);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // grpReceiver
      // 
      this.grpReceiver.Controls.Add(this.chkTestMode);
      this.grpReceiver.Controls.Add(this.btnReceiverConnectToggle);
      this.grpReceiver.Controls.Add(this.cmbReceiverPort);
      this.grpReceiver.Controls.Add(this.lblPort);
      this.grpReceiver.Dock = System.Windows.Forms.DockStyle.Top;
      this.grpReceiver.Location = new System.Drawing.Point(0, 0);
      this.grpReceiver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpReceiver.Name = "grpReceiver";
      this.grpReceiver.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpReceiver.Size = new System.Drawing.Size(457, 120);
      this.grpReceiver.TabIndex = 1;
      this.grpReceiver.TabStop = false;
      this.grpReceiver.Text = "Connection";
      // 
      // chkTestMode
      // 
      this.chkTestMode.AutoSize = true;
      this.chkTestMode.Location = new System.Drawing.Point(69, 80);
      this.chkTestMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkTestMode.Name = "chkTestMode";
      this.chkTestMode.Size = new System.Drawing.Size(120, 29);
      this.chkTestMode.TabIndex = 4;
      this.chkTestMode.Text = "Test mode";
      this.chkTestMode.UseVisualStyleBackColor = true;
      // 
      // btnReceiverConnectToggle
      // 
      this.btnReceiverConnectToggle.Location = new System.Drawing.Point(217, 33);
      this.btnReceiverConnectToggle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnReceiverConnectToggle.Name = "btnReceiverConnectToggle";
      this.btnReceiverConnectToggle.Size = new System.Drawing.Size(126, 42);
      this.btnReceiverConnectToggle.TabIndex = 2;
      this.btnReceiverConnectToggle.Text = "Connect";
      this.btnReceiverConnectToggle.UseVisualStyleBackColor = true;
      this.btnReceiverConnectToggle.Click += new System.EventHandler(this.btnReceiverConnectToggle_Click);
      // 
      // cmbReceiverPort
      // 
      this.cmbReceiverPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbReceiverPort.FormattingEnabled = true;
      this.cmbReceiverPort.Location = new System.Drawing.Point(69, 35);
      this.cmbReceiverPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cmbReceiverPort.Name = "cmbReceiverPort";
      this.cmbReceiverPort.Size = new System.Drawing.Size(135, 33);
      this.cmbReceiverPort.TabIndex = 1;
      this.cmbReceiverPort.DropDown += new System.EventHandler(this.cmbReceiverPort_DropDown);
      // 
      // lblPort
      // 
      this.lblPort.AutoSize = true;
      this.lblPort.Location = new System.Drawing.Point(11, 35);
      this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblPort.Name = "lblPort";
      this.lblPort.Size = new System.Drawing.Size(44, 25);
      this.lblPort.TabIndex = 0;
      this.lblPort.Text = "Port";
      // 
      // txtLog
      // 
      this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtLog.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.txtLog.Location = new System.Drawing.Point(4, 71);
      this.txtLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtLog.Name = "txtLog";
      this.txtLog.ReadOnly = true;
      this.txtLog.Size = new System.Drawing.Size(1266, 314);
      this.txtLog.TabIndex = 0;
      this.txtLog.Text = "";
      this.txtLog.WordWrap = false;
      // 
      // dataActions
      // 
      this.dataActions.AllowUserToAddRows = false;
      this.dataActions.AllowUserToDeleteRows = false;
      this.dataActions.AllowUserToResizeRows = false;
      this.dataActions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataActions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colProtocol,
            this.colAddress,
            this.colCommand,
            this.colActionType,
            this.colActionObject});
      this.dataActions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataActions.Location = new System.Drawing.Point(4, 77);
      this.dataActions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.dataActions.MultiSelect = false;
      this.dataActions.Name = "dataActions";
      this.dataActions.ReadOnly = true;
      this.dataActions.RowHeadersVisible = false;
      this.dataActions.RowHeadersWidth = 62;
      this.dataActions.RowTemplate.Height = 25;
      this.dataActions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataActions.ShowEditingIcon = false;
      this.dataActions.Size = new System.Drawing.Size(809, 568);
      this.dataActions.TabIndex = 0;
      this.dataActions.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataActions_CellDoubleClick);
      this.dataActions.SelectionChanged += new System.EventHandler(this.dataActions_SelectionChanged);
      this.dataActions.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataActions_KeyUp);
      // 
      // colName
      // 
      this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
      this.colName.DataPropertyName = "Name";
      this.colName.HeaderText = "Name";
      this.colName.MinimumWidth = 100;
      this.colName.Name = "colName";
      this.colName.ReadOnly = true;
      this.colName.Width = 150;
      // 
      // colProtocol
      // 
      this.colProtocol.DataPropertyName = "Protocol";
      this.colProtocol.HeaderText = "Protocol";
      this.colProtocol.MinimumWidth = 60;
      this.colProtocol.Name = "colProtocol";
      this.colProtocol.ReadOnly = true;
      // 
      // colAddress
      // 
      this.colAddress.DataPropertyName = "Address";
      this.colAddress.FillWeight = 66.14645F;
      this.colAddress.HeaderText = "Address";
      this.colAddress.MinimumWidth = 60;
      this.colAddress.Name = "colAddress";
      this.colAddress.ReadOnly = true;
      // 
      // colCommand
      // 
      this.colCommand.DataPropertyName = "Command";
      this.colCommand.FillWeight = 66.14645F;
      this.colCommand.HeaderText = "Command";
      this.colCommand.MinimumWidth = 70;
      this.colCommand.Name = "colCommand";
      this.colCommand.ReadOnly = true;
      // 
      // colActionType
      // 
      this.colActionType.DataPropertyName = "Type";
      this.colActionType.FillWeight = 99.21969F;
      this.colActionType.HeaderText = "Type";
      this.colActionType.MinimumWidth = 120;
      this.colActionType.Name = "colActionType";
      this.colActionType.ReadOnly = true;
      // 
      // colActionObject
      // 
      this.colActionObject.DataPropertyName = "ActionObject";
      this.colActionObject.HeaderText = "ActionObject";
      this.colActionObject.MinimumWidth = 8;
      this.colActionObject.Name = "colActionObject";
      this.colActionObject.ReadOnly = true;
      this.colActionObject.Visible = false;
      // 
      // pnlActionControls
      // 
      this.pnlActionControls.Controls.Add(this.btnDeleteAction);
      this.pnlActionControls.Controls.Add(this.btnEditAction);
      this.pnlActionControls.Controls.Add(this.btnNewAction);
      this.pnlActionControls.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlActionControls.Location = new System.Drawing.Point(4, 29);
      this.pnlActionControls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.pnlActionControls.Name = "pnlActionControls";
      this.pnlActionControls.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
      this.pnlActionControls.Size = new System.Drawing.Size(809, 48);
      this.pnlActionControls.TabIndex = 1;
      // 
      // btnDeleteAction
      // 
      this.btnDeleteAction.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnDeleteAction.Enabled = false;
      this.btnDeleteAction.Location = new System.Drawing.Point(206, 3);
      this.btnDeleteAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnDeleteAction.Name = "btnDeleteAction";
      this.btnDeleteAction.Size = new System.Drawing.Size(103, 42);
      this.btnDeleteAction.TabIndex = 2;
      this.btnDeleteAction.Text = "Delete";
      this.btnDeleteAction.UseVisualStyleBackColor = true;
      this.btnDeleteAction.Click += new System.EventHandler(this.btnDeleteAction_Click);
      // 
      // btnEditAction
      // 
      this.btnEditAction.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnEditAction.Enabled = false;
      this.btnEditAction.Location = new System.Drawing.Point(103, 3);
      this.btnEditAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnEditAction.Name = "btnEditAction";
      this.btnEditAction.Size = new System.Drawing.Size(103, 42);
      this.btnEditAction.TabIndex = 1;
      this.btnEditAction.Text = "Edit";
      this.btnEditAction.UseVisualStyleBackColor = true;
      this.btnEditAction.Click += new System.EventHandler(this.btnEditAction_Click);
      // 
      // btnNewAction
      // 
      this.btnNewAction.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnNewAction.Location = new System.Drawing.Point(0, 3);
      this.btnNewAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnNewAction.Name = "btnNewAction";
      this.btnNewAction.Size = new System.Drawing.Size(103, 42);
      this.btnNewAction.TabIndex = 0;
      this.btnNewAction.Text = "New";
      this.btnNewAction.UseVisualStyleBackColor = true;
      this.btnNewAction.Click += new System.EventHandler(this.btnNewAction_Click);
      // 
      // btnNewActionFromMessage
      // 
      this.btnNewActionFromMessage.Enabled = false;
      this.btnNewActionFromMessage.Location = new System.Drawing.Point(126, 227);
      this.btnNewActionFromMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnNewActionFromMessage.Name = "btnNewActionFromMessage";
      this.btnNewActionFromMessage.Size = new System.Drawing.Size(309, 40);
      this.btnNewActionFromMessage.TabIndex = 13;
      this.btnNewActionFromMessage.Text = "Define new action";
      this.btnNewActionFromMessage.UseVisualStyleBackColor = true;
      this.btnNewActionFromMessage.Click += new System.EventHandler(this.btnNewActionFromMessage_Click);
      // 
      // lblMessageError
      // 
      this.lblMessageError.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblMessageError.ForeColor = System.Drawing.Color.Red;
      this.lblMessageError.Location = new System.Drawing.Point(4, 304);
      this.lblMessageError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblMessageError.Name = "lblMessageError";
      this.lblMessageError.Size = new System.Drawing.Size(449, 221);
      this.lblMessageError.TabIndex = 12;
      this.lblMessageError.Text = "Error";
      this.lblMessageError.Visible = false;
      // 
      // txtRepeatGap
      // 
      this.txtRepeatGap.Location = new System.Drawing.Point(126, 133);
      this.txtRepeatGap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtRepeatGap.Name = "txtRepeatGap";
      this.txtRepeatGap.ReadOnly = true;
      this.txtRepeatGap.Size = new System.Drawing.Size(307, 31);
      this.txtRepeatGap.TabIndex = 9;
      // 
      // lblRepeatGap
      // 
      this.lblRepeatGap.AutoSize = true;
      this.lblRepeatGap.Location = new System.Drawing.Point(11, 133);
      this.lblRepeatGap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblRepeatGap.Name = "lblRepeatGap";
      this.lblRepeatGap.Size = new System.Drawing.Size(102, 25);
      this.lblRepeatGap.TabIndex = 8;
      this.lblRepeatGap.Text = "Repeat gap";
      // 
      // txtToggle
      // 
      this.txtToggle.Location = new System.Drawing.Point(126, 173);
      this.txtToggle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtToggle.Name = "txtToggle";
      this.txtToggle.ReadOnly = true;
      this.txtToggle.Size = new System.Drawing.Size(307, 31);
      this.txtToggle.TabIndex = 7;
      // 
      // lblToggle
      // 
      this.lblToggle.AutoSize = true;
      this.lblToggle.Location = new System.Drawing.Point(11, 173);
      this.lblToggle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblToggle.Name = "lblToggle";
      this.lblToggle.Size = new System.Drawing.Size(65, 25);
      this.lblToggle.TabIndex = 6;
      this.lblToggle.Text = "Toggle";
      // 
      // txtCommand
      // 
      this.txtCommand.Location = new System.Drawing.Point(126, 93);
      this.txtCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtCommand.Name = "txtCommand";
      this.txtCommand.ReadOnly = true;
      this.txtCommand.Size = new System.Drawing.Size(307, 31);
      this.txtCommand.TabIndex = 5;
      // 
      // lblCommand
      // 
      this.lblCommand.AutoSize = true;
      this.lblCommand.Location = new System.Drawing.Point(11, 93);
      this.lblCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblCommand.Name = "lblCommand";
      this.lblCommand.Size = new System.Drawing.Size(96, 25);
      this.lblCommand.TabIndex = 4;
      this.lblCommand.Text = "Command";
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(126, 53);
      this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.ReadOnly = true;
      this.txtAddress.Size = new System.Drawing.Size(307, 31);
      this.txtAddress.TabIndex = 3;
      // 
      // lblAddress
      // 
      this.lblAddress.AutoSize = true;
      this.lblAddress.Location = new System.Drawing.Point(11, 53);
      this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblAddress.Name = "lblAddress";
      this.lblAddress.Size = new System.Drawing.Size(77, 25);
      this.lblAddress.TabIndex = 2;
      this.lblAddress.Text = "Address";
      // 
      // txtProtocol
      // 
      this.txtProtocol.Location = new System.Drawing.Point(126, 13);
      this.txtProtocol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtProtocol.Name = "txtProtocol";
      this.txtProtocol.ReadOnly = true;
      this.txtProtocol.Size = new System.Drawing.Size(307, 31);
      this.txtProtocol.TabIndex = 1;
      // 
      // lblProtocol
      // 
      this.lblProtocol.AutoSize = true;
      this.lblProtocol.Location = new System.Drawing.Point(11, 13);
      this.lblProtocol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblProtocol.Name = "lblProtocol";
      this.lblProtocol.Size = new System.Drawing.Size(79, 25);
      this.lblProtocol.TabIndex = 0;
      this.lblProtocol.Text = "Protocol";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.grpLastMessage);
      this.panel1.Controls.Add(this.grpReceiver);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(457, 650);
      this.panel1.TabIndex = 3;
      // 
      // grpLastMessage
      // 
      this.grpLastMessage.Controls.Add(this.lblMessageError);
      this.grpLastMessage.Controls.Add(this.panel2);
      this.grpLastMessage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpLastMessage.Location = new System.Drawing.Point(0, 120);
      this.grpLastMessage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpLastMessage.Name = "grpLastMessage";
      this.grpLastMessage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpLastMessage.Size = new System.Drawing.Size(457, 530);
      this.grpLastMessage.TabIndex = 4;
      this.grpLastMessage.TabStop = false;
      this.grpLastMessage.Text = "Last message";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.lblProtocol);
      this.panel2.Controls.Add(this.lblRepeatGap);
      this.panel2.Controls.Add(this.txtRepeatGap);
      this.panel2.Controls.Add(this.btnNewActionFromMessage);
      this.panel2.Controls.Add(this.lblToggle);
      this.panel2.Controls.Add(this.txtProtocol);
      this.panel2.Controls.Add(this.txtToggle);
      this.panel2.Controls.Add(this.lblCommand);
      this.panel2.Controls.Add(this.txtCommand);
      this.panel2.Controls.Add(this.txtAddress);
      this.panel2.Controls.Add(this.lblAddress);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel2.Location = new System.Drawing.Point(4, 29);
      this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(449, 275);
      this.panel2.TabIndex = 16;
      // 
      // grpLog
      // 
      this.grpLog.Controls.Add(this.txtLog);
      this.grpLog.Controls.Add(this.panel3);
      this.grpLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpLog.Location = new System.Drawing.Point(0, 0);
      this.grpLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpLog.Name = "grpLog";
      this.grpLog.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpLog.Size = new System.Drawing.Size(1274, 390);
      this.grpLog.TabIndex = 5;
      this.grpLog.TabStop = false;
      this.grpLog.Text = "Log";
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.chkSplashOnStartup);
      this.panel3.Controls.Add(this.btnClearLog);
      this.panel3.Controls.Add(this.chkLogRawData);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel3.Location = new System.Drawing.Point(4, 29);
      this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(1266, 42);
      this.panel3.TabIndex = 1;
      // 
      // chkSplashOnStartup
      // 
      this.chkSplashOnStartup.AutoSize = true;
      this.chkSplashOnStartup.Checked = true;
      this.chkSplashOnStartup.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkSplashOnStartup.Location = new System.Drawing.Point(1120, 8);
      this.chkSplashOnStartup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkSplashOnStartup.Name = "chkSplashOnStartup";
      this.chkSplashOnStartup.Size = new System.Drawing.Size(137, 29);
      this.chkSplashOnStartup.TabIndex = 7;
      this.chkSplashOnStartup.Text = "Show splash";
      this.chkSplashOnStartup.UseVisualStyleBackColor = true;
      this.chkSplashOnStartup.CheckedChanged += new System.EventHandler(this.chkSplashOnStartup_CheckedChanged);
      // 
      // btnClearLog
      // 
      this.btnClearLog.Location = new System.Drawing.Point(0, 0);
      this.btnClearLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnClearLog.Name = "btnClearLog";
      this.btnClearLog.Size = new System.Drawing.Size(126, 40);
      this.btnClearLog.TabIndex = 6;
      this.btnClearLog.Text = "Clear log";
      this.btnClearLog.UseVisualStyleBackColor = true;
      this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
      // 
      // chkLogRawData
      // 
      this.chkLogRawData.AutoSize = true;
      this.chkLogRawData.Location = new System.Drawing.Point(147, 7);
      this.chkLogRawData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkLogRawData.Name = "chkLogRawData";
      this.chkLogRawData.Size = new System.Drawing.Size(141, 29);
      this.chkLogRawData.TabIndex = 5;
      this.chkLogRawData.Text = "Log raw data";
      this.chkLogRawData.UseVisualStyleBackColor = true;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.splitContainer1.Name = "splitContainer1";
      this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.grpActions);
      this.splitContainer1.Panel1.Controls.Add(this.panel1);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.grpLog);
      this.splitContainer1.Size = new System.Drawing.Size(1274, 1047);
      this.splitContainer1.SplitterDistance = 650;
      this.splitContainer1.SplitterWidth = 7;
      this.splitContainer1.TabIndex = 7;
      // 
      // grpActions
      // 
      this.grpActions.Controls.Add(this.dataActions);
      this.grpActions.Controls.Add(this.pnlActionControls);
      this.grpActions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpActions.Location = new System.Drawing.Point(457, 0);
      this.grpActions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpActions.Name = "grpActions";
      this.grpActions.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpActions.Size = new System.Drawing.Size(817, 650);
      this.grpActions.TabIndex = 7;
      this.grpActions.TabStop = false;
      this.grpActions.Text = "Actions";
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1274, 1047);
      this.Controls.Add(this.splitContainer1);
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MinimizeBox = false;
      this.Name = "frmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ArsiParsi";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.contextTray.ResumeLayout(false);
      this.grpReceiver.ResumeLayout(false);
      this.grpReceiver.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataActions)).EndInit();
      this.pnlActionControls.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.grpLastMessage.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.grpLog.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      this.grpActions.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private NotifyIcon trayIcon;
    private ContextMenuStrip contextTray;
    private ToolStripMenuItem exitToolStripMenuItem;
    private GroupBox grpReceiver;
    private Button btnReceiverConnectToggle;
    private ComboBox cmbReceiverPort;
    private Label lblPort;
    private RichTextBox txtLog;
    private Panel panel1;
    private TextBox txtRepeatGap;
    private Label lblRepeatGap;
    private TextBox txtToggle;
    private Label lblToggle;
    private TextBox txtCommand;
    private Label lblCommand;
    private TextBox txtAddress;
    private Label lblAddress;
    private TextBox txtProtocol;
    private Label lblProtocol;
    private Label lblMessageError;
    private Button btnNewActionFromMessage;
    private DataGridView dataActions;
    private Panel pnlActionControls;
    private Button btnDeleteAction;
    private Button btnEditAction;
    private Button btnNewAction;
    private CheckBox chkTestMode;
    private GroupBox grpLastMessage;
    private Panel panel2;
    private GroupBox grpLog;
    private Panel panel3;
    private Button btnClearLog;
    private CheckBox chkLogRawData;
    private SplitContainer splitContainer1;
    private GroupBox grpActions;
    private DataGridViewTextBoxColumn colName;
    private DataGridViewTextBoxColumn colProtocol;
    private DataGridViewTextBoxColumn colAddress;
    private DataGridViewTextBoxColumn colCommand;
    private DataGridViewTextBoxColumn colActionType;
    private DataGridViewTextBoxColumn colActionObject;
        private ToolTip toolTip1;
        private CheckBox chkSplashOnStartup;
    }
}