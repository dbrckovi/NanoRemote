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
      this.panel1 = new System.Windows.Forms.Panel();
      this.lblMessageError = new System.Windows.Forms.Label();
      this.contextTray.SuspendLayout();
      this.grpReceiver.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabPageLastMessage.SuspendLayout();
      this.tabPageRawData.SuspendLayout();
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
      this.grpReceiver.Size = new System.Drawing.Size(232, 48);
      this.grpReceiver.TabIndex = 1;
      this.grpReceiver.TabStop = false;
      // 
      // btnReceiverConnectToggle
      // 
      this.btnReceiverConnectToggle.Location = new System.Drawing.Point(152, 16);
      this.btnReceiverConnectToggle.Name = "btnReceiverConnectToggle";
      this.btnReceiverConnectToggle.Size = new System.Drawing.Size(72, 24);
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
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 48);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(530, 456);
      this.tabControl1.TabIndex = 2;
      // 
      // tabPageLastMessage
      // 
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
      this.tabPageLastMessage.UseVisualStyleBackColor = true;
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
      this.tabPageRawData.Controls.Add(this.txtRawDataLog);
      this.tabPageRawData.Location = new System.Drawing.Point(4, 24);
      this.tabPageRawData.Name = "tabPageRawData";
      this.tabPageRawData.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageRawData.Size = new System.Drawing.Size(522, 428);
      this.tabPageRawData.TabIndex = 0;
      this.tabPageRawData.Text = "Raw data";
      this.tabPageRawData.UseVisualStyleBackColor = true;
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
      // panel1
      // 
      this.panel1.Controls.Add(this.grpReceiver);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(530, 48);
      this.panel1.TabIndex = 3;
      // 
      // lblMessageError
      // 
      this.lblMessageError.ForeColor = System.Drawing.Color.Red;
      this.lblMessageError.Location = new System.Drawing.Point(88, 104);
      this.lblMessageError.Name = "lblMessageError";
      this.lblMessageError.Size = new System.Drawing.Size(392, 72);
      this.lblMessageError.TabIndex = 12;
      this.lblMessageError.Text = "Address";
      this.lblMessageError.Visible = false;
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(530, 504);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.panel1);
      this.Name = "frmMain";
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
      this.panel1.ResumeLayout(false);
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
  }
}