using System;
using System.Data;
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
    bool _fullyLoaded = false;

    /// <summary>
    /// Gets currently selected action in <see cref="dataActions"/>
    /// </summary>
    private RCAction SelectedActionInGrid
    {
      get
      {
        RCAction ret = null;

        if (dataActions.SelectedRows.Count > 0)
        {
          DataRowView rowView = (DataRowView)dataActions.SelectedRows[0].DataBoundItem;
          DataRow row = rowView.Row;
          ret = (RCAction)row["ActionObject"];
        }

        return ret;
      }
    }

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

        chkSplashOnStartup.Checked = Config.Instance.ShowSplash;
        if (Config.Instance.ShowSplash)
        {
          frmSplash splash = new frmSplash();
          splash.Show();
        }
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
      lblMessageError.Visible = false;
      _lastMessage = message;
      btnNewActionFromMessage.Enabled = true;

      bool actionsFound = false;

      AddLogLine($"RC message received: {message.ToString()}");

      foreach (RCAction action in Config.Instance.Actions)
      {
        if (action.MatchesMessage(message))
        {
          actionsFound = true;
          if (chkTestMode.Checked) AddLogLine($" - Skipped action '{action.Name}' because test mode is active");
          else if (action.IsInDelayPeriod) AddLogLine($" - Skipped action '{action.Name}' because this action was executed in the last {action.DelayAfterExecution}ms");
          else
          {
            try
            {
              action.ExecuteAction();
              AddLogLine($" - Executed action '{action.Name}'");
            }
            catch (Exception ex)
            {
              AddLogLine($" - Error executing action '{action.Name}': {ex.Message}");
            }
          }
        }
      }
      
      if (!actionsFound) AddLogLine(" - No actions match this message");
      AddLogLine("");
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
      lblMessageError.Text = ex.Message;
      lblMessageError.Visible = true;

      AddLogLine("Message could not be parsed (probably noise or unrecognized RC format)");
      AddLogLine($" - {ex.Message}");
      AddLogLine("");
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
      if (SelectedActionInGrid != null)
      {
        frmEditAction actionEditor = new frmEditAction(SelectedActionInGrid);
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
      if (SelectedActionInGrid != null)
      {
        Config.Instance.Actions.Remove(SelectedActionInGrid);
        Config.Instance.Save();
        RefreshGUI();
      }
    }

    private void AddLogLine(string message)
    {
      message = $"{message}{Environment.NewLine}";
      txtLog.AppendText(message);
      txtLog.SelectionStart = txtLog.Text.Length;
      txtLog.ScrollToCaret();
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

      RefreshActionGrid();
    }

    private void RefreshActionGrid()
    {
      //This used to be bound directly to Config.Instance.Actions but it kept throwing weird indexing errors.
      //Instead of dancing around M$ trying to be smart, I'm doing it manually like Crom intended.

      RCAction oldSelectedAction = SelectedActionInGrid;

      DataTable table = new DataTable();
      table.Columns.Add("Name", typeof(string));
      table.Columns.Add("Protocol", typeof(string));
      table.Columns.Add("Address", typeof(string));
      table.Columns.Add("Command", typeof(string));
      table.Columns.Add("Type", typeof(string));
      table.Columns.Add("ActionObject", typeof(RCAction));

      foreach (RCAction action in Config.Instance.Actions)
      {
        DataRow row = table.NewRow();
        row["Name"] = action.Name;
        row["Protocol"] = action.Protocol;
        row["Address"] = action.Address.ToString();
        row["Command"] = action.Command.ToString();
        row["Type"] = action.ActionType.ToString();
        row["ActionObject"] = action;
        table.Rows.Add(row);
      }

      dataActions.DataSource = table;

      if (oldSelectedAction != null)
      {
        foreach(DataGridViewRow gridrowView in dataActions.Rows)
        {
          DataRowView rowView = (DataRowView)gridrowView.DataBoundItem;
          RCAction rowAction = (RCAction)rowView.Row["ActionObject"];
          if (rowAction == oldSelectedAction)
          {
            gridrowView.Selected = true;
            break;
          }
        }
      }
    }

    private void SetToolTips()
    {
      toolTip1.SetToolTip(cmbReceiverPort, "COM port where RC receiver is connected");
      toolTip1.SetToolTip(btnReceiverConnectToggle, "Connect or disconnect the RC receiver");
      toolTip1.SetToolTip(chkTestMode, "When enabled messages will be received, but their actions will be skipped");
      toolTip1.SetToolTip(btnNewActionFromMessage, "Opens an action editor and fills it with data of the last received RC message");

      toolTip1.SetToolTip(btnNewAction, "Opens a blank action editor allowing you to create a new action, but you will have to fill in filter parameters manually");
      toolTip1.SetToolTip(btnEditAction, "Allows you to change currently selected action");
      toolTip1.SetToolTip(btnDeleteAction, "Deletes currently selected action");

      toolTip1.SetToolTip(chkLogRawData, "When enabled, logs raw data received from the RC receiver");
      toolTip1.SetToolTip(chkSplashOnStartup, "Enables or disable the splash on startup");
    }

    private void _receiver_RawDataReceived(string value)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new Action(() => _receiver_RawDataReceived(value)));
        return;
      }

      if (chkLogRawData.Checked) AddLogLine($"Raw data received:{Environment.NewLine}{value}{Environment.NewLine}");
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
        SetToolTips();
        RefreshGUI();
        _fullyLoaded = true;
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

    private void btnClearLog_Click(object sender, EventArgs e)
    {
      txtLog.Text = "";
    }

    private void chkSplashOnStartup_CheckedChanged(object sender, EventArgs e)
    {
      if (_fullyLoaded)
      {
        Config.Instance.ShowSplash = chkSplashOnStartup.Checked;
        Config.Instance.Save();
      }
    }
  }
}