using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ArsiParsi
{
  internal class RCReceiver
  {
    public const int DEFAULT_BAUD = 115200;
    public const int DATA_RECEIVE_DELAY_MS = 10;  //number of milliseconds to wait for new data after the last data was received, before processing it

    SerialPort _port;
    StringBuilder _dataBuilder = new StringBuilder();
    DateTime _lastRawDataReceiveTime = DateTime.Now;
    Thread _worker = null;

    public bool Connected
    {
      get { return _port != null; }
    }

    public string Port
    {
      get { return _port != null ? _port.PortName : null; }
    }

    public bool RemoveEmptyLines { get; set; } = true;

    public event Delegates.VoidDelegate ConnectedChanged;
    public event Delegates.StringDelegate RawDataReceived;

    public RCReceiver()
    {

    }

    public void Connect(string portName, int baudRate)
    {
      if (Connected) Disconnect();
      _port = new SerialPort(portName, baudRate);
      _port.Open();
      _port.DataReceived += _port_DataReceived;

      _worker = new Thread(Work);
      _worker.IsBackground = true;
      _worker.Name = "IRReceiver worker";
      _worker.Start();

      ConnectedChanged?.Invoke();
    }

    public void Disconnect()
    {
      if (Connected)
      {
        _port.Close();
        _port.DataReceived -= _port_DataReceived;
        _port.Dispose();
        _port = null;
        ConnectedChanged?.Invoke();
      }
    }

    private void Work()
    {
      while(_port != null)
      {
        if (_dataBuilder.Length > 0)
        {
          TimeSpan span = DateTime.Now - _lastRawDataReceiveTime;
          if (span.TotalMilliseconds > DATA_RECEIVE_DELAY_MS)
          {
            string data = _dataBuilder.ToString();
            _dataBuilder.Clear();

            if (RemoveEmptyLines && !string.IsNullOrEmpty(data))
            {
              string[] lines = data.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
              StringBuilder sb = new StringBuilder();

              foreach (string line in lines)
              {
                sb.AppendLine(line);
              }
              data = sb.ToString();
            }

            RawDataReceived?.Invoke(data);
          }
        }
        
        Thread.Sleep(1);
      }
    }

    private void _port_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      string data = _port.ReadExisting();
      _dataBuilder.Append(data);
      _lastRawDataReceiveTime = DateTime.Now;



      _lastRawDataReceiveTime = DateTime.Now;


      //RawDataReceived?.Invoke(data);
    }
  }
}
