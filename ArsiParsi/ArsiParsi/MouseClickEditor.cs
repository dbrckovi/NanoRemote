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
  public partial class MouseClickEditor : UserControl, IActionParameters
  {
    public MouseClickEditor()
    {
      InitializeComponent();
    }

    public string Parameters
    {
      get 
      {
        if (radClick.Checked) return MouseEvents.LEFT_CLICK;
        else if (radDoubleClick.Checked) return MouseEvents.DOUBLE_CLICK;
        else if (radRightClick.Checked) return MouseEvents.RIGHT_CLICK;
        else if (radLeftDown.Checked) return MouseEvents.LEFT_DOWN;
        else if (radLeftUp.Checked) return MouseEvents.LEFT_UP;
        else if (radMiddleDown.Checked) return MouseEvents.MIDDLE_DOWN;
        else if (radMiddleUp.Checked) return MouseEvents.MIDDLE_UP;
        else if (radRightDown.Checked) return MouseEvents.RIGHT_DOWN;
        else if (radRightUp.Checked) return MouseEvents.RIGHT_UP;
        else return "";
      }
      set 
      { 
        switch (value)
        {
          case MouseEvents.LEFT_CLICK: radClick.Checked = true; break;
          case MouseEvents.DOUBLE_CLICK: radDoubleClick.Checked = true; break;
          case MouseEvents.RIGHT_CLICK: radRightClick.Checked = true; break;
          case MouseEvents.LEFT_DOWN: radLeftDown.Checked = true; break;
          case MouseEvents.LEFT_UP: radLeftUp.Checked = true; break;
          case MouseEvents.MIDDLE_DOWN: radMiddleDown.Checked = true; break;
          case MouseEvents.MIDDLE_UP: radMiddleUp.Checked = true; break;
          case MouseEvents.RIGHT_DOWN: radRightDown.Checked = true; break;
          case MouseEvents.RIGHT_UP: radRightUp.Checked = true; break;
          default: radClick.Checked = true; break;
        }
      }
    }
  }
}
