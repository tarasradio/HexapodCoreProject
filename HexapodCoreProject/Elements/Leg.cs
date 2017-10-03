using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodCoreProject.Elements
{
    /// <summary>
    /// Описывает ногу робота (несколько сервоприводов и поведение)
    /// </summary>
    public class Leg
    {
        public string Name = "";
        public int Number = 0;

        public int tibiaID = -1; // самая дальняя часть ноги (вверх-вниз)
        public int femurID = -1; // средняя часть ноги (вверх-вниз)
        public int coxaID = -1; // основная часть ноги (влево-вправо)

        public Leg(int tibia, int femur, int coxa)
        {
            femurID = femur;
            tibiaID = tibia;
            coxaID = coxa;
        }
    }
}
