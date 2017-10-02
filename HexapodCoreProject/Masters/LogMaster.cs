using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using System.IO;

using HexapodInterfacesProject;

namespace HexapodCoreProject.Masters
{
    public class LogMaster : ILogMaster
    {
        public delegate void newMessageHandler(string message);
        public event newMessageHandler onNewMessageAdded;
        
        private string fileName;

        public LogMaster()
        {
            fileName = "Log_" + DateTime.Now.ToString("dd_MM_yyyy_#_HH_mm_ss") + ".txt";
        }

        public void addMessage(string text)
        {
            StreamWriter writer = new StreamWriter(fileName, true);

            string line = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") +
                " - " + text + "\n";

            writer.WriteLine(line);
            writer.Close();

            onNewMessageAdded?.Invoke(line);
        }
    }
}
