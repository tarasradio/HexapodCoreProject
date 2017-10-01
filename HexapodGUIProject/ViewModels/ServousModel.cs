using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HexapodCoreProject.Elements;
using HexapodCoreProject.Management;
using HexapodCoreProject.Masters;

namespace HexapodGUIProject.ViewModels
{
    public class ServousModel
    {
        public delegate void newUpdateHandler();
        public delegate void newSelectedIDHandler(int id);
        public event newUpdateHandler onNewUpdateModel;
        public event newSelectedIDHandler onNewSelectID;

        Storage _storage;
        Hexapod _hexapod;
        LogMaster _logMaster;

        // выбранный привод
        public int selectedID { get; set; }

        public ServousModel(Storage storage, Hexapod hexapod, LogMaster logMaster)
        {
            _storage = storage;
            _hexapod = hexapod;
            _logMaster = logMaster;
        }

        public void setOffset(int offset)
        {
            _storage.settings.Servous[selectedID].Offset = offset;
            onNewUpdateModel?.Invoke();
        }

        public void setReverce(bool isReverce)
        {
            _storage.settings.Servous[selectedID].isReverce = isReverce;
            onNewUpdateModel?.Invoke();
        }

        public void setAngle(int angle)
        {
            _storage.settings.Servous[selectedID].Angle = angle;
            int servoNumber = _storage.settings.Servous[selectedID].Number;
            _hexapod.setAngle(servoNumber, angle);
            onNewUpdateModel?.Invoke();
        }

        public void setAngleWithoutOffset(int angle)
        {
            _storage.settings.Servous[selectedID].Angle = 
                angle + _storage.settings.Servous[selectedID].Offset;
            int servoNumber = _storage.settings.Servous[selectedID].Number;
            _hexapod.setAngle(servoNumber, angle);
            onNewUpdateModel?.Invoke();
        }

        public void setMinAngle(int angle)
        {
            _storage.settings.Servous[selectedID].minAngle = angle;
            onNewUpdateModel?.Invoke();
        }

        public void setMaxAngle(int angle)
        {
            _storage.settings.Servous[selectedID].maxAngle = angle;
            onNewUpdateModel?.Invoke();
        }

        public void selectID(int ID)
        {
            if (!_storage.settings.Servous.Keys.Contains(ID))
                return;
            selectedID = ID;
            onNewSelectID?.Invoke(selectedID);
            _logMaster.addMessage("Выбрана строка" + ID);
        }

        public Servo getItem()
        {
            return _storage.settings.Servous[selectedID];
        }

        public List<string[]> getItems()
        {
            List<string[]> items = new List<string[]>();

            foreach(var item in _storage.settings.Servous)
            {
                string[] stringItem = new string[8];

                stringItem[0] = item.Value.Number.ToString();
                stringItem[1] = item.Value.Channel.ToString();
                stringItem[2] = item.Value.Name;
                stringItem[3] = item.Value.Angle.ToString();
                stringItem[4] = item.Value.minAngle.ToString();
                stringItem[5] = item.Value.maxAngle.ToString();
                stringItem[6] = item.Value.Offset.ToString();
                stringItem[7] = item.Value.isReverce.ToString();

                items.Add(stringItem);
            }

            return items;
        }
    }
}
