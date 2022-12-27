using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ArsiParsi
{
  internal class RCReceiver : IDisposable
  {
    SerialPort _port;
    private bool disposedValue;

    public RCReceiver(string serialPortName, int baudRate)
    {
      _port = new SerialPort(serialPortName, baudRate);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (!disposedValue)
      {
        if (disposing)
        {
          if (_port != null && _port.IsOpen) _port.Close();
        }

        disposedValue = true;
      }
    }

    public void Dispose()
    {
      Dispose(disposing: true);
      GC.SuppressFinalize(this);
    }
  }
}
