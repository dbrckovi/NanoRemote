using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ArsiParsi
{
  public class Config
  {
    private static string _path = Path.Combine(Program.ConfigDirectory, "ArsiParsi.cfg");

    private static JsonSerializerOptions _options = new JsonSerializerOptions()
    {
      WriteIndented = true
    };

    #region Singleton
    private static Config _instance;
    public static Config Instance
    {
      get
      {
        if (_instance == null) _instance = Load();
        return _instance;
      }
    }
    #endregion Singleton

    public string ComPort { get; set; }
    public bool ShowSplash { get; set; } = true;

    public List<RCAction> Actions { get; set; } = new List<RCAction>();
   
    public void Save()
    {
      if (File.Exists(_path)) File.Delete(_path);
      string content = JsonSerializer.Serialize(this, typeof(Config), _options);
      File.WriteAllText(_path, content);
    }

    public static Config Load()
    {
      Config ret;

      if (!File.Exists(_path))
      {
        ret = new Config();
        ret.Save();
      }
      else
      {
        string content = File.ReadAllText(_path);
        ret = JsonSerializer.Deserialize<Config>(content, _options);
      }

      return ret;
    }

    private static void SerializeValue<T>(string key, T value, StringBuilder sb)
    {
      string serialized = "";
      if (value is string) serialized = (string)Convert.ChangeType(value, typeof(string));

      sb.AppendLine($"{key}={serialized}");
    }
  }
}
