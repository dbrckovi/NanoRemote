﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsiParsi
{
  [Serializable]
  public class RCAction
  {
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
      switch (ActionType)
      {
        case RCActionType.ConsoleCommand:
          {
            RunConsoleCommand(this.ActionParameters);
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
  }
}