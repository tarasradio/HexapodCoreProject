
using HexapodInterfacesProject;

namespace GateGeneratorProject
{
    public class GateGenerator : IMoveSource
    {
        ILogger _logMaster;
        IRobot _hexapod;

        Core.GateRunner _runner;

        enum RUN_STATES { ENABLED, DISABLED};
        RUN_STATES currentRunState;

        public string Name => "GATE Generator";

        public GateGenerator(IRobot hexapod, ILogger logMaster)
        {
            _hexapod = hexapod;
            _logMaster = logMaster;

            _runner = new Core.GateRunner(_hexapod);

            currentRunState = RUN_STATES.DISABLED;
        }


        public void Enable()
        {
            _logMaster.AddMessage("GATE Generator has been enabled.");
            currentRunState = RUN_STATES.ENABLED;
        }

        public void Disable()
        {
            _logMaster.AddMessage("GATE Generator has been disabled.");
            currentRunState = RUN_STATES.DISABLED;
        }

        public void startMoveForward()
        {
            if (currentRunState == RUN_STATES.ENABLED)
            {
                _logMaster.AddMessage("Movement forward launched.");
                _runner.Run();
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
