using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArsiParsi
{
  public partial class frmEditAction : Form
  {
    private RCAction _action = null;

    public frmEditAction()
    {
      InitializeComponent();
    }

    public frmEditAction(RCAction action) : this()
    {
      _action = action;
    }

    private void frmEditAction_Load(object sender, EventArgs e)
    {
      foreach (RCActionType actionType in Enum.GetValues(typeof(RCActionType)))
      {
        cmbActionType.Items.Add(actionType);
      }

      chkProtocol.Checked = !string.IsNullOrEmpty(_action.Protocol);
      txtProtocol.Text = _action.Protocol;

      chkAddress.Checked = _action.Address.HasValue;
      numAddress.Value = _action.Address.HasValue ? _action.Address.Value : 0;

      chkCommand.Checked = _action.Command.HasValue;
      numCommand.Value = _action.Command.HasValue ? _action.Command.Value : 0;

      if (!_action.Toggle.HasValue) radToggleIgnore.Checked = true;
      else if (_action.Toggle.Value) radToggleTrue.Checked = true;
      else radToggleFalse.Checked = true;

      if (!_action.Repeat.HasValue) radRepeatIgnore.Checked = true;
      else if (_action.Repeat.Value) radRepeatTrue.Checked = true;
      else radRepeatFalse.Checked = true;

      cmbActionType.SelectedItem = _action.ActionType;
      txtName.Text = _action.Name;
      numDelayAfterExecution.Value = _action.DelayAfterExecution;

      if (pnlActionEditorContainer.Controls.Count > 0)
      {
        pnlActionEditorContainer.Controls[0].Dock = DockStyle.Fill;

        if (pnlActionEditorContainer.Controls[0] is IActionParameters)
        {
          IActionParameters ctl = (IActionParameters)pnlActionEditorContainer.Controls[0];
          ctl.Parameters = _action.ActionParameters;
        }
      }
    }

    private void chkProtocol_CheckedChanged(object sender, EventArgs e)
    {
      txtProtocol.Enabled = chkProtocol.Checked;
    }

    private void chkAddress_CheckedChanged(object sender, EventArgs e)
    {
      numAddress.Enabled = chkAddress.Checked;
    }

    private void chkCommand_CheckedChanged(object sender, EventArgs e)
    {
      numCommand.Enabled = chkCommand.Checked;
    }

    private void cmbActionType_SelectedIndexChanged(object sender, EventArgs e)
    {
      pnlActionEditorContainer.Controls.Clear();

      RCActionType actionType = (RCActionType)cmbActionType.SelectedItem;

      switch (actionType)
      {
        case RCActionType.ConsoleCommand:
          {
            pnlActionEditorContainer.Controls.Add(new ConsoleCommandEditor());
            break;
          }
        case RCActionType.SendKeys:
          {
            pnlActionEditorContainer.Controls.Add(new SendKeysEditor());
            break;
          }
        case RCActionType.MouseMove:
          {
            pnlActionEditorContainer.Controls.Add(new MoveMouseEditor());
            break;
          }
      }

      if (pnlActionEditorContainer.Controls.Count > 0)
      {
        pnlActionEditorContainer.Controls[0].Dock = DockStyle.Fill;
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      try
      {
        if (string.IsNullOrEmpty(txtName.Text)) throw new Exception("Name is not specified");

        _action.Protocol = chkProtocol.Checked ? txtProtocol.Text : null;
        _action.Address = chkAddress.Checked ? Convert.ToInt32(numAddress.Value) : null;
        _action.Command = chkCommand.Checked ? Convert.ToInt32(numCommand.Value) : null;

        if (radToggleIgnore.Checked) _action.Toggle = null;
        else _action.Toggle = radToggleTrue.Checked;

        if (radRepeatIgnore.Checked) _action.Repeat = null;
        else _action.Repeat = radRepeatTrue.Checked;

        _action.ActionType = (RCActionType)cmbActionType.SelectedItem;
        _action.Name = txtName.Text;
        _action.DelayAfterExecution = Convert.ToInt32(numDelayAfterExecution.Value);

        if (pnlActionEditorContainer.Controls.Count > 0 && pnlActionEditorContainer.Controls[0] is IActionParameters)
        {
          IActionParameters ctl = (IActionParameters)pnlActionEditorContainer.Controls[0];
          _action.ActionParameters = ctl.Parameters;
        }

        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
