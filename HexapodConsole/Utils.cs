using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodConsole
{
    public static class Utils
    {
        public static string GetAppPath()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            return Path.GetDirectoryName(path);
        }
    }
}
