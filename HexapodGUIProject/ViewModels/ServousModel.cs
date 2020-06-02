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
        public delegate void NewUpdateHandler();
        public delegate void NewSelectedIDHandler(int id);
        public event NewUpdateHandler OnNewUpdateModel;
        public event NewSelectedIDHandler OnNewSelectID;

        private Storage _storage;
        private Hexapod _hexapod;
        private LogMaster _logMaster;

        // выбранный привод
        public int SelectedID { get; set; }

        public ServousModel(Storage storage, Hexapod hexapod, LogMaster logMaster)
        {
            _storage = storage;
            _hexapod = hexapod;
            _logMaster = logMaster;
        }

        public void SetOffset(int offset)
        {
            _storage.Settings.Servous[SelectedID].Offset = offset;
            OnNewUpdateModel?.Invoke();
        }

        public void SetInversion(bool isInverce)
        {
            _storage.Settings.Servous[SelectedID].isInverce = isInverce;
            OnNewUpdateModel?.Invoke();
        }

        public void SetAngle(int angle)
        {
            _storage.Settings.Servous[SelectedID].Angle = angle;
            int servoNumber = _storage.Settings.Servous[SelectedID].Number;
            _hexapod.SetAngle(servoNumber, angle);
            OnNewUpdateModel?.Invoke();
        }

        public void SetAngleWithoutOffset(int angle)
        {
            _storage.Settings.Servous[SelectedID].Angle = 
                angle + _storage.Settings.Servous[SelectedID].Offset;
            int servoNumber = _storage.Settings.Servous[SelectedID].Number;
            _hexapod.SetAngle(servoNumber, angle, false);
            OnNewUpdateModel?.Invoke();
        }

        public void SetMinAngle(int angle)
        {
            _storage.Settings.Servous[SelectedID].minAngle = angle;
            OnNewUpdateModel?.Invoke();
        }

        public void SetMaxAngle(int angle)
        {
            _storage.Settings.Servous[SelectedID].maxAngle = angle;
            OnNewUpdateModel?.Invoke();
        }

        public void SelectID(int ID)
        {
            if (!_storage.Settings.Servous.Keys.Contains(ID))
                return;
            SelectedID = ID;
            OnNewSelectID?.Invoke(SelectedID);
            _logMaster.AddMessage("Выбрана строка" + ID);
        }
        
        public Leg GetLeg(int id)
        {
            return _storage.Settings.Legs[id];
        }

        public Servo GetItem()
        {
            return _storage.Settings.Servous[SelectedID];
        }

        public List<string[]> GetItems()
        {
            List<string[]> items = new List<string[]>();

            foreach(var item in _storage.Settings.Servous)
            {
                string[] stringItem = new string[8];

                stringItem[0] = item.Value.Number.ToString();
                stringItem[1] = item.Value.Channel.ToString();
                stringItem[2] = item.Value.Name;
                stringItem[3] = item.Value.Angle.ToString();
                stringItem[4] = item.Value.minAngle.ToString();
                stringItem[5] = item.Value.maxAngle.ToString();
                stringItem[6] = item.Value.Offset.ToString();
                stringItem[7] = item.Value.isInverce.ToString();

                items.Add(stringItem);
            }

            return items;
        }
    }
}
