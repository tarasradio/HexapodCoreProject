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
        private IPortMaster _portMaster;

        const byte setAngleCommand = 25;
        const byte getAngleCommand = 29;

        public PacketMaster(IPortMaster portmaster)
        {
            _portMaster = portmaster;
        }
        
        public void servoSetAngle(int Number, int Angle)
        {
            byte[] buffer = new byte[5];
            Byte[] bytes;

            bytes = BitConverter.GetBytes('s');
            buffer[0] = bytes[0];
            bytes = BitConverter.GetBytes(setAngleCommand);
            buffer[1] = bytes[0];
            bytes = BitConverter.GetBytes(Number);
            buffer[2] = bytes[0];
            bytes = BitConverter.GetBytes(Angle);
            buffer[3] = bytes[0];
            bytes = BitConverter.GetBytes('e');
            buffer[4] = bytes[0];

            _portMaster.Write(buffer, 5);
        }
    }
}
