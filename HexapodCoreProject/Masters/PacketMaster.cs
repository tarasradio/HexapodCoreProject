using HexapodCoreProject.Interfaces;
using System;

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
        
        public void ServoSetAngle(int number, int angle)
        {
            byte[] buffer = new byte[5];
            byte[] bytes;

            bytes = BitConverter.GetBytes('s');
            buffer[0] = bytes[0];
            bytes = BitConverter.GetBytes(setAngleCommand);
            buffer[1] = bytes[0];
            bytes = BitConverter.GetBytes(number);
            buffer[2] = bytes[0];
            bytes = BitConverter.GetBytes(angle);
            buffer[3] = bytes[0];
            bytes = BitConverter.GetBytes('e');
            buffer[4] = bytes[0];

            _portMaster.Write(buffer, 5);
        }
    }
}
