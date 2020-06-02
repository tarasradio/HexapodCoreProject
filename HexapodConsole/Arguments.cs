using CommandLine;
using System.Collections.Generic;


namespace HexapodConsole
{
    /// <summary>
    /// Аргументы командной строки
    /// </summary>
    public class Arguments
    {
        [Option('c',"config", Required = false, HelpText = "config.json file")]
        public string ConfigFile { get; set; }
        
        [Option('d', "drivemag", Required = false, HelpText = "DRIVEMAG file")]
        public string DrivemagFile { get; set; }

        [Option('p', "port", Required = false, HelpText = "COM-port name")]
        public string ComPortName { get; set; }

        [ValueList(typeof(List<string>), MaximumElements = 1)]
        public IList<string> Drivemags { get; set; }
    }
}
