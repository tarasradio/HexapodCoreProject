﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexapodCoreProject.Elements
{
    public class StorageSettings
    {
        public Dictionary<int, Servo> Servous { get; set; }

        public StorageSettings()
        {
            Servous = new Dictionary<int, Servo>();
        }
    }
}