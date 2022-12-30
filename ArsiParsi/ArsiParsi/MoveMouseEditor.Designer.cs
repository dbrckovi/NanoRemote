namespace ArsiParsi
{
  partial class MoveMouseEditor
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
      this.radL = new System.Windows.Forms.RadioButton();
      this.radR = new System.Windows.Forms.RadioButton();
      this.radU = new System.Windows.Forms.RadioButton();
      this.radD = new System.Windows.Forms.RadioButton();
      this.radUL = new System.Windows.Forms.RadioButton();
      this.radUR = new System.Windows.Forms.RadioButton();
      this.radDL = new System.Windows.Forms.RadioButton();
      this.radDR = new System.Windows.Forms.RadioButton();
      this.label1 = new System.Windows.Forms.Label();
      this.numPixels = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.numPixels)).BeginInit();
      this.SuspendLayout();
      // 
      // radL
      // 
      this.radL.AutoSize = true;
      this.radL.Location = new System.Drawing.Point(8, 32);
      this.radL.Name = "radL";
      this.radL.Size = new System.Drawing.Size(45, 19);
      this.radL.TabIndex = 0;
      this.radL.Text = "Left";
      this.radL.UseVisualStyleBackColor = true;
      // 
      // radR
      // 
      this.radR.AutoSize = true;
      this.radR.Location = new System.Drawing.Point(160, 32);
      this.radR.Name = "radR";
      this.radR.Size = new System.Drawing.Size(53, 19);
      this.radR.TabIndex = 1;
      this.radR.Text = "Right";
      this.radR.UseVisualStyleBackColor = true;
      // 
      // radU
      // 
      this.radU.AutoSize = true;
      this.radU.Location = new System.Drawing.Point(96, 8);
      this.radU.Name = "radU";
      this.radU.Size = new System.Drawing.Size(40, 19);
      this.radU.TabIndex = 2;
      this.radU.Text = "Up";
      this.radU.UseVisualStyleBackColor = true;
      // 
      // radD
      // 
      this.radD.AutoSize = true;
      this.radD.Location = new System.Drawing.Point(96, 56);
      this.radD.Name = "radD";
      this.radD.Size = new System.Drawing.Size(56, 19);
      this.radD.TabIndex = 3;
      this.radD.Text = "Down";
      this.radD.UseVisualStyleBackColor = true;
      // 
      // radUL
      // 
      this.radUL.AutoSize = true;
      this.radUL.Checked = true;
      this.radUL.Location = new System.Drawing.Point(8, 8);
      this.radUL.Name = "radUL";
      this.radUL.Size = new System.Drawing.Size(65, 19);
      this.radUL.TabIndex = 4;
      this.radUL.TabStop = true;
      this.radUL.Text = "Up-Left";
      this.radUL.UseVisualStyleBackColor = true;
      // 
      // radUR
      // 
      this.radUR.AutoSize = true;
      this.radUR.Location = new System.Drawing.Point(160, 8);
      this.radUR.Name = "radUR";
      this.radUR.Size = new System.Drawing.Size(73, 19);
      this.radUR.TabIndex = 5;
      this.radUR.Text = "Up-Right";
      this.radUR.UseVisualStyleBackColor = true;
      // 
      // radDL
      // 
      this.radDL.AutoSize = true;
      this.radDL.Location = new System.Drawing.Point(8, 56);
      this.radDL.Name = "radDL";
      this.radDL.Size = new System.Drawing.Size(81, 19);
      this.radDL.TabIndex = 6;
      this.radDL.Text = "Down-Left";
      this.radDL.UseVisualStyleBackColor = true;
      // 
      // radDR
      // 
      this.radDR.AutoSize = true;
      this.radDR.Location = new System.Drawing.Point(160, 56);
      this.radDR.Name = "radDR";
      this.radDR.Size = new System.Drawing.Size(89, 19);
      this.radDR.TabIndex = 7;
      this.radDR.Text = "Down-Right";
      this.radDR.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(272, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 15);
      this.label1.TabIndex = 8;
      this.label1.Text = "Pixels";
      // 
      // numPixels
      // 
      this.numPixels.Location = new System.Drawing.Point(272, 32);
      this.numPixels.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.numPixels.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.numPixels.Name = "numPixels";
      this.numPixels.Size = new System.Drawing.Size(48, 23);
      this.numPixels.TabIndex = 9;
      this.numPixels.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // label4
      // 
      this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label4.ForeColor = System.Drawing.Color.Gray;
      this.label4.Location = new System.Drawing.Point(8, 88);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(296, 16);
      this.label4.TabIndex = 11;
      this.label4.Text = "Moves mouse cursor in specified direction.";
      // 
      // MoveMouseEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.label4);
      this.Controls.Add(this.numPixels);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.radDR);
      this.Controls.Add(this.radDL);
      this.Controls.Add(this.radUR);
      this.Controls.Add(this.radUL);
      this.Controls.Add(this.radD);
      this.Controls.Add(this.radU);
      this.Controls.Add(this.radR);
      this.Controls.Add(this.radL);
      this.Name = "MoveMouseEditor";
      this.Size = new System.Drawing.Size(332, 123);
      ((System.ComponentModel.ISupportInitialize)(this.numPixels)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private RadioButton radL;
    private RadioButton radR;
    private RadioButton radU;
    private RadioButton radD;
    private RadioButton radUL;
    private RadioButton radUR;
    private RadioButton radDL;
    private RadioButton radDR;
    private Label label1;
    private NumericUpDown numPixels;
    private Label label4;
  }
}
