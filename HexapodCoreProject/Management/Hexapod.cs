using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HexapodCoreProject.Interfaces;

namespace HexapodCoreProject.Management
{
    public class Hexapod : IRobot
    {
        private Storage _storage;
        private IPacketMaster _packetMaster;

        public Hexapod(Storage storage, IPacketMaster packetMaster)
        {
            _storage = storage;
            _packetMaster = packetMaster;
        }
    }
}
