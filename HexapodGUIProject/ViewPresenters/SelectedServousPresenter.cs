using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HexapodCoreProject.Elements;
using HexapodGUIProject.ViewModels;
using HexapodGUIProject.Views;
using HexapodInterfacesProject;

namespace HexapodGUIProject.ViewPresenters
{
    public class SelectedServousPresenter : IPresenter
    {
        SelectedServoView _view;
        ServousModel _model;

        public SelectedServousPresenter(ServousModel model)
        {
            _model = model;
            _model.OnNewSelectID += OnNewSelectIDHandler;
        }

        private void OnNewSelectIDHandler(int id)
        {
            // вызываем здесь обновление данных из модели во вью
            _view.UpdateFromModel();
        }

        public void SetView(IView view)
        {
            _view = (SelectedServoView)view;
        }

        public Servo GetItem()
        {
            return _model.GetItem();
        }

        public void SetAngle(int angle)
        {
            _model.SetAngle(angle);
        }

        public void SetMinAngle(int angle)
        {
            _model.SetMinAngle(angle);
        }

        public void SetMaxAngle(int angle)
        {
            _model.SetMaxAngle(angle);
        }

        public void SetAngleWithoutOffset(int angle)
        {
            _model.SetAngleWithoutOffset(angle);
        }

        public void SetOffset(int offset)
        {
            _model.SetOffset(offset);
        }

        public void SetInversion(bool isInverce)
        {
            _model.SetInversion(isInverce);
        }
    }
}
