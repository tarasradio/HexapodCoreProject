using System;
using System.Collections.Generic;

namespace HexapodCoreProject.Elements
{
    [Serializable]
    public class HexapodSettings
    {
        public Dictionary<int, Servo> Servos { get; set; }
        public Dictionary<int, int> JointsToServosMap { get; set; }

        public HexapodSettings()
        {
            Servos = new Dictionary<int, Servo>();
            JointsToServosMap = new Dictionary<int, int>();
        }
    }
}
