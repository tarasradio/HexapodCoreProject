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

            foreach(var frame in file.Frames)
            {
                if (!_isRunning)
                    return;

                int currentTime =  watch.Elapsed.Milliseconds;
                int delay = (frame.Time / 1000)- currentTime ;// TODO: int & ulong

                if(delay > 0)
                    Thread.Sleep(delay);

                ExecuteFrame(frame);
            }
        }

        void ExecuteFrame(MoveFrame frame)
        {
            foreach(var move in frame.Moves)
            {
                _robot.setAngle(move.ServoNumber, move.Angle, true);
            }
        }
    }
}
