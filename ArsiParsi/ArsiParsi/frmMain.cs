using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ArsiParsi
{
  public partial class frmMain : Form
  {
    RCReceiver _receiver = new RCReceiver();
    bool _allowVisible = false;
    bool _allowClose = false;
    RCMessage _lastMessage;

    public frmMain()
    {
      InitializeComponent();

      if (Program.RunTime)
      {
        this.Icon = Properties.Resources.RemoteOff;
        trayIcon.Icon = Properties.Resources.RemoteOff;
        _receiver.ConnectedChanged += _receiver_ConnectedChanged;
        _receiver.RawDataReceived += _receiver_RawDataReceived;
        _receiver.ReceiveError += _receiver_ReceiveError;
        _receiver.MessageReceived += _receiver_MessageReceived;

        string[] portNames = SerialPort.GetPortNames();
        cmbReceiverPort.Items.AddRange(portNames);

        if (!string.IsNullOrEmpty(Config.Instance.ComPort) && portNames.Contains(Config.Instance.ComPort))
        {
          _receiver.Connect(Config.Instance.ComPort, RCReceiver.DEFAULT_BAUD);
        }

        dataActions.AutoGenerateColumns = false;
      }
    }

    private void _receiver_MessageReceived(RCMessage message)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new Action(() => _receiver_MessageReceived(message)));
        return;
      }

      txtProtocol.Text = message.Protocol;
      txtAddress.Text = message.Address.ToString();
      txtCommand.Text = message.Command.ToString();
      txtRepeatGap.Text = message.RepeatGapMicroSeconds > 0 ? message.RepeatGapMicroSeconds.ToString() : "";
      txtToggle.Text = message.Toggle ? "YES" : "NO";
      txtRawData.Text = message.RawData;
      lblMessageError.Visible = false;
      _lastMessage = message;
      btnNewActionFromMessage.Enabled = true;

      StringBuilder sb = new StringBuilder();
      bool actionsFound = false;

      foreach (RCAction action in Config.Instance.Actions)
      {
        if (action.MatchesMessage(message))
        {
          actionsFound = true;
          if (chkTestMode.Checked) sb.AppendLine($"{action.Name} - Skipped (test mode)");
          else
          {
            try
            {
              action.ExecuteAction();
              sb.AppendLine($"{action.Name} - Executed");
            }
            catch (Exception ex)
            {
              sb.AppendLine($"{action.Name} - Error: {ex.Message}");
            }
          }
        }
      }
      if (!actionsFound) sb.AppendLine("No actions match this message");

      txtMessageActions.Text = sb.ToString();
    }

    private void _receiver_ReceiveError(Exception ex, string value)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new Action(() => _receiver_ReceiveError(ex, value)));
        return;
      }

      txtProtocol.Text = "";
      txtAddress.Text = "";
      txtCommand.Text = "";
      txtRepeatGap.Text = "";
      txtToggle.Text = "";
      txtRawData.Text = value;
      lblMessageError.Text = ex.Message;
      lblMessageError.Visible = true;
      txtMessageActions.Text = "";
    }

    protected override void SetVisibleCore(bool value)
    {
      if (!_allowVisible)
      {
        value = false;
        if (!this.IsHandleCreated) CreateHandle();
      }
      base.SetVisibleCore(value);
    }

    private void NewAction(bool fromLastMessage)
    {
      RCAction action = null;

      if (fromLastMessage)
      {
        action = new RCAction()
        {
          Protocol = _lastMessage.Protocol,
          Address = _lastMessage.Address,
          Command = _lastMessage.Command,
          Toggle = _lastMessage.Toggle ? true : null,
          Repeat = _lastMessage.RepeatGapMicroSeconds > 0 ? true : null,
          Name = $"{_lastMessage.Protocol}-{_lastMessage.Address}-{_lastMessage.Command}"
        };
      }
      else action = new RCAction();

      frmEditAction actionEditor = new frmEditAction(action);
      DialogResult result = actionEditor.ShowDialog(this);
      if (result == DialogResult.OK)
      {
        Config.Instance.Actions.Add(action);
        Config.Instance.Save();
        RefreshGUI();
      }
    }

    private void EditSelectedAction()
    {
      RCAction selectedAction = dataActions.DataSource != null && dataActions.CurrentRow != null ? (RCAction)dataActions.CurrentRow.DataBoundItem : null;

      if (selectedAction != null)
      {
        frmEditAction actionEditor = new frmEditAction(selectedAction);
        DialogResult result = actionEditor.ShowDialog(this);
        if (result == DialogResult.OK)
        {
          Config.Instance.Save();
          RefreshGUI();
        }
      }
    }

    private void DeleteSelectedAction()
    {
      RCAction selectedAction = dataActions.DataSource != null && dataActions.CurrentRow != null ? (RCAction)dataActions.CurrentRow.DataBoundItem : null;
      if (selectedAction != null)
      {
        dataActions.DataSource = null;
        Config.Instance.Actions.Remove(selectedAction);
        Config.Instance.Save();
        RefreshGUI();
      }
    }

    private void RefreshGUI()
    {
      cmbReceiverPort.Enabled = !_receiver.Connected;
      if (_receiver.Connected)
      {
        cmbReceiverPort.Enabled = false;
        cmbReceiverPort.Text = _receiver.Port;
        btnReceiverConnectToggle.Text = "Disconnect";
      }
      else
      {
        cmbReceiverPort.Enabled = true;
        btnReceiverConnectToggle.Text = "Connect";
      }

      RCAction selectedAction = dataActions.DataSource != null && dataActions.CurrentRow != null && dataActions.CurrentRow.DataBoundItem != null ? (RCAction)dataActions.CurrentRow.DataBoundItem : null;
      dataActions.DataSource = null;
      dataActions.DataSource = Config.Instance.Actions;
      if (selectedAction != null)
      {
        for (int x = 0; x < dataActions.Rows.Count; x++)
        {
          RCAction rowAction = (RCAction)dataActions.Rows[x].DataBoundItem;
          if (rowAction == selectedAction)
          {
            dataActions.Rows[x].Selected = true;
            break;
          }
        }
      }
    }

    private void _receiver_RawDataReceived(string value)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new Action(() => _receiver_RawDataReceived(value)));
        return;
      }

      txtRawDataLog.AppendText($"{value}{Environment.NewLine}");
      txtRawDataLog.SelectionStart = txtRawDataLog.Text.Length;
      txtRawDataLog.ScrollToCaret();
    }

    private void _receiver_ConnectedChanged()
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new Action(() => _receiver_ConnectedChanged()));
        return;
      }

      RefreshGUI();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      _allowClose = true;
      this.Close();
    }

    private void trayIcon_DoubleClick(object sender, EventArgs e)
    {
      _allowVisible = true;
      Show();
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (!_allowClose)
      {
        this.Hide();
        e.Cancel = true;
      }
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      try
      {
        RefreshGUI();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      _receiver.Disconnect();
    }

    private void btnReceiverConnectToggle_Click(object sender, EventArgs e)
    {
      try
      {
        if (_receiver.Connected) _receiver.Disconnect();
        else
        {
          if (!string.IsNullOrEmpty(cmbReceiverPort.Text))
          {
            _receiver.Connect(cmbReceiverPort.Text, RCReceiver.DEFAULT_BAUD);
            Config.Instance.ComPort = cmbReceiverPort.Text;
            Config.Instance.Save();
          }
          else throw new Exception("Port is not selected");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void cmbReceiverPort_DropDown(object sender, EventArgs e)
    {
      cmbReceiverPort.Items.Clear();
      cmbReceiverPort.Items.AddRange(SerialPort.GetPortNames());
    }

    private void btnNewActionFromMessage_Click(object sender, EventArgs e)
    {
      try
      {
        NewAction(true);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnNewAction_Click(object sender, EventArgs e)
    {
      try
      {
        NewAction(false);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnEditAction_Click(object sender, EventArgs e)
    {
      try
      {
        EditSelectedAction();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnDeleteAction_Click(object sender, EventArgs e)
    {
      try
      {
        DeleteSelectedAction();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void dataActions_SelectionChanged(object sender, EventArgs e)
    {
      btnEditAction.Enabled = btnDeleteAction.Enabled = dataActions.SelectedRows.Count == 1;
    }

    private void dataActions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      try
      {
        EditSelectedAction();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void dataActions_KeyUp(object sender, KeyEventArgs e)
    {
      try
      {
        if (e.KeyCode == Keys.Delete) DeleteSelectedAction();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}