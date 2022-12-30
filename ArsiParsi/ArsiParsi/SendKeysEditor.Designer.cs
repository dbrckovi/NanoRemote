namespace ArsiParsi
{
  partial class SendKeysEditor
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnTest = new System.Windows.Forms.Button();
      this.lblSendKeys = new System.Windows.Forms.Label();
      this.txtSendKeys = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.lnkInfo = new System.Windows.Forms.LinkLabel();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnTest
      // 
      this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnTest.Location = new System.Drawing.Point(280, 8);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(48, 24);
      this.btnTest.TabIndex = 5;
      this.btnTest.Text = "Test";
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
      // 
      // lblSendKeys
      // 
      this.lblSendKeys.AutoSize = true;
      this.lblSendKeys.Location = new System.Drawing.Point(8, 8);
      this.lblSendKeys.Name = "lblSendKeys";
      this.lblSendKeys.Size = new System.Drawing.Size(110, 15);
      this.lblSendKeys.TabIndex = 4;
      this.lblSendKeys.Text = "SendKeys sequence";
      // 
      // txtSendKeys
      // 
      this.txtSendKeys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSendKeys.Location = new System.Drawing.Point(128, 8);
      this.txtSendKeys.Name = "txtSendKeys";
      this.txtSendKeys.Size = new System.Drawing.Size(144, 23);
      this.txtSendKeys.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.ForeColor = System.Drawing.Color.Gray;
      this.label2.Location = new System.Drawing.Point(8, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(320, 32);
      this.label2.TabIndex = 6;
      this.label2.Text = "Simulates keypresses.\r\nExample: ^{ESC} RUN {ENTER} NOTEPAD {ENTER}";
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.ForeColor = System.Drawing.Color.Gray;
      this.label1.Location = new System.Drawing.Point(8, 72);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(32, 16);
      this.label1.TabIndex = 7;
      this.label1.Text = "See";
      // 
      // lnkInfo
      // 
      this.lnkInfo.AutoSize = true;
      this.lnkInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
      this.lnkInfo.Location = new System.Drawing.Point(32, 72);
      this.lnkInfo.Name = "lnkInfo";
      this.lnkInfo.Size = new System.Drawing.Size(168, 15);
      this.lnkInfo.TabIndex = 8;
      this.lnkInfo.TabStop = true;
      this.lnkInfo.Text = "https://learn.microsoft.com/...";
      this.lnkInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkInfo_LinkClicked);
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label3.ForeColor = System.Drawing.Color.Gray;
      this.label3.Location = new System.Drawing.Point(200, 72);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(96, 16);
      this.label3.TabIndex = 9;
      this.label3.Text = "for information.";
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label4.ForeColor = System.Drawing.Color.Gray;
      this.label4.Location = new System.Drawing.Point(8, 96);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(256, 16);
      this.label4.TabIndex = 10;
      this.label4.Text = "!!!Make sure you know what you are doing!!!";
      // 
      // SendKeysEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.lnkInfo);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnTest);
      this.Controls.Add(this.lblSendKeys);
      this.Controls.Add(this.txtSendKeys);
      this.Name = "SendKeysEditor";
      this.Size = new System.Drawing.Size(332, 123);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button btnTest;
    private Label lblSendKeys;
    private TextBox txtSendKeys;
    private Label label2;
    private Label label1;
    private LinkLabel lnkInfo;
    private Label label3;
    private Label label4;
  }
}
