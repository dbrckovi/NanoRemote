using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArsiParsi
{
  public partial class SendKeysEditor : UserControl, IActionParameters
  {
    public SendKeysEditor()
    {
      InitializeComponent();
    }

    public string Parameters
    {
      get { return txtSendKeys.Text; }
      set { txtSendKeys.Text = value; }
    }

    private void lnkInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      try
      {
        string url = "https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.sendkeys.send?redirectedfrom=MSDN&view=windowsdesktop-7.0#System_Windows_Forms_SendKeys_Send_System_String_";
        
        ProcessStartInfo info = new ProcessStartInfo();
        info.FileName = url;
        info.UseShellExecute = true;
        Process.Start(info);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btnTest_Click(object sender, EventArgs e)
    {
      try
      {
        SendKeys.Send(txtSendKeys.Text);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
  }
}
