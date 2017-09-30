using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodCoreProject.Elements
{
    /// <summary>
    /// Описывает сервопривод
    /// </summary>
    public class Servo
    {
        public string Name = "";
        public int Number = 0;
        public int Channel = 0;
        public int Angle = 0;
        public int Offset = 0;
        public bool isReverce = false;
        public int minAngle = 0;
        public int maxAngle = 0;
        public bool isEnable = true;

        public Servo(int number)
        {
            Number = number;
        }

        public Servo(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public Servo()
        {

        }
    }
}
