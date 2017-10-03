using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GateGeneratorProject.Views
{
    public partial class GateGeneratorView : UserControl
    {
        GateGenerator _generator;

        public GateGeneratorView()
        {
            InitializeComponent();
        }

        public void addGenerator(GateGenerator generator)
        {
            _generator = generator;
        }

        private void buttonRorward_Click(object sender, EventArgs e)
        {
            _generator.startMoveForward();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _generator.stopMove();
        }
    }
}
