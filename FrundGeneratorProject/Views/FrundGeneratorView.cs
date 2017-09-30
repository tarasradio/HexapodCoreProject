using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrundGeneratorProject.Views
{
    public partial class FrundGeneratorView : UserControl
    {
        public FrundGenerator generator;

        public FrundGeneratorView()
        {
            InitializeComponent();
        }

        public void addGenerator(FrundGenerator generator)
        {
            this.generator = generator;
        }
    }
}
