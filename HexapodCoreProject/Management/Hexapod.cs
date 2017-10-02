using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HexapodCoreProject.Masters;
using HexapodCoreProject.Elements;
using HexapodCoreProject.Interfaces;

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
            legs = _storage.settings.Legs;
        }

        public void setAngle(int servoNumber, int angle, bool useOffset = true)
        {
            WriteAngle(servoNumber, angle, useOffset);
        }

        public void setTibiaAngle(int legID, int angle)
        {
            int servoNumber = legs[legID].tibiaID;
            WriteAngle(servoNumber, angle);
        }

        public void setFemurAngle(int legID, int angle)
        {
            int servoNumber = legs[legID].femurID;
            WriteAngle(servoNumber, angle);
        }

        public void setCoxaAngle(int legID, int angle)
        {
            int servoNumber = legs[legID].coxaID;
            WriteAngle(servoNumber, angle);
        }

        public void setAllTibiaAngle(int angle)
        {
            foreach (var leg in legs)
            {
                setTibiaAngle(leg.Key, angle);
            }
        }

        public void setAllFemurAngle(int angle)
        {
            foreach (var leg in legs)
            {
                setFemurAngle(leg.Key, angle);
            }
        }

        public void setAllCoxaAngle(int angle)
        {
            foreach (var leg in legs)
            {
                setCoxaAngle(leg.Key, angle);
            }
        }

        private void WriteAngle(int servoNumber, int angle, bool useOffset = true)
        {
            //TODO: добавить учет реверса привода
            int servoChunnel = _storage.settings.Servous[servoNumber].Channel;
            if(useOffset)
            {
                if (angle < _storage.settings.Servous[servoNumber].minAngle)
                angle = _storage.settings.Servous[servoNumber].minAngle;
                if (angle > _storage.settings.Servous[servoNumber].maxAngle)
                angle = _storage.settings.Servous[servoNumber].maxAngle;
                angle += _storage.settings.Servous[servoNumber].Offset;
            }
            _packetMaster.servoSetAngle(servoChunnel, angle);
        }
    }
}
