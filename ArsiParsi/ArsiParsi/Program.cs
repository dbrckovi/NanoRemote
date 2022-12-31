namespace ArsiParsi
{
  internal static class Program
  {
    public static readonly string ConfigDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData), "ArsiParsi");
    public static bool RunTime = false;

    [STAThread]
    static void Main()
    {
      RunTime = true;
      try
      {
        if (!Directory.Exists(ConfigDirectory)) Directory.CreateDirectory(ConfigDirectory);

        Config c = Config.Instance;   //triggers config to load or be created

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