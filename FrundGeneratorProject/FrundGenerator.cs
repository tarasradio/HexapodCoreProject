using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FrundGeneratorProject.Core;
using HexapodInterfacesProject;

namespace FrundGeneratorProject
{
    public class FrundGenerator : IMoveSource
    {
        enum RUN_STATES
        {
            ENABLED,
            DISABLED
        };

        private  RUN_STATES currentRunState;
        private readonly ILogger _logMaster;
        private readonly IFileRunner _runner;
        private readonly IRobot _hexapod;
        public List<FrundMoveFile> MoveFiles;
        

        public string Name => "FRUND Generator";

        public FrundGenerator(IRobot hexapod, ILogger logMaster)
        {
            _hexapod = hexapod;
            _logMaster = logMaster;
            MoveFiles = new List<FrundMoveFile>();

            _runner = new FileRunner(hexapod, logMaster);

            currentRunState = RUN_STATES.DISABLED;
        }


        // Считывает новый файл
        public bool AddFile(string fileName)
        {
            if (!System.IO.File.Exists(fileName))
                return false;

            FrundMoveFile file = new FrundMoveFile(fileName);
            MoveFiles.Add(file);
            return true;
        }


        public void Enable()
        {
            _logMaster.AddMessage("FRUND Generator has been enabled.");
            currentRunState = RUN_STATES.ENABLED;
        }

        public void Disable()
        {
            _logMaster.AddMessage("FRUND Generator has been disabled.");
            currentRunState = RUN_STATES.DISABLED;
        }

        // Запуск движения
        public void startMove(int id)
        {
            if(currentRunState == RUN_STATES.ENABLED)
            {
                _logMaster.AddMessage($"Movement from {MoveFiles[id].Title} launched.");
                _runner.Run(MoveFiles[id]);
            }
            else
            {
                _logMaster.AddMessage("Starting is not impossible: the source is inactive.");
            }
            
        }

        // Остановка движения
        public void stopMove()
        {
            _logMaster.AddMessage("The movement has been interrupted.");
            _runner.Terminate();
        }

    }
   
}
