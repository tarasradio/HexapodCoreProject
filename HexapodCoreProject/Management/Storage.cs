using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using HexapodCoreProject.Elements;

namespace HexapodCoreProject.Management
{
    public class Storage
    {
        public StorageSettings settings { get; set; }

        public Storage()
        {
            settings = new StorageSettings();

            createDefaultSettingsFile();
        }

        public bool OpenFile(string fileName)
        {
            string fileString = System.IO.File.ReadAllText(fileName);
            settings = JsonConvert.DeserializeObject<StorageSettings>(fileString);

            return true;
        }

        //сохранить файл настроек
        public void SaveFile(string FileName)
        {
            string fileString = JsonConvert.SerializeObject(settings, Formatting.Indented);
            System.IO.File.WriteAllText(FileName, fileString);
        }

        public void createDefaultSettingsFile()
        {
            Servo servo;

            servo = new Servo(1, "Tibia 1");
            servo.Channel = 1;
            settings.Servous.Add(1, servo);

            servo = new Servo(2, "Femur 1");
            servo.Channel = 2;
            settings.Servous.Add(2, servo);

            servo = new Servo(3, "Coxa 1");
            servo.Channel = 3;
            settings.Servous.Add(3, servo);

            servo = new Servo(4, "Tibia 2");
            servo.Channel = 16;
            settings.Servous.Add(4, servo);

            servo = new Servo(5, "Femur 2");
            servo.Channel = 17;
            settings.Servous.Add(5, servo);

            servo = new Servo(6, "Coxa 2");
            servo.Channel = 18;
            settings.Servous.Add(6, servo);

            servo = new Servo(7, "Tibia 3");
            servo.Channel = 4;
            settings.Servous.Add(7, servo);

            servo = new Servo(8, "Femur 3");
            servo.Channel = 5;
            settings.Servous.Add(8, servo);

            servo = new Servo(9, "Coxa 3");
            servo.Channel = 6;
            settings.Servous.Add(9, servo);

            servo = new Servo(10, "Tibia 4");
            servo.Channel = 13;
            settings.Servous.Add(10, servo);

            servo = new Servo(11, "Femur 4");
            servo.Channel = 14;
            settings.Servous.Add(11, servo);

            servo = new Servo(12, "Coxa 4");
            servo.Channel = 15;
            settings.Servous.Add(12, servo);

            servo = new Servo(13, "Tibia 5");
            servo.Channel = 7;
            settings.Servous.Add(13, servo);

            servo = new Servo(14, "Femur 5");
            servo.Channel = 8;
            settings.Servous.Add(14, servo);

            servo = new Servo(15, "Coxa 5");
            servo.Channel = 9;
            settings.Servous.Add(15, servo);

            servo = new Servo(16, "Tibia 6");
            servo.Channel = 10;
            settings.Servous.Add(16, servo);

            servo = new Servo(17, "Femur 6");
            servo.Channel = 11;
            settings.Servous.Add(17, servo);

            servo = new Servo(18, "Coxa 6");
            servo.Channel = 12;
            settings.Servous.Add(18, servo);

            Leg leg;

            leg = new Leg(1, 2, 3);
            leg.Number = 1;
            leg.Name = "Left Forward";
            settings.Legs.Add(1, leg);

            leg = new Leg(4, 5, 6);
            leg.Number = 2;
            leg.Name = "Right Forward";
            settings.Legs.Add(2, leg);

            leg = new Leg(7, 8, 9);
            leg.Number = 3;
            leg.Name = "Left Middle";
            settings.Legs.Add(3, leg);

            leg = new Leg(10, 11, 12);
            leg.Number = 4;
            leg.Name = "Right Middle";
            settings.Legs.Add(4, leg);

            leg = new Leg(13, 14, 15);
            leg.Number = 5;
            leg.Name = "Left Back";
            settings.Legs.Add(5, leg);

            leg = new Leg(16, 17, 18);
            leg.Number = 6;
            leg.Name = "Right Back";
            settings.Legs.Add(6, leg);
        }
    }
}
