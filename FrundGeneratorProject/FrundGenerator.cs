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
        private readonly ILogMaster _logMaster;
        private readonly IFileRunner _runner;
        private readonly IRobot _hexapod;
        public List<FrundMoveFile> MoveFiles;
        

        public string Name => "FRUND Generator";

        public FrundGenerator(IRobot hexapod, ILogMaster logMaster)
        {
            _hexapod = hexapod;
            _logMaster = logMaster;
            MoveFiles = new List<FrundMoveFile>();

            _runner = new FileRunner2(hexapod, logMaster);

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
            _logMaster.addMessage("FRUND Genarator - Enable");
            currentRunState = RUN_STATES.ENABLED;
        }

        public void Disable()
        {
            _logMaster.addMessage("FRUND Genarator - Disable");
            currentRunState = RUN_STATES.DISABLED;
        }

        // Запуск движения
        public void startMove(int id)
        {
            if(currentRunState == RUN_STATES.ENABLED)
            {
                _logMaster.addMessage($"Start Move From {MoveFiles[id].Title}");
                _runner.Run(MoveFiles[id]);
            }
            else
            {
                _logMaster.addMessage("Запуск невозможен: источник не активен");
            }
            
        }

        // Остановка движения
        public void stopMove()
        {
            _logMaster.addMessage("Stop Move");
            _runner.Terminate();
        }

    }
   
}
