using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HexapodGUIProject.Views
{
    public partial class EditLimitsDialogView : Form
    {
        public EditLimitsDialogView()
        {
            InitializeComponent();
        }

        public void setInitValues(int left, int right)
        {
            leftLimit.Text = left.ToString();
            rightLimit.Text = right.ToString();

            editLeftValue.Value = left;
            editRightValue.Value = right;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public int getLeftValue()
        {
            return (int)editLeftValue.Value;
        }

        public int getRightValue()
        {
            return (int)editRightValue.Value;
        }
    }
}
