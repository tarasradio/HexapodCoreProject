
using HexapodInterfacesProject;

namespace GateGeneratorProject
{
    public class WTFGateGenerator : AbstractGenerator, IMoveSource
    {
        Core.GateRunner _runner;

        public override string Name { get; } = "WTF gate generator";

        public WTFGateGenerator(IRobot hexapod, ILogger logger) : base(logger)
        {
            _runner = new Core.GateRunner(hexapod);
        }

        public void StartMoveForward()
        {
            if (_state == RUN_STATES.ENABLED)
            {
                _logger.AddMessage("Movement forward launched.");
                _runner.Run();
            }
            else
            {
                _logger.AddMessage("Starting is not impossible: the source is inactive.");
            }

        }

        // Остановка движения
        public void StopMove()
        {
            _logger.AddMessage("The movement has been interrupted.");
            _runner.Terminate();
        }
    }
}
