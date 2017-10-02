using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrundGeneratorProject.Views
{
    public partial class FrundGeneratorView : UserControl
    {
        public FrundGenerator _generator;

        const int Columns = 4;

        string[] GridTitles =
        {   "#",
            "Имя файла",
            "Описание",
            "Продолжительность" };

        enum States { UPDATE, SHOW };
        States state = States.SHOW;

        public FrundGeneratorView()
        {
            InitializeComponent();
            initListView();
        }

        public void addGenerator(FrundGenerator generator)
        {
            _generator = generator;
        }

        private void addFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Title = "Открытие файла движений";
            dialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            dialog.Multiselect = false;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;

                bool isSuccess = _generator.getStorage().addFile(fileName);

                if (isSuccess)
                {
                    editFileName.Text = fileName;
                    UpdateListView();
                }
            }
        }

        private void UpdateListView()
        {
            state = States.UPDATE;

            int countRows = _generator.getStorage().fileList.Count;

            filesListView.RowCount = countRows;

            int index = 0;
            foreach (var item in _generator.getStorage().fileList)
            {
                filesListView[0, index].Value = item.Key;
                filesListView[1, index].Value = item.Value.Name;
                filesListView[2, index].Value = item.Value.Title;
                filesListView[3, index].Value = item.Value.Duration;
                index++;
            }

            state = States.SHOW;
        }

        private void initListView()
        {
            //вставляем заголовки
            filesListView.ColumnCount = Columns;
            for (int i = 0; i < Columns; i++)
                filesListView.Columns[i].HeaderText = GridTitles[i];
            filesListView.Columns[1].AutoSizeMode =
            DataGridViewAutoSizeColumnMode.Fill;
            filesListView.Columns[2].AutoSizeMode =
            DataGridViewAutoSizeColumnMode.Fill;
            filesListView.Columns[1].MinimumWidth = 100;
            filesListView.Columns[2].MinimumWidth = 100;
        }

        private void startMoveButton_Click(object sender, EventArgs e)
        {
            uint id = uint.Parse(
                filesListView.CurrentRow.Cells[0].Value.ToString());
            _generator.startMove(id);
        }

        private void stopMoveButton_Click(object sender, EventArgs e)
        {
            _generator.stopMove();
        }
    }
}
