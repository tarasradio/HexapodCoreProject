using HexapodCoreProject.Management;
using HexapodGUIProject.ViewModels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HexapodGUIProject.Views
{
    public partial class OneServoView : UserControl
    {
        ServousModel model;

        public int ServoID = 1;
        private Storage storage;

        public OneServoView()
        {
            InitializeComponent();
        }

        public void SetData(ServousModel model, Storage storage)
        {
            this.model = model;
            this.storage = storage;

            UpdateFromStorage();

            this.model.OnNewSelectID += _model_onNewSelectID;
            this.model.OnNewUpdateModel += _model_onNewUpdateModel;
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
            if (storage == null) return;

            string label = storage.Settings.Servos[ServoID].Number.ToString();

            if(storage.Settings.Servos[ServoID].IsInverce)
            {
                label += "Инверсия";
            }

            labelSelect.Text = label;

            minAngleLabel.Text = storage.Settings.Servos[ServoID].LowerLimit.ToString();
            maxAngleLabel.Text = storage.Settings.Servos[ServoID].UpperLimit.ToString();
        }

        private void labelSelect_Click(object sender, EventArgs e)
        {
            model.SelectID(ServoID);
        }
    }
}
