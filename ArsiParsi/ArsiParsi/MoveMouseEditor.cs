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
  public partial class MoveMouseEditor : UserControl, IActionParameters
  {
    public MoveMouseEditor()
    {
      InitializeComponent();
    }

    public string Parameters
    {
      get 
      {
        StringBuilder sb = new StringBuilder();

        if (radUL.Checked) sb.Append("UL");
        else if (radU.Checked) sb.Append("U");
        else if (radUR.Checked) sb.Append("UR");
        else if (radL.Checked) sb.Append("L");
        else if (radR.Checked) sb.Append("R");
        else if (radDL.Checked) sb.Append("DL");
        else if (radD.Checked) sb.Append("D");
        else if (radDR.Checked) sb.Append("DR");

        sb.AppendLine($"-{Convert.ToInt32(numPixels.Value)}");

        return sb.ToString();
      }
      set 
      {
      
        try
        {
          string[] parts = value.Split("-");

          switch (parts[0])
          {
            case "UL": radUL.Checked = true; break;
            case "U": radU.Checked = true; break;
            case "UR": radUR.Checked = true; break;
            case "L": radL.Checked = true; break;
            case "R": radR.Checked = true; break;
            case "DL": radDL.Checked = true; break;
            case "D": radD.Checked = true; break;
            case "DR": radDR.Checked = true; break;
          }

          numPixels.Value = int.Parse(parts[1]);
        }
        catch
        {
          radUL.Checked = true;
          numPixels.Value = 1;
        }
      }
    }
  }
}
