using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HexapodInterfacesProject;
using HexapodCoreProject;
using FrundGeneratorProject;
using GateGeneratorProject;

namespace HexapodGUIProject
{
    public partial class MainView : Form
    {
        HexapodInstance hexapodInst;
        FrundGenerator frundGenerator;
        GateGenerator gateGenerator;

        public MainView()
        {
            InitializeComponent();
            InitAll();
        }

        public void InitAll()
        {
            hexapodInst = new HexapodInstance("config.json");

            frundGenerator = new FrundGenerator();
            gateGenerator = new GateGenerator();

            hexapodInst.addMoveSource(frundGenerator);
            hexapodInst.addMoveSource(gateGenerator);

            frundGeneratorView.addGenerator(frundGenerator);
            gateGeneratorView.addGenerator(gateGenerator);
        }
    }
}
