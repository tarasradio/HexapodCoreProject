using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HexapodInterfacesProject;

namespace GateGeneratorProject.Core
{
    public class GateRunner
    {

        IRobot _robot;

        System.Timers.Timer _timer;

        static ulong _timeCounter;
        static uint _timeDelay;

        static uint stepCounter;
        const uint stepCount = 8;

        public GateRunner(IRobot robot)
        {
            _robot = robot;
            _timer = new System.Timers.Timer();
            _timeDelay = 200;
            _timer.Interval = _timeDelay;
            _timer.Elapsed += timerElapsedHandler; ;
            _timeCounter = 0;
            stepCounter = 1;
        }

        private void timerElapsedHandler(object sender, System.Timers.ElapsedEventArgs e)
        {
            _timeCounter += _timeDelay;
            executeMoves(_timeCounter);
        }

        /// <summary>
        /// Выполнение движений для текущего момента времени
        /// </summary>
        /// <param name="time">Прошедшее время (мс)</param>
        private void executeMoves(ulong time)
        {
            nextStepForward(stepCounter);

            if (stepCounter <= stepCount)
                stepCounter++;
            else
                stepCounter = 1;
        }

        public void nextStepForward(uint step)
        {
            switch(step)
            {
                case 1:
                    {
                        _robot.setCoxaAngle(1, 40);
                        _robot.setCoxaAngle(5, 100);
                        _robot.setCoxaAngle(4, 70);
                    }
                    break;
                case 2:
                    {
                        _robot.setFemurAngle(1, 90);
                        _robot.setFemurAngle(5, 90);
                        _robot.setFemurAngle(4, 90);
                    }
                    break;
                case 3:
                    {
                        _robot.setFemurAngle(3, 60);
                        _robot.setFemurAngle(2, 120);
                        _robot.setFemurAngle(6, 120);

                    }
                    break;
                case 4:
                    {
                        _robot.setCoxaAngle(1, 60);
                        _robot.setCoxaAngle(5, 120);
                        _robot.setCoxaAngle(4, 90);
                    }
                    break;
                case 5:
                    {
                        _robot.setCoxaAngle(3, 110);
                        _robot.setCoxaAngle(2, 100);
                        _robot.setCoxaAngle(6, 40);

                    }
                    break;
                case 6:
                    {
                        _robot.setFemurAngle(3, 90);
                        _robot.setFemurAngle(2, 90);
                        _robot.setFemurAngle(6, 90);

                    }
                    break;
                case 7:
                    {
                        _robot.setFemurAngle(1, 60);
                        _robot.setFemurAngle(5, 60);
                        _robot.setFemurAngle(4, 120);

                    }
                    break;
                case 8:
                    {
                        _robot.setCoxaAngle(3, 90);
                        _robot.setCoxaAngle(2, 120);
                        _robot.setCoxaAngle(6, 60);

                    }
                    break;
            }
        }

            public void Run()
        {
            _robot.setAllTibiaAngle(90);
            _robot.setAllFemurAngle(90);

            _timeCounter = 0;
            stepCounter = 1;
            _timer.Start();
            

            //_logMaster.addMessage("GATE generator: Enable Moves");
        }

        public void Terminate()
        {
            _timer.Stop();
            _timer.Close();
            //_logMaster.addMessage("GATE generator: Stop Moves");
        }
    }
}
