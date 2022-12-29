using System.IO.Ports;
using System.Windows.Forms;

namespace ArsiParsi
{
  public partial class frmMain : Form
  {
    RCReceiver _receiver = new RCReceiver();
    bool _allowVisible = false;
    bool _allowClose = false;

    public frmMain()
    {
      InitializeComponent();
      this.Icon = Properties.Resources.RemoteOff;
      trayIcon.Icon = Properties.Resources.RemoteOff;
      _receiver.ConnectedChanged += _receiver_ConnectedChanged;
      _receiver.RawDataReceived += _receiver_RawDataReceived;
      _receiver.ReceiveError += _receiver_ReceiveError;
      _receiver.MessageReceived += _receiver_MessageReceived;
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
      txtRepeatGap.Text = message.RepeatGapMicroSeconds > 0 ? message.RepeatGapMicroSeconds.ToString(): "";
      txtToggle.Text = message.Toggle ? "YES" : "NO";
      txtRawData.Text = message.RawData;
      lblMessageError.Visible = false;
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

    private void _receiver_RawDataReceived(string value)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new Action(() => _receiver_RawDataReceived(value)));
        return;
      }

      txtRawDataLog.AppendText(value);
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
          if (!string.IsNullOrEmpty(cmbReceiverPort.Text)) _receiver.Connect(cmbReceiverPort.Text, RCReceiver.DEFAULT_BAUD);
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
  }
}