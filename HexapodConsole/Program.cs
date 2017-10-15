using FrundGeneratorProject;
using HexapodCoreProject;
using HexapodCoreProject.Masters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodConsole
{
    class Program
    {
        public static HexapodInstance _hexapod;
        public static LogMaster _logMaster;
        public static HexapodConsoleConfig _consoleConfig;

        static void Main(string[] args)
        {
            _consoleConfig = HexapodConsoleConfig.ReadConfig();
            

            var arguments = new Arguments();
            if(CommandLine.Parser.Default.ParseArguments(args, arguments))
            {
                if (arguments.ConfigFile == null)
                    arguments.ConfigFile = Path.Combine(Utils.GetAppPath(), "config.json");


                try
                {
                    _hexapod = new HexapodInstance(arguments.ConfigFile);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Unable create hexapod instance:");
                    Console.WriteLine(ex.Message);

                    Console.ReadKey();
                    return;
                }

                _logMaster = new LogMaster();
                _logMaster.onNewMessageAdded += _logMaster_onNewMessageAdded;
                
                // Если указан ком-порт
                if (arguments.ComPortName != null)
                    _consoleConfig.ComPortName = arguments.ComPortName;

       
                if (arguments.DrivemagFile == null && arguments.Drivemags?.Count == 0)
                {
                    // Без аргументов
                    ShowPorts();
                }
                else if(arguments.DrivemagFile == null)
                {
                    // Система передала только имя файла
                    PlayDrivemag(arguments.Drivemags[0]);
                }
                else
                {
                    //Полная командная строка
                    PlayDrivemag(arguments.DrivemagFile);
                }

                _consoleConfig.SaveConfig();
            }
            else
            {
                Help();
            }

            Console.ReadKey();
        }

        
        static void ShowPorts()
        {
            List<String> portsNames = new List<string>();
            if (_hexapod.getSerialPortMaster().getOpenPorts(ref portsNames))
            {
                Console.WriteLine("Available COM-ports:");
                foreach (var com in portsNames)
                    Console.WriteLine(com);
            }
            else
                Console.WriteLine("No COM-ports available");
        }

        static void PlayDrivemag(string drivemag)
        {
            if (_consoleConfig.ComPortName == null)
            {
                Console.WriteLine("COM-port name required");
                Help();
                return;
            }
            
            try
            {
                _hexapod.getSerialPortMaster().Connect(_consoleConfig.ComPortName);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Unable to open connect to hexapod:");
                Console.WriteLine(ex.Message);
                return;
            }

            var frundGenerator = new FrundGenerator(_hexapod.getHexapod(), _logMaster);
            frundGenerator.Enable();
            frundGenerator.AddFile(drivemag);
            frundGenerator.startMove(0);
        }

        private static void _logMaster_onNewMessageAdded(string message)
        {
            Console.WriteLine(message);
        }

        private static void Help()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("HexapodConsole [-c <config.json] [-d <drivemag.txt>] [-p <com port>]");
            Console.WriteLine("COM-port name must be set in consoleconfig.json or by -p option");
            Console.WriteLine("Every time -p option set consoleconfig.json will be updated");
        }
    }
}
