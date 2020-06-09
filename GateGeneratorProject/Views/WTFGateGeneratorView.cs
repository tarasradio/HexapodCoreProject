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
    public partial class WTFGateGeneratorView : UserControl
    {
        WTFGateGenerator _generator;

        public WTFGateGeneratorView()
        {
            InitializeComponent();
        }

        public void AddGenerator(WTFGateGenerator generator)
        {
            _generator = generator;
        }

        private void buttonRorward_Click(object sender, EventArgs e)
        {
            _generator.StartMoveForward();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _generator.StopMove();
        }
    }
}
