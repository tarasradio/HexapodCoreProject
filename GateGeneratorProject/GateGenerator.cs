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
        ILogMaster _logMaster;
        IRobot _hexapod;

        Core.GateRunner _runner;

        enum RUN_STATES { ENABLED, DISABLED};
        RUN_STATES currentRunState;

        public string Name => "GATE Generator";

        public GateGenerator(IRobot hexapod, ILogMaster logMaster)
        {
            _hexapod = hexapod;
            _logMaster = logMaster;

            _runner = new Core.GateRunner(_hexapod);

            currentRunState = RUN_STATES.DISABLED;
        }


        public void Enable()
        {
            _logMaster.addMessage("GATE Genarator - Enable");
            currentRunState = RUN_STATES.ENABLED;
        }

        public void Disable()
        {
            _logMaster.addMessage("GATE Genarator - Disable");
            currentRunState = RUN_STATES.DISABLED;
        }

        public void startMoveForward()
        {
            if (currentRunState == RUN_STATES.ENABLED)
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
