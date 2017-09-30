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
        GateGenerator generator;

        public GateGeneratorView()
        {
            InitializeComponent();
        }

        public void addGenerator(GateGenerator generator)
        {
            this.generator = generator;
        }
    }
}
