using System;
using System.Windows.Forms;

namespace HexapodGUIProject.Views
{
    public partial class EditLimitsDialogView : Form
    {
        public EditLimitsDialogView()
        {
            InitializeComponent();
        }

        public void SetInitValues(int lowerLimit, int upperLimit)
        {
            lowerLimitValue.Text = lowerLimit.ToString();
            upperLimitValue.Text = upperLimit.ToString();

            editLowerLimitValue.Value = lowerLimit;
            editUpperLimitValue.Value = upperLimit;
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

        public int GetLowerLimit()
        {
            return (int)editLowerLimitValue.Value;
        }

        public int GetUpperLimit()
        {
            return (int)editUpperLimitValue.Value;
        }
    }
}
