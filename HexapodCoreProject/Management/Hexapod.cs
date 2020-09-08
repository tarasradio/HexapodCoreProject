using HexapodCoreProject.Elements;
using HexapodCoreProject.Interfaces;
using HexapodCoreProject.Masters;
using HexapodInterfacesProject;
using System.Collections.Generic;

namespace HexapodCoreProject.Management
{
    public class Hexapod : IRobot
    {
        private Logger logger;
        private Storage settings;
        private IPacketMaster packetMaster;

        public Hexapod(Storage storage, IPacketMaster packetMaster, Logger logger)
        {
            this.logger = logger;
            settings = storage;
            this.packetMaster = packetMaster;

            InitFromStorage();
        }

        public void InitFromStorage()
        {

        }
         
        public void JointSetAngle(int jointNumber, int angle, bool useOffset = true)
        {
            if (!settings.Settings.JointsToServosMap.ContainsKey(jointNumber)) return;

            int servoNumber = settings.Settings.JointsToServosMap[jointNumber];

            if (!settings.Settings.Servos.ContainsKey(servoNumber)) return;

            ServoSetAngle(servoNumber, angle, useOffset);
        }

        public void ServoSetAngle(int servoNumber, int angle, bool useOffset = true)
        {
            if(useOffset)
            {
                if (angle < settings.Settings.Servos[servoNumber].LowerLimit)
                    angle = settings.Settings.Servos[servoNumber].LowerLimit;
                if (angle > settings.Settings.Servos[servoNumber].UpperLimit)
                    angle = settings.Settings.Servos[servoNumber].UpperLimit;

                angle += settings.Settings.Servos[servoNumber].Offset;

                if (angle < 0)
                    angle = 0;

                if (angle > 180)
                    angle = 180;
            }

            if (settings.Settings.Servos[servoNumber].IsInverce)
                angle = 180 - angle;
            

            packetMaster.ServoSetAngle(servoNumber, angle);
        }
    }
}
