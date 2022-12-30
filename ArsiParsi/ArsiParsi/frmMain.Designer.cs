namespace ArsiParsi
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
      this.btnReceiverConnectToggle = new System.Windows.Forms.Button();
      this.cmbReceiverPort = new System.Windows.Forms.ComboBox();
      this.lblPort = new System.Windows.Forms.Label();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPageLastMessage = new System.Windows.Forms.TabPage();
      this.txtMessageActions = new System.Windows.Forms.RichTextBox();
      this.lblExecutedActions = new System.Windows.Forms.Label();
      this.btnNewActionFromMessage = new System.Windows.Forms.Button();
      this.lblMessageError = new System.Windows.Forms.Label();
      this.txtRawData = new System.Windows.Forms.TextBox();
      this.lblRawData = new System.Windows.Forms.Label();
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
      this.tabPageRawData = new System.Windows.Forms.TabPage();
      this.txtRawDataLog = new System.Windows.Forms.RichTextBox();
      this.tabPageActions = new System.Windows.Forms.TabPage();
      this.dataActions = new System.Windows.Forms.DataGridView();
      this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colActionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colActionParameters = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colToggle = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.colRepeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pnlActionControls = new System.Windows.Forms.Panel();
      this.btnDeleteAction = new System.Windows.Forms.Button();
      this.btnEditAction = new System.Windows.Forms.Button();
      this.btnNewAction = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.chkTestMode = new System.Windows.Forms.CheckBox();
      this.contextTray.SuspendLayout();
      this.grpReceiver.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPageLastMessage.SuspendLayout();
      this.tabPageRawData.SuspendLayout();
      this.tabPageActions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataActions)).BeginInit();
      this.pnlActionControls.SuspendLayout();
      this.panel1.SuspendLayout();
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
      this.contextTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.contextTray.Name = "contextTray";
      this.contextTray.Size = new System.Drawing.Size(94, 26);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // grpReceiver
      // 
      this.grpReceiver.Controls.Add(this.btnReceiverConnectToggle);
      this.grpReceiver.Controls.Add(this.cmbReceiverPort);
      this.grpReceiver.Controls.Add(this.lblPort);
      this.grpReceiver.Dock = System.Windows.Forms.DockStyle.Left;
      this.grpReceiver.Location = new System.Drawing.Point(0, 0);
      this.grpReceiver.Name = "grpReceiver";
      this.grpReceiver.Size = new System.Drawing.Size(248, 48);
      this.grpReceiver.TabIndex = 1;
      this.grpReceiver.TabStop = false;
      // 
      // btnReceiverConnectToggle
      // 
      this.btnReceiverConnectToggle.Location = new System.Drawing.Point(152, 16);
      this.btnReceiverConnectToggle.Name = "btnReceiverConnectToggle";
      this.btnReceiverConnectToggle.Size = new System.Drawing.Size(88, 24);
      this.btnReceiverConnectToggle.TabIndex = 2;
      this.btnReceiverConnectToggle.Text = "Connect";
      this.btnReceiverConnectToggle.UseVisualStyleBackColor = true;
      this.btnReceiverConnectToggle.Click += new System.EventHandler(this.btnReceiverConnectToggle_Click);
      // 
      // cmbReceiverPort
      // 
      this.cmbReceiverPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbReceiverPort.FormattingEnabled = true;
      this.cmbReceiverPort.Location = new System.Drawing.Point(48, 16);
      this.cmbReceiverPort.Name = "cmbReceiverPort";
      this.cmbReceiverPort.Size = new System.Drawing.Size(96, 23);
      this.cmbReceiverPort.TabIndex = 1;
      this.cmbReceiverPort.DropDown += new System.EventHandler(this.cmbReceiverPort_DropDown);
      // 
      // lblPort
      // 
      this.lblPort.AutoSize = true;
      this.lblPort.Location = new System.Drawing.Point(8, 16);
      this.lblPort.Name = "lblPort";
      this.lblPort.Size = new System.Drawing.Size(29, 15);
      this.lblPort.TabIndex = 0;
      this.lblPort.Text = "Port";
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPageLastMessage);
      this.tabControl1.Controls.Add(this.tabPageRawData);
      this.tabControl1.Controls.Add(this.tabPageActions);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 48);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(530, 456);
      this.tabControl1.TabIndex = 2;
      // 
      // tabPageLastMessage
      // 
      this.tabPageLastMessage.BackColor = System.Drawing.SystemColors.Control;
      this.tabPageLastMessage.Controls.Add(this.txtMessageActions);
      this.tabPageLastMessage.Controls.Add(this.lblExecutedActions);
      this.tabPageLastMessage.Controls.Add(this.btnNewActionFromMessage);
      this.tabPageLastMessage.Controls.Add(this.lblMessageError);
      this.tabPageLastMessage.Controls.Add(this.txtRawData);
      this.tabPageLastMessage.Controls.Add(this.lblRawData);
      this.tabPageLastMessage.Controls.Add(this.txtRepeatGap);
      this.tabPageLastMessage.Controls.Add(this.lblRepeatGap);
      this.tabPageLastMessage.Controls.Add(this.txtToggle);
      this.tabPageLastMessage.Controls.Add(this.lblToggle);
      this.tabPageLastMessage.Controls.Add(this.txtCommand);
      this.tabPageLastMessage.Controls.Add(this.lblCommand);
      this.tabPageLastMessage.Controls.Add(this.txtAddress);
      this.tabPageLastMessage.Controls.Add(this.lblAddress);
      this.tabPageLastMessage.Controls.Add(this.txtProtocol);
      this.tabPageLastMessage.Controls.Add(this.lblProtocol);
      this.tabPageLastMessage.Location = new System.Drawing.Point(4, 24);
      this.tabPageLastMessage.Name = "tabPageLastMessage";
      this.tabPageLastMessage.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageLastMessage.Size = new System.Drawing.Size(522, 428);
      this.tabPageLastMessage.TabIndex = 1;
      this.tabPageLastMessage.Text = "Last message";
      // 
      // txtMessageActions
      // 
      this.txtMessageActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtMessageActions.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.txtMessageActions.Location = new System.Drawing.Point(88, 104);
      this.txtMessageActions.Name = "txtMessageActions";
      this.txtMessageActions.ReadOnly = true;
      this.txtMessageActions.Size = new System.Drawing.Size(392, 112);
      this.txtMessageActions.TabIndex = 15;
      this.txtMessageActions.Text = "";
      this.txtMessageActions.WordWrap = false;
      // 
      // lblExecutedActions
      // 
      this.lblExecutedActions.AutoSize = true;
      this.lblExecutedActions.Location = new System.Drawing.Point(8, 104);
      this.lblExecutedActions.Name = "lblExecutedActions";
      this.lblExecutedActions.Size = new System.Drawing.Size(47, 15);
      this.lblExecutedActions.TabIndex = 14;
      this.lblExecutedActions.Text = "Actions";
      // 
      // btnNewActionFromMessage
      // 
      this.btnNewActionFromMessage.Enabled = false;
      this.btnNewActionFromMessage.Location = new System.Drawing.Point(256, 8);
      this.btnNewActionFromMessage.Name = "btnNewActionFromMessage";
      this.btnNewActionFromMessage.Size = new System.Drawing.Size(120, 24);
      this.btnNewActionFromMessage.TabIndex = 13;
      this.btnNewActionFromMessage.Text = "Define new action";
      this.btnNewActionFromMessage.UseVisualStyleBackColor = true;
      this.btnNewActionFromMessage.Click += new System.EventHandler(this.btnNewActionFromMessage_Click);
      // 
      // lblMessageError
      // 
      this.lblMessageError.ForeColor = System.Drawing.Color.Red;
      this.lblMessageError.Location = new System.Drawing.Point(88, 224);
      this.lblMessageError.Name = "lblMessageError";
      this.lblMessageError.Size = new System.Drawing.Size(392, 56);
      this.lblMessageError.TabIndex = 12;
      this.lblMessageError.Text = "Address";
      this.lblMessageError.Visible = false;
      // 
      // txtRawData
      // 
      this.txtRawData.Location = new System.Drawing.Point(256, 72);
      this.txtRawData.Name = "txtRawData";
      this.txtRawData.ReadOnly = true;
      this.txtRawData.Size = new System.Drawing.Size(224, 23);
      this.txtRawData.TabIndex = 11;
      // 
      // lblRawData
      // 
      this.lblRawData.AutoSize = true;
      this.lblRawData.Location = new System.Drawing.Point(176, 72);
      this.lblRawData.Name = "lblRawData";
      this.lblRawData.Size = new System.Drawing.Size(55, 15);
      this.lblRawData.TabIndex = 10;
      this.lblRawData.Text = "Raw data";
      // 
      // txtRepeatGap
      // 
      this.txtRepeatGap.Location = new System.Drawing.Point(424, 40);
      this.txtRepeatGap.Name = "txtRepeatGap";
      this.txtRepeatGap.ReadOnly = true;
      this.txtRepeatGap.Size = new System.Drawing.Size(56, 23);
      this.txtRepeatGap.TabIndex = 9;
      // 
      // lblRepeatGap
      // 
      this.lblRepeatGap.AutoSize = true;
      this.lblRepeatGap.Location = new System.Drawing.Point(344, 40);
      this.lblRepeatGap.Name = "lblRepeatGap";
      this.lblRepeatGap.Size = new System.Drawing.Size(66, 15);
      this.lblRepeatGap.TabIndex = 8;
      this.lblRepeatGap.Text = "Repeat gap";
      // 
      // txtToggle
      // 
      this.txtToggle.Location = new System.Drawing.Point(88, 72);
      this.txtToggle.Name = "txtToggle";
      this.txtToggle.ReadOnly = true;
      this.txtToggle.Size = new System.Drawing.Size(80, 23);
      this.txtToggle.TabIndex = 7;
      // 
      // lblToggle
      // 
      this.lblToggle.AutoSize = true;
      this.lblToggle.Location = new System.Drawing.Point(8, 72);
      this.lblToggle.Name = "lblToggle";
      this.lblToggle.Size = new System.Drawing.Size(42, 15);
      this.lblToggle.TabIndex = 6;
      this.lblToggle.Text = "Toggle";
      // 
      // txtCommand
      // 
      this.txtCommand.Location = new System.Drawing.Point(256, 40);
      this.txtCommand.Name = "txtCommand";
      this.txtCommand.ReadOnly = true;
      this.txtCommand.Size = new System.Drawing.Size(80, 23);
      this.txtCommand.TabIndex = 5;
      // 
      // lblCommand
      // 
      this.lblCommand.AutoSize = true;
      this.lblCommand.Location = new System.Drawing.Point(176, 40);
      this.lblCommand.Name = "lblCommand";
      this.lblCommand.Size = new System.Drawing.Size(64, 15);
      this.lblCommand.TabIndex = 4;
      this.lblCommand.Text = "Command";
      // 
      // txtAddress
      // 
      this.txtAddress.Location = new System.Drawing.Point(88, 40);
      this.txtAddress.Name = "txtAddress";
      this.txtAddress.ReadOnly = true;
      this.txtAddress.Size = new System.Drawing.Size(80, 23);
      this.txtAddress.TabIndex = 3;
      // 
      // lblAddress
      // 
      this.lblAddress.AutoSize = true;
      this.lblAddress.Location = new System.Drawing.Point(8, 40);
      this.lblAddress.Name = "lblAddress";
      this.lblAddress.Size = new System.Drawing.Size(49, 15);
      this.lblAddress.TabIndex = 2;
      this.lblAddress.Text = "Address";
      // 
      // txtProtocol
      // 
      this.txtProtocol.Location = new System.Drawing.Point(88, 8);
      this.txtProtocol.Name = "txtProtocol";
      this.txtProtocol.ReadOnly = true;
      this.txtProtocol.Size = new System.Drawing.Size(80, 23);
      this.txtProtocol.TabIndex = 1;
      // 
      // lblProtocol
      // 
      this.lblProtocol.AutoSize = true;
      this.lblProtocol.Location = new System.Drawing.Point(8, 8);
      this.lblProtocol.Name = "lblProtocol";
      this.lblProtocol.Size = new System.Drawing.Size(52, 15);
      this.lblProtocol.TabIndex = 0;
      this.lblProtocol.Text = "Protocol";
      // 
      // tabPageRawData
      // 
      this.tabPageRawData.BackColor = System.Drawing.SystemColors.Control;
      this.tabPageRawData.Controls.Add(this.txtRawDataLog);
      this.tabPageRawData.Location = new System.Drawing.Point(4, 24);
      this.tabPageRawData.Name = "tabPageRawData";
      this.tabPageRawData.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageRawData.Size = new System.Drawing.Size(522, 428);
      this.tabPageRawData.TabIndex = 0;
      this.tabPageRawData.Text = "Raw data";
      // 
      // txtRawDataLog
      // 
      this.txtRawDataLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtRawDataLog.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtRawDataLog.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.txtRawDataLog.Location = new System.Drawing.Point(3, 3);
      this.txtRawDataLog.Name = "txtRawDataLog";
      this.txtRawDataLog.ReadOnly = true;
      this.txtRawDataLog.Size = new System.Drawing.Size(516, 422);
      this.txtRawDataLog.TabIndex = 0;
      this.txtRawDataLog.Text = "";
      this.txtRawDataLog.WordWrap = false;
      // 
      // tabPageActions
      // 
      this.tabPageActions.BackColor = System.Drawing.SystemColors.Control;
      this.tabPageActions.Controls.Add(this.dataActions);
      this.tabPageActions.Controls.Add(this.pnlActionControls);
      this.tabPageActions.Location = new System.Drawing.Point(4, 24);
      this.tabPageActions.Name = "tabPageActions";
      this.tabPageActions.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageActions.Size = new System.Drawing.Size(522, 428);
      this.tabPageActions.TabIndex = 2;
      this.tabPageActions.Text = "Actions";
      // 
      // dataActions
      // 
      this.dataActions.AllowUserToAddRows = false;
      this.dataActions.AllowUserToDeleteRows = false;
      this.dataActions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dataActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataActions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colProtocol,
            this.colAddress,
            this.colCommand,
            this.colActionType,
            this.colActionParameters,
            this.colToggle,
            this.colRepeat});
      this.dataActions.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dataActions.Location = new System.Drawing.Point(3, 32);
      this.dataActions.MultiSelect = false;
      this.dataActions.Name = "dataActions";
      this.dataActions.ReadOnly = true;
      this.dataActions.RowHeadersVisible = false;
      this.dataActions.RowTemplate.Height = 25;
      this.dataActions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataActions.Size = new System.Drawing.Size(516, 393);
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
      this.colActionType.DataPropertyName = "ActionType";
      this.colActionType.FillWeight = 99.21969F;
      this.colActionType.HeaderText = "Type";
      this.colActionType.MinimumWidth = 120;
      this.colActionType.Name = "colActionType";
      this.colActionType.ReadOnly = true;
      // 
      // colActionParameters
      // 
      this.colActionParameters.DataPropertyName = "ActionParameters";
      this.colActionParameters.FillWeight = 330.7323F;
      this.colActionParameters.HeaderText = "Parameters";
      this.colActionParameters.Name = "colActionParameters";
      this.colActionParameters.ReadOnly = true;
      // 
      // colToggle
      // 
      this.colToggle.DataPropertyName = "Toggle";
      this.colToggle.HeaderText = "Toggle";
      this.colToggle.Name = "colToggle";
      this.colToggle.ReadOnly = true;
      this.colToggle.Visible = false;
      // 
      // colRepeat
      // 
      this.colRepeat.DataPropertyName = "Repeat";
      this.colRepeat.HeaderText = "Repeat";
      this.colRepeat.Name = "colRepeat";
      this.colRepeat.ReadOnly = true;
      this.colRepeat.Visible = false;
      // 
      // pnlActionControls
      // 
      this.pnlActionControls.Controls.Add(this.btnDeleteAction);
      this.pnlActionControls.Controls.Add(this.btnEditAction);
      this.pnlActionControls.Controls.Add(this.btnNewAction);
      this.pnlActionControls.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlActionControls.Location = new System.Drawing.Point(3, 3);
      this.pnlActionControls.Name = "pnlActionControls";
      this.pnlActionControls.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
      this.pnlActionControls.Size = new System.Drawing.Size(516, 29);
      this.pnlActionControls.TabIndex = 1;
      // 
      // btnDeleteAction
      // 
      this.btnDeleteAction.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnDeleteAction.Enabled = false;
      this.btnDeleteAction.Location = new System.Drawing.Point(144, 2);
      this.btnDeleteAction.Name = "btnDeleteAction";
      this.btnDeleteAction.Size = new System.Drawing.Size(72, 25);
      this.btnDeleteAction.TabIndex = 2;
      this.btnDeleteAction.Text = "Delete";
      this.btnDeleteAction.UseVisualStyleBackColor = true;
      this.btnDeleteAction.Click += new System.EventHandler(this.btnDeleteAction_Click);
      // 
      // btnEditAction
      // 
      this.btnEditAction.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnEditAction.Enabled = false;
      this.btnEditAction.Location = new System.Drawing.Point(72, 2);
      this.btnEditAction.Name = "btnEditAction";
      this.btnEditAction.Size = new System.Drawing.Size(72, 25);
      this.btnEditAction.TabIndex = 1;
      this.btnEditAction.Text = "Edit";
      this.btnEditAction.UseVisualStyleBackColor = true;
      this.btnEditAction.Click += new System.EventHandler(this.btnEditAction_Click);
      // 
      // btnNewAction
      // 
      this.btnNewAction.Dock = System.Windows.Forms.DockStyle.Left;
      this.btnNewAction.Location = new System.Drawing.Point(0, 2);
      this.btnNewAction.Name = "btnNewAction";
      this.btnNewAction.Size = new System.Drawing.Size(72, 25);
      this.btnNewAction.TabIndex = 0;
      this.btnNewAction.Text = "New";
      this.btnNewAction.UseVisualStyleBackColor = true;
      this.btnNewAction.Click += new System.EventHandler(this.btnNewAction_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.chkTestMode);
      this.panel1.Controls.Add(this.grpReceiver);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(530, 48);
      this.panel1.TabIndex = 3;
      // 
      // chkTestMode
      // 
      this.chkTestMode.AutoSize = true;
      this.chkTestMode.Location = new System.Drawing.Point(264, 16);
      this.chkTestMode.Name = "chkTestMode";
      this.chkTestMode.Size = new System.Drawing.Size(238, 19);
      this.chkTestMode.TabIndex = 4;
      this.chkTestMode.Text = "Test mode (actions will not be executed)";
      this.chkTestMode.UseVisualStyleBackColor = true;
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(530, 504);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel1);
      this.Name = "frmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ArsiParsi";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.contextTray.ResumeLayout(false);
      this.grpReceiver.ResumeLayout(false);
      this.grpReceiver.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.tabPageLastMessage.ResumeLayout(false);
      this.tabPageLastMessage.PerformLayout();
      this.tabPageRawData.ResumeLayout(false);
      this.tabPageActions.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataActions)).EndInit();
      this.pnlActionControls.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
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
    private TabControl tabControl1;
    private TabPage tabPageRawData;
    private RichTextBox txtRawDataLog;
    private TabPage tabPageLastMessage;
    private Panel panel1;
    private TextBox txtRawData;
    private Label lblRawData;
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
    private TabPage tabPageActions;
    private DataGridView dataActions;
    private Panel pnlActionControls;
    private DataGridViewTextBoxColumn colName;
    private DataGridViewTextBoxColumn colProtocol;
    private DataGridViewTextBoxColumn colAddress;
    private DataGridViewTextBoxColumn colCommand;
    private DataGridViewTextBoxColumn colActionType;
    private DataGridViewTextBoxColumn colActionParameters;
    private DataGridViewTextBoxColumn colToggle;
    private DataGridViewTextBoxColumn colRepeat;
    private Button btnDeleteAction;
    private Button btnEditAction;
    private Button btnNewAction;
    private CheckBox chkTestMode;
    private RichTextBox txtMessageActions;
    private Label lblExecutedActions;
  }
}