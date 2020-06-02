using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HexapodGUIProject.ViewModels;
using HexapodCoreProject.Management;

namespace HexapodGUIProject.Views
{
    public partial class StructureView : UserControl
    {
        public StructureView()
        {
            InitializeComponent();
        }

        private void StructureView_Load(object sender, EventArgs e)
        {

        }

        public void Init(ServousModel model, Storage storage)
        {
            oneServoTibia1.ServoID = model.GetLeg(1).tibiaID; oneServoTibia1.SetData(model, storage);
            oneServoTibia2.ServoID = model.GetLeg(2).tibiaID; oneServoTibia2.SetData(model, storage);
            oneServoTibia3.ServoID = model.GetLeg(3).tibiaID; oneServoTibia3.SetData(model, storage);
            oneServoTibia4.ServoID = model.GetLeg(4).tibiaID; oneServoTibia4.SetData(model, storage);
            oneServoTibia5.ServoID = model.GetLeg(5).tibiaID; oneServoTibia5.SetData(model, storage);
            oneServoTibia6.ServoID = model.GetLeg(6).tibiaID; oneServoTibia6.SetData(model, storage);

            oneServoFemur1.ServoID = model.GetLeg(1).femurID; oneServoFemur1.SetData(model, storage);
            oneServoFemur2.ServoID = model.GetLeg(2).femurID; oneServoFemur2.SetData(model, storage);
            oneServoFemur3.ServoID = model.GetLeg(3).femurID; oneServoFemur3.SetData(model, storage);
            oneServoFemur4.ServoID = model.GetLeg(4).femurID; oneServoFemur4.SetData(model, storage);
            oneServoFemur5.ServoID = model.GetLeg(5).femurID; oneServoFemur5.SetData(model, storage);
            oneServoFemur6.ServoID = model.GetLeg(6).femurID; oneServoFemur6.SetData(model, storage);

            oneServoCoxa1.ServoID = model.GetLeg(1).coxaID; oneServoCoxa1.SetData(model, storage);
            oneServoCoxa2.ServoID = model.GetLeg(2).coxaID; oneServoCoxa2.SetData(model, storage);
            oneServoCoxa3.ServoID = model.GetLeg(3).coxaID; oneServoCoxa3.SetData(model, storage);
            oneServoCoxa4.ServoID = model.GetLeg(4).coxaID; oneServoCoxa4.SetData(model, storage);
            oneServoCoxa5.ServoID = model.GetLeg(5).coxaID; oneServoCoxa5.SetData(model, storage);
            oneServoCoxa6.ServoID = model.GetLeg(6).coxaID; oneServoCoxa6.SetData(model, storage);
        }
    }
}
