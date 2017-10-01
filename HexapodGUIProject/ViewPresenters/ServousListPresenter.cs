using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HexapodGUIProject.ViewModels;
using HexapodGUIProject.Views;
using HexapodInterfacesProject;

namespace HexapodGUIProject.ViewPresenters
{
    public class ServousListPresenter : IPresenter
    {
        ServousListView _view;
        ServousModel _model;

        public ServousListPresenter(ServousModel model)
        {
            _model = model;
            model.onNewUpdateModel += onNewUpdateModelHandler;
        }

        private void onNewUpdateModelHandler()
        {
            // вызываем здесь обновление данных из модели во вью
            _view.updateFromModel();
        }

        public void setView(IView view)
        {
            _view = (ServousListView)view;
        }

        public List<string[]> getItems()
        {
            return _model.getItems();
        }

        public void selectID(int id)
        {
            _model.selectID(id);
        }
    }
}
