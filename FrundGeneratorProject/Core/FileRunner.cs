using HexapodInterfacesProject;
using System.Diagnostics;
using System.Threading;

namespace FrundGeneratorProject.Core
{
    class FileRunner : IFileRunner
    {
        private readonly ILogger logger;
        private readonly IRobot hexapod;
        private Thread thread;
        private bool isRunning;

        public FileRunner(IRobot hexapod, ILogger logger)
        {
            this.hexapod = hexapod;
            this.logger = logger;
        }

        public void Run(FrundMoveFile move)
        {
            thread = new Thread(new ParameterizedThreadStart(ExecuteFrames));
            
            thread.Start(move);
            isRunning = true;
        }

        public void Terminate()
        {
            thread.Join();
            isRunning = false;
        }

        private void ExecuteFrames(object ofile)
        {
            var file = (FrundMoveFile)ofile;
            var watch = Stopwatch.StartNew();

            int i = 0;
            while (i < file.Frames.Count && isRunning)
            {
                long currentTime = watch.ElapsedMilliseconds;

                // Пропускаем опоздавшие фреймы
                int delay = (int)(file.Frames[i].Time / 1000 - currentTime);

                if (delay < 0)
                {
                    while ((i < file.Frames.Count) && (file.Frames[i].Time / 1000 < currentTime))
                        i++;

                    if(i >= file.Frames.Count)
                        break;
                }
                else
                {
                    // Ждем, если задержка большая
                    Thread.Sleep(delay);
                }

                ExecuteFrame(file.Frames[i]);
            }

            logger.AddMessage("FRUND Generator: Moving has been finished");
        }

        void ExecuteFrame(MoveFrame frame)
        {
            //_logMaster.addMessage($"FRUND generator: time = {frame.Time}");

            foreach(var move in frame.Moves)
                hexapod.JointSetAngle(move.JointNumber, move.Angle, true);
        }
    }
}
