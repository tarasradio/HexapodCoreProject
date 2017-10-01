using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HexapodCoreProject.Elements;
using HexapodGUIProject.ViewPresenters;
using HexapodInterfacesProject;

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

        public void setPresenter(IPresenter presenter)
        {
            _presenter = (SelectedServousPresenter)presenter;
            _presenter.setView(this);
        }

        private void selectState(States newState)
        {
            _state = newState;
            switch(newState)
            {
                case States.SHOW:
                    {
                        buttonSetOffset.Enabled = false;
                        checkBoxReverce.Enabled = false;
                        checkBoxTrace.Enabled = true;
                        checkBoxCalibration.Enabled = true;
                        checkBoxCalibration.Checked = false;
                        checkBoxTrace.Checked = false;
                    }
                    break;
                case States.CALIBRATION:
                    {
                        buttonSetOffset.Enabled = true;
                        checkBoxReverce.Enabled = true;
                        checkBoxTrace.Enabled = false;
                    }
                    break;
                case States.TRACE:
                    {
                        buttonSetOffset.Enabled = false;
                        checkBoxReverce.Enabled = false;
                        checkBoxCalibration.Enabled = false;
                    }
                    break;
            }
        }

        public void updateFromModel()
        {
            Servo item = _presenter.getItem();
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

            checkBoxReverce.Checked = item.isReverce;

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
                dialog.setInitValues(
                    _presenter.getItem().minAngle,
                    _presenter.getItem().maxAngle);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    _presenter.setMinAngle(dialog.getLeftValue());
                    _presenter.setMaxAngle(dialog.getRightValue());
                }
        }

        private void buttonSetOffset_Click(object sender, EventArgs e)
        {
            int offset = trackAngle.Value - 90;
            _presenter.setOffset(offset);
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
            _presenter.setReverce(checkBoxReverce.Checked);
        }

        private void trackAngle_Scroll(object sender, EventArgs e)
        {
            if (_state == States.SHOW) return;

            int angle = trackAngle.Value;
            labelCurrentAngle.Text = angle.ToString();

            if (_state == States.CALIBRATION)
            {
                _presenter.setAngleWithoutOffset(angle);
            }
            else
            {
                _presenter.setAngle(angle);
            }
        }
    }
}
