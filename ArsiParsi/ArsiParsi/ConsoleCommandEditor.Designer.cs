namespace ArsiParsi
{
  partial class ConsoleCommandEditor
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
      this.txtCommand = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnTest = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // txtCommand
      // 
      this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtCommand.Location = new System.Drawing.Point(80, 8);
      this.txtCommand.Name = "txtCommand";
      this.txtCommand.Size = new System.Drawing.Size(192, 23);
      this.txtCommand.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(64, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "Command";
      // 
      // btnTest
      // 
      this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnTest.Location = new System.Drawing.Point(280, 8);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(48, 24);
      this.btnTest.TabIndex = 2;
      this.btnTest.Text = "Test";
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.ForeColor = System.Drawing.Color.Gray;
      this.label2.Location = new System.Drawing.Point(8, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(320, 80);
      this.label2.TabIndex = 3;
      this.label2.Text = "Starts a new command prompt window and passes your command as /c parameter.\r\nExam" +
    "ple  \r\nYour text:    Notepad\r\nCommand: cmd.exe /c Notepad";
      // 
      // ConsoleCommandEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnTest);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtCommand);
      this.Name = "ConsoleCommandEditor";
      this.Size = new System.Drawing.Size(332, 123);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TextBox txtCommand;
    private Label label1;
    private Button btnTest;
    private Label label2;
  }
}
