
using HexapodCoreProject.Elements;
using Newtonsoft.Json;
using System;

namespace HexapodCoreProject.Management
{
    public class Storage
    {
        public HexapodSettings Settings { get; set; }

        public Storage()
        {
            Settings = new HexapodSettings();
        }

        public void OpenFile(string fileName)
        {
            try
            {
                string fileString = System.IO.File.ReadAllText(fileName);
                Settings = JsonConvert.DeserializeObject<HexapodSettings>(fileString);
            }
            catch(Exception)
            {
                Settings = new HexapodSettings();
                GenerateDefaultSettings();
            }
        }
        
        private void GenerateDefaultSettings()
        {
            for (int i = 1; i <= 18; i++)
            {
                Settings.Servos.Add(i, new Servo() { Name = "Servo", Number = i});
                Settings.JointsToServosMap.Add(i, i);
            }
        }

        public void SaveFile(string fileName)
        {
            string fileString = JsonConvert.SerializeObject(Settings, Formatting.Indented);
            System.IO.File.WriteAllText(fileName, fileString);
        }
    }
}
