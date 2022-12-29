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
      this.tabPageRawData = new System.Windows.Forms.TabPage();
      this.txtRawData = new System.Windows.Forms.RichTextBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.panel1 = new System.Windows.Forms.Panel();
      this.contextTray.SuspendLayout();
      this.grpReceiver.SuspendLayout();
      this.tabControl1.SuspendLayout();
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
      this.tabControl1.Controls.Add(this.tabPageRawData);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 48);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(594, 456);
      this.tabControl1.TabIndex = 2;
      // 
      // tabPageRawData
      // 
      this.tabPageRawData.Controls.Add(this.txtRawData);
      this.tabPageRawData.Location = new System.Drawing.Point(4, 24);
      this.tabPageRawData.Name = "tabPageRawData";
      this.tabPageRawData.Padding = new System.Windows.Forms.Padding(3);
      this.tabPageRawData.Size = new System.Drawing.Size(586, 428);
      this.tabPageRawData.TabIndex = 0;
      this.tabPageRawData.Text = "Raw data";
      this.tabPageRawData.UseVisualStyleBackColor = true;
      // 
      // txtRawData
      // 
      this.txtRawData.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtRawData.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtRawData.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.txtRawData.Location = new System.Drawing.Point(3, 3);
      this.txtRawData.Name = "txtRawData";
      this.txtRawData.ReadOnly = true;
      this.txtRawData.Size = new System.Drawing.Size(580, 422);
      this.txtRawData.TabIndex = 0;
      this.txtRawData.Text = "";
      this.txtRawData.WordWrap = false;
      // 
      // tabPage2
      // 
      this.tabPage2.Location = new System.Drawing.Point(4, 24);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(464, 244);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "tabPage2";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.grpReceiver);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(594, 48);
      this.panel1.TabIndex = 3;
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(594, 504);
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
    private RichTextBox txtRawData;
    private TabPage tabPage2;
    private Panel panel1;
  }
}