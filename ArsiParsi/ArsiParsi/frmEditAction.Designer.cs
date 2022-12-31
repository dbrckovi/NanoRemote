namespace ArsiParsi
{
  partial class frmEditAction
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
      this.components = new System.ComponentModel.Container();
      this.txtProtocol = new System.Windows.Forms.TextBox();
      this.chkProtocol = new System.Windows.Forms.CheckBox();
      this.chkAddress = new System.Windows.Forms.CheckBox();
      this.numAddress = new System.Windows.Forms.NumericUpDown();
      this.numCommand = new System.Windows.Forms.NumericUpDown();
      this.chkCommand = new System.Windows.Forms.CheckBox();
      this.radToggleFalse = new System.Windows.Forms.RadioButton();
      this.radToggleTrue = new System.Windows.Forms.RadioButton();
      this.radToggleIgnore = new System.Windows.Forms.RadioButton();
      this.grpToggle = new System.Windows.Forms.GroupBox();
      this.grpBasic = new System.Windows.Forms.GroupBox();
      this.grpRepeat = new System.Windows.Forms.GroupBox();
      this.radRepeatIgnore = new System.Windows.Forms.RadioButton();
      this.radRepeatFalse = new System.Windows.Forms.RadioButton();
      this.radRepeatTrue = new System.Windows.Forms.RadioButton();
      this.grpTrigger = new System.Windows.Forms.GroupBox();
      this.grpAction = new System.Windows.Forms.GroupBox();
      this.numDelayAfterExecution = new System.Windows.Forms.NumericUpDown();
      this.lblDelayAfterExecution = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.lblName = new System.Windows.Forms.Label();
      this.pnlActionEditorContainer = new System.Windows.Forms.Panel();
      this.cmbActionType = new System.Windows.Forms.ComboBox();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.numAddress)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numCommand)).BeginInit();
      this.grpToggle.SuspendLayout();
      this.grpBasic.SuspendLayout();
      this.grpRepeat.SuspendLayout();
      this.grpTrigger.SuspendLayout();
      this.grpAction.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numDelayAfterExecution)).BeginInit();
      this.SuspendLayout();
      // 
      // txtProtocol
      // 
      this.txtProtocol.Enabled = false;
      this.txtProtocol.Location = new System.Drawing.Point(137, 40);
      this.txtProtocol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtProtocol.Name = "txtProtocol";
      this.txtProtocol.Size = new System.Drawing.Size(170, 31);
      this.txtProtocol.TabIndex = 2;
      // 
      // chkProtocol
      // 
      this.chkProtocol.AutoSize = true;
      this.chkProtocol.Location = new System.Drawing.Point(11, 40);
      this.chkProtocol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkProtocol.Name = "chkProtocol";
      this.chkProtocol.Size = new System.Drawing.Size(105, 29);
      this.chkProtocol.TabIndex = 3;
      this.chkProtocol.Text = "Protocol";
      this.chkProtocol.UseVisualStyleBackColor = true;
      this.chkProtocol.CheckedChanged += new System.EventHandler(this.chkProtocol_CheckedChanged);
      // 
      // chkAddress
      // 
      this.chkAddress.AutoSize = true;
      this.chkAddress.Location = new System.Drawing.Point(11, 93);
      this.chkAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkAddress.Name = "chkAddress";
      this.chkAddress.Size = new System.Drawing.Size(103, 29);
      this.chkAddress.TabIndex = 5;
      this.chkAddress.Text = "Address";
      this.chkAddress.UseVisualStyleBackColor = true;
      this.chkAddress.CheckedChanged += new System.EventHandler(this.chkAddress_CheckedChanged);
      // 
      // numAddress
      // 
      this.numAddress.Enabled = false;
      this.numAddress.Location = new System.Drawing.Point(137, 93);
      this.numAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.numAddress.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numAddress.Name = "numAddress";
      this.numAddress.Size = new System.Drawing.Size(171, 31);
      this.numAddress.TabIndex = 6;
      // 
      // numCommand
      // 
      this.numCommand.Enabled = false;
      this.numCommand.Location = new System.Drawing.Point(137, 147);
      this.numCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.numCommand.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numCommand.Name = "numCommand";
      this.numCommand.Size = new System.Drawing.Size(171, 31);
      this.numCommand.TabIndex = 8;
      // 
      // chkCommand
      // 
      this.chkCommand.AutoSize = true;
      this.chkCommand.Location = new System.Drawing.Point(11, 147);
      this.chkCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.chkCommand.Name = "chkCommand";
      this.chkCommand.Size = new System.Drawing.Size(122, 29);
      this.chkCommand.TabIndex = 7;
      this.chkCommand.Text = "Command";
      this.chkCommand.UseVisualStyleBackColor = true;
      this.chkCommand.CheckedChanged += new System.EventHandler(this.chkCommand_CheckedChanged);
      // 
      // radToggleFalse
      // 
      this.radToggleFalse.AutoSize = true;
      this.radToggleFalse.Location = new System.Drawing.Point(11, 93);
      this.radToggleFalse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.radToggleFalse.Name = "radToggleFalse";
      this.radToggleFalse.Size = new System.Drawing.Size(158, 29);
      this.radToggleFalse.TabIndex = 9;
      this.radToggleFalse.Text = "Only when OFF";
      this.radToggleFalse.UseVisualStyleBackColor = true;
      // 
      // radToggleTrue
      // 
      this.radToggleTrue.AutoSize = true;
      this.radToggleTrue.Location = new System.Drawing.Point(11, 133);
      this.radToggleTrue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.radToggleTrue.Name = "radToggleTrue";
      this.radToggleTrue.Size = new System.Drawing.Size(153, 29);
      this.radToggleTrue.TabIndex = 10;
      this.radToggleTrue.Text = "Only when ON";
      this.radToggleTrue.UseVisualStyleBackColor = true;
      // 
      // radToggleIgnore
      // 
      this.radToggleIgnore.AutoSize = true;
      this.radToggleIgnore.Checked = true;
      this.radToggleIgnore.Location = new System.Drawing.Point(11, 53);
      this.radToggleIgnore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.radToggleIgnore.Name = "radToggleIgnore";
      this.radToggleIgnore.Size = new System.Drawing.Size(118, 29);
      this.radToggleIgnore.TabIndex = 11;
      this.radToggleIgnore.TabStop = true;
      this.radToggleIgnore.Text = "Don\'t care";
      this.radToggleIgnore.UseVisualStyleBackColor = true;
      // 
      // grpToggle
      // 
      this.grpToggle.Controls.Add(this.radToggleIgnore);
      this.grpToggle.Controls.Add(this.radToggleFalse);
      this.grpToggle.Controls.Add(this.radToggleTrue);
      this.grpToggle.Location = new System.Drawing.Point(343, 40);
      this.grpToggle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpToggle.Name = "grpToggle";
      this.grpToggle.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpToggle.Size = new System.Drawing.Size(171, 200);
      this.grpToggle.TabIndex = 12;
      this.grpToggle.TabStop = false;
      this.grpToggle.Text = "Toggle";
      // 
      // grpBasic
      // 
      this.grpBasic.Controls.Add(this.txtProtocol);
      this.grpBasic.Controls.Add(this.chkProtocol);
      this.grpBasic.Controls.Add(this.numCommand);
      this.grpBasic.Controls.Add(this.chkAddress);
      this.grpBasic.Controls.Add(this.chkCommand);
      this.grpBasic.Controls.Add(this.numAddress);
      this.grpBasic.Location = new System.Drawing.Point(11, 40);
      this.grpBasic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpBasic.Name = "grpBasic";
      this.grpBasic.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpBasic.Size = new System.Drawing.Size(320, 200);
      this.grpBasic.TabIndex = 13;
      this.grpBasic.TabStop = false;
      this.grpBasic.Text = "Basic";
      // 
      // grpRepeat
      // 
      this.grpRepeat.Controls.Add(this.radRepeatIgnore);
      this.grpRepeat.Controls.Add(this.radRepeatFalse);
      this.grpRepeat.Controls.Add(this.radRepeatTrue);
      this.grpRepeat.Location = new System.Drawing.Point(526, 40);
      this.grpRepeat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpRepeat.Name = "grpRepeat";
      this.grpRepeat.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpRepeat.Size = new System.Drawing.Size(183, 200);
      this.grpRepeat.TabIndex = 14;
      this.grpRepeat.TabStop = false;
      this.grpRepeat.Text = "Repeat";
      // 
      // radRepeatIgnore
      // 
      this.radRepeatIgnore.AutoSize = true;
      this.radRepeatIgnore.Checked = true;
      this.radRepeatIgnore.Location = new System.Drawing.Point(11, 53);
      this.radRepeatIgnore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.radRepeatIgnore.Name = "radRepeatIgnore";
      this.radRepeatIgnore.Size = new System.Drawing.Size(118, 29);
      this.radRepeatIgnore.TabIndex = 14;
      this.radRepeatIgnore.TabStop = true;
      this.radRepeatIgnore.Text = "Don\'t care";
      this.radRepeatIgnore.UseVisualStyleBackColor = true;
      // 
      // radRepeatFalse
      // 
      this.radRepeatFalse.AutoSize = true;
      this.radRepeatFalse.Location = new System.Drawing.Point(11, 93);
      this.radRepeatFalse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.radRepeatFalse.Name = "radRepeatFalse";
      this.radRepeatFalse.Size = new System.Drawing.Size(135, 29);
      this.radRepeatFalse.TabIndex = 12;
      this.radRepeatFalse.Text = "Only on first";
      this.radRepeatFalse.UseVisualStyleBackColor = true;
      // 
      // radRepeatTrue
      // 
      this.radRepeatTrue.AutoSize = true;
      this.radRepeatTrue.Location = new System.Drawing.Point(11, 133);
      this.radRepeatTrue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.radRepeatTrue.Name = "radRepeatTrue";
      this.radRepeatTrue.Size = new System.Drawing.Size(155, 29);
      this.radRepeatTrue.TabIndex = 13;
      this.radRepeatTrue.Text = "Only on repeat";
      this.radRepeatTrue.UseVisualStyleBackColor = true;
      // 
      // grpTrigger
      // 
      this.grpTrigger.Controls.Add(this.grpBasic);
      this.grpTrigger.Controls.Add(this.grpRepeat);
      this.grpTrigger.Controls.Add(this.grpToggle);
      this.grpTrigger.Location = new System.Drawing.Point(11, 13);
      this.grpTrigger.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpTrigger.Name = "grpTrigger";
      this.grpTrigger.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpTrigger.Size = new System.Drawing.Size(720, 253);
      this.grpTrigger.TabIndex = 15;
      this.grpTrigger.TabStop = false;
      this.grpTrigger.Text = "Trigger";
      // 
      // grpAction
      // 
      this.grpAction.Controls.Add(this.numDelayAfterExecution);
      this.grpAction.Controls.Add(this.lblDelayAfterExecution);
      this.grpAction.Controls.Add(this.txtName);
      this.grpAction.Controls.Add(this.lblName);
      this.grpAction.Controls.Add(this.pnlActionEditorContainer);
      this.grpAction.Controls.Add(this.cmbActionType);
      this.grpAction.Location = new System.Drawing.Point(11, 280);
      this.grpAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpAction.Name = "grpAction";
      this.grpAction.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.grpAction.Size = new System.Drawing.Size(1040, 333);
      this.grpAction.TabIndex = 16;
      this.grpAction.TabStop = false;
      this.grpAction.Text = "Action";
      // 
      // numDelayAfterExecution
      // 
      this.numDelayAfterExecution.Location = new System.Drawing.Point(936, 40);
      this.numDelayAfterExecution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.numDelayAfterExecution.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
      this.numDelayAfterExecution.Name = "numDelayAfterExecution";
      this.numDelayAfterExecution.Size = new System.Drawing.Size(93, 31);
      this.numDelayAfterExecution.TabIndex = 7;
      // 
      // lblDelayAfterExecution
      // 
      this.lblDelayAfterExecution.AutoSize = true;
      this.lblDelayAfterExecution.Location = new System.Drawing.Point(720, 40);
      this.lblDelayAfterExecution.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblDelayAfterExecution.Name = "lblDelayAfterExecution";
      this.lblDelayAfterExecution.Size = new System.Drawing.Size(216, 25);
      this.lblDelayAfterExecution.TabIndex = 4;
      this.lblDelayAfterExecution.Text = "Delay after execution (ms)";
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(354, 40);
      this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(353, 31);
      this.txtName.TabIndex = 3;
      // 
      // lblName
      // 
      this.lblName.AutoSize = true;
      this.lblName.Location = new System.Drawing.Point(286, 40);
      this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblName.Name = "lblName";
      this.lblName.Size = new System.Drawing.Size(59, 25);
      this.lblName.TabIndex = 2;
      this.lblName.Text = "Name";
      // 
      // pnlActionEditorContainer
      // 
      this.pnlActionEditorContainer.Location = new System.Drawing.Point(11, 93);
      this.pnlActionEditorContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.pnlActionEditorContainer.Name = "pnlActionEditorContainer";
      this.pnlActionEditorContainer.Size = new System.Drawing.Size(1017, 227);
      this.pnlActionEditorContainer.TabIndex = 1;
      // 
      // cmbActionType
      // 
      this.cmbActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbActionType.FormattingEnabled = true;
      this.cmbActionType.Location = new System.Drawing.Point(11, 40);
      this.cmbActionType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.cmbActionType.Name = "cmbActionType";
      this.cmbActionType.Size = new System.Drawing.Size(227, 33);
      this.cmbActionType.TabIndex = 0;
      this.cmbActionType.SelectedIndexChanged += new System.EventHandler(this.cmbActionType_SelectedIndexChanged);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(309, 640);
      this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(137, 53);
      this.btnSave.TabIndex = 17;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(594, 640);
      this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(137, 53);
      this.btnCancel.TabIndex = 18;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // frmEditAction
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1067, 725);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.grpAction);
      this.Controls.Add(this.grpTrigger);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmEditAction";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Edit action";
      this.Load += new System.EventHandler(this.frmEditAction_Load);
      ((System.ComponentModel.ISupportInitialize)(this.numAddress)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numCommand)).EndInit();
      this.grpToggle.ResumeLayout(false);
      this.grpToggle.PerformLayout();
      this.grpBasic.ResumeLayout(false);
      this.grpBasic.PerformLayout();
      this.grpRepeat.ResumeLayout(false);
      this.grpRepeat.PerformLayout();
      this.grpTrigger.ResumeLayout(false);
      this.grpAction.ResumeLayout(false);
      this.grpAction.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numDelayAfterExecution)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private TextBox txtProtocol;
    private CheckBox chkProtocol;
    private CheckBox chkAddress;
    private NumericUpDown numAddress;
    private NumericUpDown numCommand;
    private CheckBox chkCommand;
    private RadioButton radToggleFalse;
    private RadioButton radToggleTrue;
    private RadioButton radToggleIgnore;
    private GroupBox grpToggle;
    private GroupBox grpBasic;
    private GroupBox grpRepeat;
    private RadioButton radRepeatIgnore;
    private RadioButton radRepeatFalse;
    private RadioButton radRepeatTrue;
    private GroupBox grpTrigger;
    private GroupBox grpAction;
    private ComboBox cmbActionType;
    private Button btnSave;
    private Button btnCancel;
    private Panel pnlActionEditorContainer;
    private TextBox txtName;
    private Label lblName;
    private NumericUpDown numDelayAfterExecution;
    private Label lblDelayAfterExecution;
        private ToolTip toolTip1;
    }
}