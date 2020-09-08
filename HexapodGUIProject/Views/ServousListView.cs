using HexapodGUIProject.ViewPresenters;
using HexapodInterfacesProject;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HexapodGUIProject.Views
{
    public partial class ServousListView : UserControl, IView
    {
        ServousListPresenter presenter;
        
        private string[] GridTitles = {
            "№",
            "Описание",
            "Позиция",
            "Нижний предел",
            "Верхний предел",
            "Смещение",
            "Инверсия" };

        enum States { UPDATE, SHOW };
        States state = States.SHOW;

        public ServousListView()
        {
            InitializeComponent();
            initView();
        }

        public void SetPresenter (IPresenter presenter)
        {
            this.presenter = (ServousListPresenter)presenter;
            this.presenter.SetView(this);
        }

        private void initView()
        {
            servousList.ColumnCount = GridTitles.Length;
            for (int i = 0; i < servousList.ColumnCount; i++)
                servousList.Columns[i].HeaderText = GridTitles[i];
            servousList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            servousList.Columns[1].MinimumWidth = 100;
        }

        public void SelectId(int id)
        {
            state = States.UPDATE;
            for (int i = 0; i <servousList.RowCount; i++)
            {
                if(int.Parse(servousList[0, i].Value.ToString()) == id)
                {
                    servousList.CurrentCell = servousList[0, i];
                }
            }
            state = States.SHOW;
        }

        public void UpdateFromModel()
        {
            state = States.UPDATE;
            List<string[]> items = presenter.getItems();
            servousList.RowCount = items.Count;
            int index = 0;
            foreach (var item in items)
            {
                for (int i = 0; i < servousList.ColumnCount; i++)
                    servousList[i, index].Value = item[i];
                index++;
            }

            state = States.SHOW;
        }

        private void servousList_SelectionChanged(object sender, EventArgs e)
        {
            if (state == States.UPDATE) return;

            int index = servousList.CurrentRow.Index;
            if (index == -1) return;
            presenter.selectID(
                int.Parse(servousList.CurrentRow.Cells[0].Value.ToString()));
        }
    }
}
