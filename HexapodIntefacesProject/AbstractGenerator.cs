using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodInterfacesProject
{
    public abstract class AbstractGenerator : IMoveSource
    {
        protected enum RUN_STATES
        {
            ENABLED,
            DISABLED
        };

        protected RUN_STATES _state = RUN_STATES.DISABLED;

        protected ILogger _logger;

        public abstract string Name { get; }

        public AbstractGenerator(ILogger logger)
        {
            _logger = logger;
        }

        public void Enable()
        {
            _logger.AddMessage($"{Name} has been enabled.");
            _state = RUN_STATES.ENABLED;
        }

        public void Disable()
        {
            _logger.AddMessage($"{Name} has been disabled.");
            _state = RUN_STATES.DISABLED;
        }
    }
}
