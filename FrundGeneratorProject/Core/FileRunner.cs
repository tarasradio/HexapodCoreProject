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
    public class FileRunner
    {
        FileStorage _storage;
        ILogMaster _logMaster;
        IRobot _robot;

        System.Timers.Timer _timer;

        static ulong _timeCounter;
        static uint _timeDelay;

        uint _currentFileID;
        int _currentMoveID;

        public FileRunner(IRobot robot, FileStorage storage, ILogMaster logMaster)
        {
            _robot = robot;
            _storage = storage;
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

        public void Run(uint fileId)
        {
            _currentFileID = fileId;
            _timeCounter = 0;
            _currentMoveID = 0;
            _timer.Start();

            _logMaster.addMessage("FRUND generator: Run Moves");
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

            if ((_currentMoveID + 2) >= _storage.fileList[_currentFileID].Moves.Count)
            {
                Terminate();
                return;
            }
                
            ulong moveTime = 
                _storage.fileList[_currentFileID].Moves[_currentMoveID++].Time;
            while(moveTime < time)
            {
                moveTime =
                _storage.fileList[_currentFileID].Moves[_currentMoveID++].Time;
            }
            while(moveTime <= time + _timeDelay*1000)
            {
                servoNumber = 
                    _storage.fileList[_currentFileID].Moves[_currentMoveID].ServoNumber;
                Angle =
                    _storage.fileList[_currentFileID].Moves[_currentMoveID].Angle;

                Console.WriteLine("FRUND generator: N = " + servoNumber.ToString());
                
                _robot.setAngle(servoNumber, Angle, true);

                moveTime =
                _storage.fileList[_currentFileID].Moves[_currentMoveID++].Time;
            }
        }
    }
}
