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
            model.OnNewUpdateModel += onNewUpdateModelHandler;
            model.OnNewSelectID += Model_onNewSelectID;
        }

        private void Model_onNewSelectID(int id)
        {
            _view.SelectId(id);
        }

        private void onNewUpdateModelHandler()
        {
            // вызываем здесь обновление данных из модели во вью
            _view.UpdateFromModel();
        }

        public void SetView(IView view)
        {
            _view = (ServousListView)view;
        }

        public List<string[]> getItems()
        {
            return _model.GetItems();
        }

        public void selectID(int id)
        {
            _model.SelectID(id);
        }
    }
}
