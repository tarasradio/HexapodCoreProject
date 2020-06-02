using HexapodCoreProject.Management;
using HexapodGUIProject.ViewModels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HexapodGUIProject.Views
{
    public partial class OneServoView : UserControl
    {
        ServousModel _model;

        public int ServoID = 1;
        private Storage _storage;

        public OneServoView()
        {
            InitializeComponent();
        }

        public void SetData(ServousModel model, Storage storage)
        {
            _model = model;
            _storage = storage;

            UpdateFromStorage();

            _model.OnNewSelectID += _model_onNewSelectID;
            _model.OnNewUpdateModel += _model_onNewUpdateModel;
        }

        private void _model_onNewUpdateModel()
        {
            UpdateFromStorage();
        }

        private void _model_onNewSelectID(int id)
        {
            if (id == ServoID)
            {
                labelSelect.BackColor = Color.FromName("GradientInactiveCaption");
            }
            else
            {
                labelSelect.BackColor = Color.White;
            }
        }

        public void UpdateFromStorage()
        {
            if (_storage == null) return;

            string label = "";

            label += _storage.Settings.Servous[ServoID].Number.ToString();
            label += "(" + _storage.Settings.Servous[ServoID].Channel.ToString() + ")";

            if(_storage.Settings.Servous[ServoID].isInverce)
            {
                label += "Инверсия";
            }

            labelSelect.Text = label;

            minAngleLabel.Text = _storage.Settings.Servous[ServoID].minAngle.ToString();
            maxAngleLabel.Text = _storage.Settings.Servous[ServoID].maxAngle.ToString();
        }

        private void labelSelect_Click(object sender, EventArgs e)
        {
            _model.SelectID(ServoID);
        }
    }
}
