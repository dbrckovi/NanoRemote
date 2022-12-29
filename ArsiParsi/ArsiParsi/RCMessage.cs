using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsiParsi
{
  public class RCMessage
  {
    public string Protocol { get; set; }
    public int Address { get; set; }
    public int Command { get; set; }
    public bool Toggle { get; set; }
    public string RawData { get; set; }
    public int RepeatGapMicroSeconds { get; set; }

    public RCMessage(string data)
    {
      //replace human readable stirng with short codes, so it's easier to parse
      data = data.Replace("Protocol", "P").Replace("Address", "A").Replace("Command", "C").Replace("Toggle", "T").Replace("Repeat gap", "R");

      #region Extract and delete Raw-Data
      //this assumes 'Raw-Data=...' is always at th end of the message
      int rawDataIndex = data.IndexOf("Raw-Data=");
      if (rawDataIndex >= 0)
      {
        string rawData = data.Substring(rawDataIndex);
        string[] keyValue = rawData.Split('=');
        RawData = keyValue[1];

        data = data.Substring(0, rawDataIndex);
      }
      #endregion Extract and delete Raw-Data

      string[] parts = data.Split(' ', StringSplitOptions.RemoveEmptyEntries);

      foreach (string part in parts)
      {
        string[] keyValue = part.Split('=');
        string key = keyValue[0];
        string value = keyValue[1];

        switch (key)
        {
          case "P":
            {
              Protocol = value;
              break;
            }
          case "A":
            {
              Address = Convert.ToInt32(value, 16);
              break;
            }
          case "C":
            {
              Command = Convert.ToInt32(value, 16);
              break;
            }
          case "T":
            {
              Toggle = value == "1";
              break;
            }
          case "R":
            {
              RepeatGapMicroSeconds = ParseMicroSeceonds(value);
              break;
            }
        }
      }
    }

    private int ParseMicroSeceonds(string value)
    {
      value = value.Replace("us", "");
      return int.Parse(value);
    }
  }
}
