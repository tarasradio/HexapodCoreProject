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
        private Logger _logMaster;

        public int SelectedID { get; set; }

        public ServousModel(Storage storage, Hexapod hexapod, Logger logMaster)
        {
            _storage = storage;
            _hexapod = hexapod;
            _logMaster = logMaster;
        }

        public void SetOffset(int offset)
        {
            _storage.Settings.Servos[SelectedID].Offset = offset;
            OnNewUpdateModel?.Invoke();
        }

        public void SetInversion(bool isInverce)
        {
            _storage.Settings.Servos[SelectedID].IsInverce = isInverce;
            OnNewUpdateModel?.Invoke();
        }

        public void SetAngle(int angle)
        {
            _storage.Settings.Servos[SelectedID].Angle = angle;
            int servoNumber = _storage.Settings.Servos[SelectedID].Number;
            _hexapod.ServoSetAngle(servoNumber, angle);
            OnNewUpdateModel?.Invoke();
        }

        public void SetAngleWithoutOffset(int angle)
        {
            _storage.Settings.Servos[SelectedID].Angle = 
                angle + _storage.Settings.Servos[SelectedID].Offset;
            int servoNumber = _storage.Settings.Servos[SelectedID].Number;
            _hexapod.ServoSetAngle(servoNumber, angle, false);
            OnNewUpdateModel?.Invoke();
        }

        public void SetMinAngle(int angle)
        {
            _storage.Settings.Servos[SelectedID].LowerLimit = angle;
            OnNewUpdateModel?.Invoke();
        }

        public void SetMaxAngle(int angle)
        {
            _storage.Settings.Servos[SelectedID].UpperLimit = angle;
            OnNewUpdateModel?.Invoke();
        }

        public void SelectID(int ID)
        {
            if (!_storage.Settings.Servos.Keys.Contains(ID))
                return;
            SelectedID = ID;
            OnNewSelectID?.Invoke(SelectedID);
        }
        
        public Servo GetItem()
        {
            return _storage.Settings.Servos[SelectedID];
        }

        public List<string[]> GetItems()
        {
            List<string[]> items = new List<string[]>();

            foreach(var item in _storage.Settings.Servos)
            {
                string[] stringItem = new string[8];

                stringItem[0] = item.Value.Number.ToString();
                stringItem[1] = item.Value.Name;
                stringItem[2] = item.Value.Angle.ToString();
                stringItem[3] = item.Value.LowerLimit.ToString();
                stringItem[4] = item.Value.UpperLimit.ToString();
                stringItem[5] = item.Value.Offset.ToString();
                stringItem[6] = item.Value.IsInverce.ToString();

                items.Add(stringItem);
            }

            return items;
        }
    }
}
