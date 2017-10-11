using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrundGeneratorProject.Core
{
    /// <summary>
    /// Описывает одно изменение положения одного двигателя
    /// </summary>
    public class Move : ICloneable
    {
        public int ServoNumber { get; set; }
        public int Angle { get; set; }

        public Move(int servonumber, int angle)
        {
            this.ServoNumber = servonumber;
            this.Angle = angle;
        }

        public object Clone()
        {
            return new Move(ServoNumber, Angle);
        }
    }
}
