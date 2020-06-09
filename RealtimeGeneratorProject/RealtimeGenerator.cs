using HexapodInterfacesProject;
using RealtimeGeneratorProject.Core;

namespace RealtimeGeneratorProject
{
    public class RealtimeGenerator : AbstractGenerator, IMoveSource
    {
        public override string Name { get; } = "Realtime generator";

        private ILogger _logger;

        TrajectoryReceiver _receiver;

        public RealtimeGenerator(IRobot hexapod, ILogger logger) : base(logger)
        {
            _logger = logger;

            _receiver = new TrajectoryReceiver(hexapod, logger);
        }

        public void Run(int port)
        {
            if (_state == RUN_STATES.ENABLED)
            {
                _logger.AddMessage($"{Name} launched.");
                _receiver.Run(port);
            }
            else
            {
                _logger.AddMessage("Starting is not impossible: the source is inactive.");
            }
        }

        public void Terminate()
        {
            _receiver.Terminate();
            _logger.AddMessage($"{Name} executing has been interrupted.");
        }
    }
}
