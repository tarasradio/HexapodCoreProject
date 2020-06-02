using HexapodCoreProject.Elements;
using HexapodCoreProject.Interfaces;
using HexapodCoreProject.Masters;
using HexapodInterfacesProject;
using System.Collections.Generic;

namespace HexapodCoreProject.Management
{
    public class Hexapod : IRobot
    {
        private LogMaster _logMaster;
        private Storage _storage;
        private IPacketMaster _packetMaster;

        public Dictionary<int, Leg> legs;

        public Hexapod(Storage storage, IPacketMaster packetMaster, LogMaster logMaster)
        {
            _logMaster = logMaster;
            _storage = storage;
            _packetMaster = packetMaster;

            legs = new Dictionary<int, Leg>();
            initFromStorage();
        }

        public void initFromStorage()
        {
            legs = _storage.Settings.Legs;
        }
         
        public void SetAngle(int servoNumber, int angle, bool useOffset = true)
        {
            WriteAngle(servoNumber, angle, useOffset);
        }

        public void SetTibiaAngle(int legID, int angle)
        {
            int servoNumber = legs[legID].tibiaID;
            WriteAngle(servoNumber, angle);
        }

        public void SetFemurAngle(int legID, int angle)
        {
            int servoNumber = legs[legID].femurID;
            WriteAngle(servoNumber, angle);
        }

        public void SetCoxaAngle(int legID, int angle)
        {
            int servoNumber = legs[legID].coxaID;
            WriteAngle(servoNumber, angle);
        }

        public void SetAllTibiaAngle(int angle)
        {
            foreach (var leg in legs)
            {
                SetTibiaAngle(leg.Key, angle);
            }
        }

        public void SetAllFemurAngle(int angle)
        {
            foreach (var leg in legs)
            {
                SetFemurAngle(leg.Key, angle);
            }
        }

        public void SetAllCoxaAngle(int angle)
        {
            foreach (var leg in legs)
            {
                SetCoxaAngle(leg.Key, angle);
            }
        }

        private void WriteAngle(int servoNumber, int angle, bool useOffset = true)
        {
            if (!_storage.Settings.Servous.ContainsKey(servoNumber)) return;
            //TODO: добавить учет реверса привода
            int servoChunnel = _storage.Settings.Servous[servoNumber].Channel;

            if(useOffset)
            {
                if (angle < _storage.Settings.Servous[servoNumber].minAngle)
                    angle = _storage.Settings.Servous[servoNumber].minAngle;
                if (angle > _storage.Settings.Servous[servoNumber].maxAngle)
                    angle = _storage.Settings.Servous[servoNumber].maxAngle;

                angle += _storage.Settings.Servous[servoNumber].Offset;
                if (angle < 0)
                    angle = 0;

                if (angle > 180)
                    angle = 180;
            }

            if (_storage.Settings.Servous[servoNumber].isInverce)
                angle = 180 - angle;
            

            _packetMaster.ServoSetAngle(servoChunnel, angle);
        }
    }
}
