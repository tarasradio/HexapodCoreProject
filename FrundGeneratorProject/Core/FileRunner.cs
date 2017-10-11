using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using HexapodInterfacesProject;

namespace FrundGeneratorProject.Core
{
    /// <summary>
    /// Непосредственно проигрывает файл с движениями
    /// </summary>
    public class FileRunner : IFileRunner
    {
        readonly ILogMaster _logMaster;
        readonly IRobot _robot;
        readonly System.Timers.Timer _timer;

        static ulong _timeCounter;
        static uint _timeDelay;

        int _currentMoveID;

        private FrundMoveFile _currentMove;

        public FileRunner(IRobot robot, ILogMaster logMaster)
        {
            _robot = robot;
            _logMaster = logMaster;
            _timer = new System.Timers.Timer();
            _timeDelay = 100;
            _timer.Interval = _timeDelay;
            _timer.Elapsed += TimerElapsedHandler;
            _timeCounter = 0;
            _currentMoveID = 0;
        }

        private void TimerElapsedHandler(object sender, System.Timers.ElapsedEventArgs e)
        {
            _timeCounter += _timeDelay * 1000;
            executeMoves(_timeCounter);
        }

        public void Run(FrundMoveFile move)
        {
            _currentMove = move;
            _timeCounter = 0;
            _currentMoveID = 0;
            _timer.Start();

            _logMaster.addMessage("FRUND generator: Enable Moves");
        }

        public void Terminate()
        {
            _timer.Stop();
            _timer.Close();
            _logMaster.addMessage("FRUND generator: Stop Moves");
        }

        /// <summary>
        /// Выполнение движений для текущего момента времени
        /// </summary>
        /// <param name="time">Прошедшее время (мс)</param>
        private void executeMoves(ulong time)
        {
            //Console.WriteLine("FRUND generator: time = " + time.ToString());
            _logMaster.addMessage("FRUND generator: time = " + time.ToString());

            int servoNumber, Angle;

            if ((_currentMoveID + 2) >= _currentMove.Moves.Count)
            {
                Terminate();
                return;
            }
                
            ulong moveTime = _currentMove.Moves[_currentMoveID++].Time;
            while(moveTime < time)
            {
                moveTime = _currentMove.Moves[_currentMoveID++].Time;
            }
            while(moveTime <= time + _timeDelay*1000)
            {
                servoNumber = _currentMove.Moves[_currentMoveID].ServoNumber;
                Angle = _currentMove.Moves[_currentMoveID].Angle;

                Console.WriteLine("FRUND generator: N = " + servoNumber.ToString());
                
                _robot.setAngle(servoNumber, Angle, true);

                moveTime = _currentMove.Moves[_currentMoveID++].Time;
            }
        }
    }
}
