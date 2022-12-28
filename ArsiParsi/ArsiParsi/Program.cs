namespace ArsiParsi
{
  internal static class Program
  {
    public static readonly string ConfigDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "ArsiParsi");

    [STAThread]
    static void Main()
    {
      try
      {
        Config c = Config.Instance;   //load config

        ApplicationConfiguration.Initialize();
        Application.Run(new frmMain());
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }
  }
}