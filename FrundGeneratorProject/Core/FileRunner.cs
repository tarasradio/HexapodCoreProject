using HexapodInterfacesProject;
using System.Diagnostics;
using System.Threading;

namespace FrundGeneratorProject.Core
{
    class FileRunner : IFileRunner
    {
        private readonly ILogger _logMaster;
        private readonly IRobot _robot;
        private Thread _runThread;
        private bool _isRunning;

        public FileRunner(IRobot robot, ILogger logMaster)
        {
            _robot = robot;
            _logMaster = logMaster;
        }

        public void Run(FrundMoveFile move)
        {
            _runThread = new Thread(new ParameterizedThreadStart(running));
            
            _runThread.Start(move);
            _isRunning = true;
        }

        public void Terminate()
        {
            _runThread.Join();
            _isRunning = false;
        }

        private void running(object ofile)
        {
            var file = (FrundMoveFile)ofile;
            var watch = Stopwatch.StartNew();

            int i = 0;
            while (i < file.Frames.Count && _isRunning)
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

            _logMaster.AddMessage("FRUND Generator: Moving has been finished");
        }

        void ExecuteFrame(MoveFrame frame)
        {
            //_logMaster.addMessage($"FRUND generator: time = {frame.Time}");

            foreach(var move in frame.Moves)
                _robot.SetAngle(move.ServoNumber, move.Angle, true);
            
        }
    }
}
