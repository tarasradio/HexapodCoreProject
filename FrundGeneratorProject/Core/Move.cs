using System;

namespace FrundGeneratorProject.Core
{
    /// <summary>
    /// Описывает одно изменение положения одного двигателя
    /// </summary>
    public class Move : ICloneable
    {
        public int JointNumber { get; set; }
        public int Angle { get; set; }

        public Move(int servoNumber, int angle)
        {
            JointNumber = servoNumber;
            Angle = angle;
        }

        public object Clone()
        {
            return new Move(JointNumber, Angle);
        }
    }
}
