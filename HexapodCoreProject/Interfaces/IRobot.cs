using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodCoreProject.Interfaces
{
    public interface IRobot
    {
        void setAngle(int servoNumber, int angle, bool useOffset);
        void setTibiaAngle(int legID, int angle);
        void setFemurAngle(int legID, int angle);
        void setCoxaAngle(int legID, int angle);
        void setAllTibiaAngle(int angle);
        void setAllFemurAngle(int angle);
        void setAllCoxaAngle(int angle);
    }
}
