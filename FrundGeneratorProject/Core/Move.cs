using System;

namespace FrundGeneratorProject.Core
{
    /// <summary>
    /// Описывает одно изменение положения одного двигателя
    /// </summary>
    public class Move : ICloneable
    {
        public int ServoNumber { get; set; }
        public int Angle { get; set; }

        public Move(int servoNumber, int angle)
        {
            ServoNumber = servoNumber;
            Angle = angle;
        }

        public object Clone()
        {
            return new Move(ServoNumber, Angle);
        }
    }
}
