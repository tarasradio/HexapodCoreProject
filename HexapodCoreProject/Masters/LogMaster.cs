using HexapodInterfacesProject;
using System;
using System.IO;

namespace HexapodCoreProject.Masters
{
    public class Logger : ILogger
    {
        public delegate void newMessageHandler(string message);
        public event newMessageHandler OnNewMessageAdded;
        
        private string fileName;

        public Logger()
        {
            fileName = "Log_" + DateTime.Now.ToString("dd_MM_yyyy_#_HH_mm_ss") + ".txt";
        }

        public void AddMessage(string text)
        {
            StreamWriter writer = new StreamWriter(fileName, true);

            string line = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") +
                " - " + text + "\n";

            writer.WriteLine(line);
            writer.Close();

            OnNewMessageAdded?.Invoke(line);
        }
    }
}
