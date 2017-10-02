﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodInterfacesProject
{
    public interface IMoveSource
    {
        string getName();
        void Run();
        void Terminate();
    }
}
