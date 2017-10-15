using HexapodInterfacesProject;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FrundGeneratorProject.Core
{
    class FileRunner2 : IFileRunner
    {
        private readonly ILogMaster _logMaster;
        private readonly IRobot _robot;
        private Thread _runThread;
        private bool _isRunning;

        public FileRunner2(IRobot robot, ILogMaster logMaster)
        {
            _robot = robot;
            _logMaster = logMaster;
        }

        public void Run(FrundMoveFile move)
        {
            _runThread = new Thread(new ParameterizedThreadStart(Running));
            _isRunning = true;
            _runThread.Start(move);
        }

        public void Terminate()
        {
            _isRunning = false;
            _runThread.Join();
        }

        private void Running(object ofile)
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

            _logMaster.addMessage("FRUND generator: move ended");
        }

        void ExecuteFrame(MoveFrame frame)
        {
            _logMaster.addMessage($"FRUND generator: time = {frame.Time}");

            foreach(var move in frame.Moves)
                _robot.setAngle(move.ServoNumber, move.Angle, true);
            
        }
    }
}
