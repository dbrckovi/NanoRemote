using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ArsiParsi
{
  [Serializable]
  public class RCAction
  {
    private DateTime? _lastExecuted = null;

    public string Name { get; set; }

    //filter
    public string Protocol { get; set; }
    public int? Address { get; set; }
    public int? Command { get; set; }
    public bool? Toggle { get; set; }
    public bool? Repeat { get; set; }

    //action
    public RCActionType ActionType { get; set; } = RCActionType.ConsoleCommand;
    public string ActionParameters { get; set; }
    public int DelayAfterExecution { get; set; } = 0;

    public bool IsInDelayPeriod
    {
      get
      {
        return _lastExecuted.HasValue && (DateTime.Now - _lastExecuted.Value).TotalMilliseconds < DelayAfterExecution;
      }
    }

    public bool MatchesMessage(RCMessage message)
    {
      if (message == null) return false;

      if (!string.IsNullOrEmpty(Protocol) && Protocol != message.Protocol) return false;
      if (Address.HasValue && Address != message.Address) return false;
      if (Command.HasValue && Command != message.Command) return false;
      if (Toggle.HasValue && Toggle != message.Toggle) return false;
      if (Repeat.HasValue && Repeat.Value != (message.RepeatGapMicroSeconds > 0)) return false;

      return true;
    }

    public void ExecuteAction()
    {
      _lastExecuted = DateTime.Now;

      switch (ActionType)
      {
        case RCActionType.ConsoleCommand:
          {
            RunConsoleCommand(this.ActionParameters);
            break;
          }
        case RCActionType.SendKeys:
          {
            SendKeys.Send(this.ActionParameters);
            break;
          }
        case RCActionType.MouseMove:
          {
            MoveMouse(this.ActionParameters);
            break;
          }
      }
    }

    public static void RunConsoleCommand(string command)
    {
      System.Diagnostics.ProcessStartInfo proc = new System.Diagnostics.ProcessStartInfo();
      proc.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
      proc.CreateNoWindow = true;
      proc.FileName = "cmd.exe";
      proc.Arguments = $"/C {command}";
      System.Diagnostics.Process.Start(proc);
    }

    /// <summary>
    /// Parses parameters string and moves mouse in specified direction
    /// </summary>
    /// <param name="parameters"></param>
    public static void MoveMouse(string parameters)
    {
      string[] parts = parameters.Split("-");

      int distance = int.Parse(parts[1]);
      int x = 0;
      int y = 0;

      if (parts[0].Length == 2) distance = Convert.ToInt32((double)distance / Math.Sqrt(2));

      if (parts[0].Contains("U")) y = -distance;
      if (parts[0].Contains("D")) y = distance;
      if (parts[0].Contains("L")) x = -distance;
      if (parts[0].Contains("R")) x = distance;

      Cursor.Position = new Point(Cursor.Position.X + x, Cursor.Position.Y + y);
    }
  }
}
