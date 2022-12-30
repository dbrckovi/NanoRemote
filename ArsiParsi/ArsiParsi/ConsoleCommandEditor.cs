using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArsiParsi
{
  public partial class ConsoleCommandEditor : UserControl, IActionParameters
  {
    public ConsoleCommandEditor()
    {
      InitializeComponent();
    }

    public string Parameters
    {
      get { return txtCommand.Text; }
      set { txtCommand.Text = value; }
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
      try
      {
        RCAction.RunConsoleCommand(txtCommand.Text);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
