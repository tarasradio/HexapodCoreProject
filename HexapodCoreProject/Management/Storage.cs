
using HexapodCoreProject.Elements;
using Newtonsoft.Json;

namespace HexapodCoreProject.Management
{
    public class Storage
    {
        public StorageSettings Settings { get; set; }

        public Storage()
        {
            Settings = new StorageSettings();
        }

        public bool OpenFile(string fileName)
        {
            string fileString = System.IO.File.ReadAllText(fileName);
            Settings = JsonConvert.DeserializeObject<StorageSettings>(fileString);

            return true;
        }
        
        public void SaveFile(string FileName)
        {
            string fileString = JsonConvert.SerializeObject(Settings, Formatting.Indented);
            System.IO.File.WriteAllText(FileName, fileString);
        }
    }
}
