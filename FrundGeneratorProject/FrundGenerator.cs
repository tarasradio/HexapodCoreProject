using FrundGeneratorProject.Core;
using HexapodInterfacesProject;
using System.Collections.Generic;

namespace FrundGeneratorProject
{
    public class FrundGenerator : AbstractGenerator, IMoveSource 
    {
        private IFileRunner _runner;
        public List<FrundMoveFile> MoveFiles = new List<FrundMoveFile>();

        public override string  Name { get; } = "FRUND Generator";

        public FrundGenerator(IRobot hexapod, ILogger logger) : base(logger)
        {
            _runner = new FileRunner(hexapod, logger);
        }

        public bool AddFile(string fileName)
        {
            if (!System.IO.File.Exists(fileName))
                return false;

            FrundMoveFile file = new FrundMoveFile(fileName);
            MoveFiles.Add(file);

            return true;
        }

        // Запуск движения
        public void StartMove(int id)
        {
            if(_state == RUN_STATES.ENABLED)
            {
                _logger.AddMessage($"Movement from {MoveFiles[id].Title} launched.");
                _runner.Run(MoveFiles[id]);
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
