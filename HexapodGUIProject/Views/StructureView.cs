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
            oneServoTibia1.servoID = model.getLeg(1).tibiaID; oneServoTibia1.setData(model, storage);
            oneServoTibia2.servoID = model.getLeg(2).tibiaID; oneServoTibia2.setData(model, storage);
            oneServoTibia3.servoID = model.getLeg(3).tibiaID; oneServoTibia3.setData(model, storage);
            oneServoTibia4.servoID = model.getLeg(4).tibiaID; oneServoTibia4.setData(model, storage);
            oneServoTibia5.servoID = model.getLeg(5).tibiaID; oneServoTibia5.setData(model, storage);
            oneServoTibia6.servoID = model.getLeg(6).tibiaID; oneServoTibia6.setData(model, storage);

            oneServoFemur1.servoID = model.getLeg(1).femurID; oneServoFemur1.setData(model, storage);
            oneServoFemur2.servoID = model.getLeg(2).femurID; oneServoFemur2.setData(model, storage);
            oneServoFemur3.servoID = model.getLeg(3).femurID; oneServoFemur3.setData(model, storage);
            oneServoFemur4.servoID = model.getLeg(4).femurID; oneServoFemur4.setData(model, storage);
            oneServoFemur5.servoID = model.getLeg(5).femurID; oneServoFemur5.setData(model, storage);
            oneServoFemur6.servoID = model.getLeg(6).femurID; oneServoFemur6.setData(model, storage);

            oneServoCoxa1.servoID = model.getLeg(1).coxaID; oneServoCoxa1.setData(model, storage);
            oneServoCoxa2.servoID = model.getLeg(2).coxaID; oneServoCoxa2.setData(model, storage);
            oneServoCoxa3.servoID = model.getLeg(3).coxaID; oneServoCoxa3.setData(model, storage);
            oneServoCoxa4.servoID = model.getLeg(4).coxaID; oneServoCoxa4.setData(model, storage);
            oneServoCoxa5.servoID = model.getLeg(5).coxaID; oneServoCoxa5.setData(model, storage);
            oneServoCoxa6.servoID = model.getLeg(6).coxaID; oneServoCoxa6.setData(model, storage);
        }
    }
}
