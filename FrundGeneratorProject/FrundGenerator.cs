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
        enum RUN_STATES { RUN, TERMINATE };
        RUN_STATES currentRunState;

        string Name = "FRUND Generator";
        ILogMaster _logMaster;
        IRobot _hexapod;
        public FileStorage _fileStorage;

        FileRunner _runner;

        public FrundGenerator(IRobot hexapod, ILogMaster logMaster)
        {
            _hexapod = hexapod;
            _logMaster = logMaster;
            _fileStorage = new FileStorage();
            _runner = new FileRunner(hexapod, _fileStorage, logMaster);

            currentRunState = RUN_STATES.TERMINATE;
        }

        public string getName()
        {
            return this.Name;
        }

        public void Run()
        {
            _logMaster.addMessage("FRUND Genarator - Run");
            currentRunState = RUN_STATES.RUN;
        }

        public void Terminate()
        {
            _logMaster.addMessage("FRUND Genarator - Terminate");
            currentRunState = RUN_STATES.TERMINATE;
        }

        public FileStorage getStorage()
        {
            return _fileStorage;
        }

        // Запуск движения
        public void startMove(uint id)
        {
            if(currentRunState == RUN_STATES.RUN)
            {
                _logMaster.addMessage("Start Move From " +
                _fileStorage.fileList[id].Name);
                _runner.Run(id);
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
