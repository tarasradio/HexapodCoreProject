using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HexapodInterfacesProject;

namespace GateGeneratorProject
{
    public class GateGenerator : IMoveSource
    {
        string Name = "GATE Generator";
        ILogMaster _logMaster;
        IRobot _hexapod;

        Core.GateRunner _runner;

        enum RUN_STATES { RUN, TERMINATE};
        RUN_STATES currentRunState;

        public GateGenerator(IRobot hexapod, ILogMaster logMaster)
        {
            _hexapod = hexapod;
            _logMaster = logMaster;

            _runner = new Core.GateRunner(_hexapod);

            currentRunState = RUN_STATES.TERMINATE;
        }

        public string getName()
        {
            return this.Name;
        }

        public void Run()
        {
            _logMaster.addMessage("GATE Genarator - Run");
            currentRunState = RUN_STATES.RUN;
        }

        public void Terminate()
        {
            _logMaster.addMessage("GATE Genarator - Terminate");
            currentRunState = RUN_STATES.TERMINATE;
        }

        public void startMoveForward()
        {
            if (currentRunState == RUN_STATES.RUN)
            {
                _logMaster.addMessage("Start Move Forward");
                _runner.Run();
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
