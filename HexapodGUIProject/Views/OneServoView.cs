using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HexapodCoreProject.Management;
using HexapodGUIProject.ViewModels;

namespace HexapodGUIProject.Views
{
    public partial class OneServoView : UserControl
    {
        ServousModel _model;

        public int servoID = 1;
        public Storage _storage;

        public OneServoView()
        {
            InitializeComponent();
        }

        public void setData(ServousModel model, Storage storage)
        {
            _model = model;
            _storage = storage;
            updateFromStorage();
            _model.onNewSelectID += _model_onNewSelectID;
            _model.onNewUpdateModel += _model_onNewUpdateModel;
        }

        private void _model_onNewUpdateModel()
        {
            updateFromStorage();
        }

        private void _model_onNewSelectID(int id)
        {
            if (id == servoID)
            {
                labelSelect.BackColor = Color.FromName("GradientInactiveCaption");
            }
            else
            {
                labelSelect.BackColor = Color.White;
            }
        }

        public void updateFromStorage()
        {
            if (_storage == null) return;
            string label = "";
            label += _storage.settings.Servous[servoID].Number.ToString();
            label += "(" + _storage.settings.Servous[servoID].Channel.ToString() + ")";
            if(_storage.settings.Servous[servoID].isReverce)
            {
                label += "Реверс";
            }
            labelSelect.Text = label;

            minAngleLabel.Text = _storage.settings.Servous[servoID].minAngle.ToString();
            maxAngleLabel.Text = _storage.settings.Servous[servoID].maxAngle.ToString();
        }

        private void labelSelect_Click(object sender, EventArgs e)
        {
            _model.selectID(servoID);
        }
    }
}
