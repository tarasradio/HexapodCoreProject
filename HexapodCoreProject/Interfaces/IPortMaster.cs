using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodCoreProject.Interfaces
{
    public interface IPortMaster
    {
        void Write(byte[] data, int size);
        void Write(string data);
    }
}
