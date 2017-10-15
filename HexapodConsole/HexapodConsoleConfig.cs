using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodConsole
{
    public class HexapodConsoleConfig
    {
        private static string CONFIG_NAME = Path.Combine(Utils.GetAppPath(), "consoleconfig.json");
        public string ComPortName { get; set; }

        public static HexapodConsoleConfig ReadConfig()
        {
            if (!File.Exists(CONFIG_NAME))
                return Default;

            string json = File.ReadAllText(CONFIG_NAME);
            return JsonConvert.DeserializeObject<HexapodConsoleConfig>(json);
        }

        public void SaveConfig()
        {
            string json = JsonConvert.SerializeObject(this, Formatting.Indented);
            File.WriteAllText(CONFIG_NAME, json);
        }

        public static HexapodConsoleConfig Default => new HexapodConsoleConfig()
        {
            ComPortName = null
        };
        
    }
}
