using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using HexapodCoreProject.Elements;

namespace HexapodCoreProject.Management
{
    public class Storage
    {
        StorageSettings settings;

        public Storage()
        {
            settings = new StorageSettings();
        }

        public bool OpenFile(string fileName)
        {
            string fileString = System.IO.File.ReadAllText(fileName);
            settings = JsonConvert.DeserializeObject<StorageSettings>(fileString);

            return true;
        }

        //сохранить файл настроек
        public void SaveFile(string FileName)
        {
            string fileString = JsonConvert.SerializeObject(settings, Formatting.Indented);
            System.IO.File.WriteAllText(FileName, fileString);
        }
    }
}
