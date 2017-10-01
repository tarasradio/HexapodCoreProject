using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HexapodGUIProject.ViewPresenters;
using HexapodInterfacesProject;

namespace HexapodGUIProject.Views
{
    public partial class ServousListView : UserControl, IView
    {
        ServousListPresenter _presenter;
        const int Columns = 8;
        
        string[] GridTitles =
        {   "#",
            "@",
            "Название",
            "Угол",
            "Мин Угол",
            "Макс угол",
            "Смещение",
            "Реверс" };

        enum States { UPDATE, SHOW };
        States state = States.SHOW;

        public ServousListView()
        {
            InitializeComponent();
            initView();
        }

        public void setPresenter (IPresenter presenter)
        {
            _presenter = (ServousListPresenter)presenter;
            _presenter.setView(this);
        }

        public void initView()
        {
            //вставляем заголовки
            servousList.ColumnCount = Columns;
            for (int i = 0; i < Columns; i++)
                servousList.Columns[i].HeaderText = GridTitles[i];
            servousList.Columns[2].AutoSizeMode =
            DataGridViewAutoSizeColumnMode.Fill;
            servousList.Columns[2].MinimumWidth = 100;
        }

        public void updateFromModel()
        {
            state = States.UPDATE;
            List<string[]> items = _presenter.getItems();
            servousList.RowCount = items.Count;
            int index = 0;
            foreach (var item in items)
            {
                for (int col = 0; col < Columns; col++)
                    servousList[col, index].Value = item[col];
                index++;
            }

            state = States.SHOW;
        }

        private void servousList_SelectionChanged(object sender, EventArgs e)
        {
            if (state == States.UPDATE) return;

            int index = servousList.CurrentRow.Index;
            if (index == -1) return;
            _presenter.selectID(
                int.Parse(servousList.CurrentRow.Cells[0].Value.ToString()));
        }
    }
}
