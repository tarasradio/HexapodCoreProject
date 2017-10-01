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
            _model.onNewSelectID += onNewSelectIDHandler;
        }

        private void onNewSelectIDHandler(int id)
        {
            // вызываем здесь обновление данных из модели во вью
            _view.updateFromModel();
        }

        public void setView(IView view)
        {
            _view = (SelectedServoView)view;
        }

        public Servo getItem()
        {
            return _model.getItem();
        }

        public void setAngle(int angle)
        {
            _model.setAngle(angle);
        }

        public void setMinAngle(int angle)
        {
            _model.setMinAngle(angle);
        }

        public void setMaxAngle(int angle)
        {
            _model.setMaxAngle(angle);
        }

        public void setAngleWithoutOffset(int angle)
        {
            _model.setAngleWithoutOffset(angle);
        }

        public void setOffset(int offset)
        {
            _model.setOffset(offset);
        }

        public void setReverce(bool isReverce)
        {
            _model.setReverce(isReverce);
        }
    }
}
