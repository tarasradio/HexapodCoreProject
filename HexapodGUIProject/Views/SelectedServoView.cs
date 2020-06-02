using HexapodCoreProject.Elements;
using HexapodGUIProject.ViewPresenters;
using HexapodInterfacesProject;
using System;
using System.Windows.Forms;

namespace HexapodGUIProject.Views
{
    public partial class SelectedServoView : UserControl, IView
    {
        SelectedServousPresenter _presenter;

        enum States { TRACE, CALIBRATION, SHOW };
        States _state;

        public SelectedServoView()
        {
            InitializeComponent();
            selectState(States.SHOW);
        }

        public void SetPresenter(IPresenter presenter)
        {
            _presenter = (SelectedServousPresenter)presenter;
            _presenter.SetView(this);
        }

        private void selectState(States newState)
        {
            _state = newState;
            switch(newState)
            {
                case States.SHOW:
                    {
                        buttonSetOffset.Enabled = false;
                        checkBoxInversion.Enabled = false;
                        checkBoxTrace.Enabled = true;
                        checkBoxCalibration.Enabled = true;
                        checkBoxCalibration.Checked = false;
                        checkBoxTrace.Checked = false;
                    }
                    break;
                case States.CALIBRATION:
                    {
                        buttonSetOffset.Enabled = true;
                        checkBoxInversion.Enabled = true;
                        checkBoxTrace.Enabled = false;
                    }
                    break;
                case States.TRACE:
                    {
                        buttonSetOffset.Enabled = false;
                        checkBoxInversion.Enabled = false;
                        checkBoxCalibration.Enabled = false;
                    }
                    break;
            }
        }

        public void UpdateFromModel()
        {
            Servo item = _presenter.GetItem();
            UpdateView(item);
        }

        public void UpdateView(Servo item)
        {
            selectState(States.SHOW);

            textServoName.Text = item.Name;
            textServoNumber.Text = "Привод " + item.Number.ToString();

            labelMinAngle.Text = item.minAngle.ToString();
            labelMaxAngle.Text = item.maxAngle.ToString();
            labelCurrentAngle.Text = item.Angle.ToString();

            trackAngle.Minimum = item.minAngle;
            trackAngle.Maximum = item.maxAngle;

            checkBoxInversion.Checked = item.isInverce;

            if (_state != States.TRACE)
            {
                if (item.Angle > item.maxAngle)
                    trackAngle.Value = item.maxAngle;
                else if (item.Angle < item.minAngle)
                    trackAngle.Value = item.minAngle;
                else
                    trackAngle.Value = item.Angle;
            }
            else
            {
                item.Angle = trackAngle.Value;
            }
        }

        private void buttonEditLimits_Click(object sender, EventArgs e)
        {
            EditLimitsDialogView dialog = new EditLimitsDialogView();
                dialog.SetInitValues(
                    _presenter.GetItem().minAngle,
                    _presenter.GetItem().maxAngle);

            dialog.StartPosition = FormStartPosition.CenterParent;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _presenter.SetMinAngle(dialog.GetLowerLimit());
                _presenter.SetMaxAngle(dialog.GetUpperLimit());
            }
        }

        private void buttonSetOffset_Click(object sender, EventArgs e)
        {
            int offset = trackAngle.Value - 90;
            _presenter.SetOffset(offset);
        }

        private void checkBoxTrace_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxTrace.Checked)
                selectState(States.TRACE);
            else
                selectState(States.SHOW);
        }

        private void checkBoxCalibration_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCalibration.Checked)
                selectState(States.CALIBRATION);
            else
                selectState(States.SHOW);
        }

        private void checkBoxReverce_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.SetInversion(checkBoxInversion.Checked);
        }


        private void trackAngle_Scroll(object sender, EventArgs e)
        {
            int a = 0;
            if (_state == States.SHOW) return;

            int angle = trackAngle.Value;
            labelCurrentAngle.Text = angle.ToString();

            if (_state == States.CALIBRATION)
            {
                _presenter.SetAngleWithoutOffset(angle);
            }

            if (_state == States.TRACE)
            {
                _presenter.SetAngle(angle);
            }
        }
    }
}
