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
  public partial class frmSplash : Form
  {
    public frmSplash()
    {
      InitializeComponent();
    }

    private void frmSplash_Shown(object sender, EventArgs e)
    {
      Task.Run(DimAndClose);
    }

    private void DimAndClose()
    {
      DateTime startTime = DateTime.Now;

      for (double x = 0.1; x <= 1; x += 0.01)
      {
        this.Invoke(new Action(() => this.Opacity = x));
        Thread.Sleep(10);
      }

      for (double x = 1; x >= 0.01; x -= 0.01)
      {
        this.Invoke(new Action(() => this.Opacity = x));
        Thread.Sleep(10);
      }

      this.Invoke(new Action(() => this.Close()));
    }
  }
}
