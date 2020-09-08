using Newtonsoft.Json;
using System;

namespace HexapodCoreProject.Elements
{
    [Serializable]
    public class Servo
    {
        public string Name { get; set; } = "";
        public int Number { get; set; } = 0;

        [JsonIgnore]
        public int Angle { get; set; } = 0;

        public int Offset { get; set; } = 0;
        public bool IsInverce { get; set; } = false;
        public int LowerLimit { get; set; } = 0;
        public int UpperLimit { get; set; } = 0;
        public bool IsEnable { get; set; } = true;

        public Servo(int number)
        {
            Number = number;
        }

        public Servo(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public Servo()
        {

        }
    }
}
