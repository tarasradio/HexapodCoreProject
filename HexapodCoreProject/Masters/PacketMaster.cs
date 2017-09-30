using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HexapodCoreProject.Interfaces;

namespace HexapodCoreProject.Masters
{
    public class PacketMaster : IPacketMaster
    {
        private IPortMaster _portmaster;

        public PacketMaster(IPortMaster portmaster)
        {
            _portmaster = portmaster;
        }
    }
}
