using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrundGeneratorProject.Core
{
    /// <summary>
    /// Положение всех приводов в момент времени
    /// </summary>
    public class MoveFrame
    {
        /// <summary>
        ///  Время (в мкс)
        /// </summary>
        public int Time { get; set; }

        /// <summary>
        /// Список положений приводов
        /// </summary>
        public IList<Move> Moves { get; set; }
        

        public MoveFrame()
        {
            Moves = new List<Move>();
        }

        public MoveFrame(int time):this()
        {
            Time = time;
        }

        public void AddMove(Move move)
        {
            Moves.Add(move);
        }

        public void AddMove(int servonumber, int angle)
        {
            Moves.Add(new Move(servonumber, angle));
        }
    }
}
