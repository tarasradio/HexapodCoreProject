using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealtimeGeneratorProject.Views
{
    public partial class RealtimeGeneratorView : UserControl
    {
        private RealtimeGenerator _generator;

        public RealtimeGeneratorView()
        {
            InitializeComponent();
        }

        public void AddGenerator(RealtimeGenerator generator)
        {
            _generator = generator;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            _generator.Run((int)editPortNumber.Value);
        }

        private void terminateButton_Click(object sender, EventArgs e)
        {
            _generator.Terminate();
        }
    }
}
