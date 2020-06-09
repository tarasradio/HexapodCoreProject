using System;
using System.Windows.Forms;

namespace FrundGeneratorProject.Views
{
    public partial class FrundGeneratorView : UserControl
    {
        private FrundGenerator _generator;

        const int Columns = 4;

        string[] GridTitles =
        {   "#",
            "File name",
            "File description",
            "Duration (seconds)" };

        public FrundGeneratorView()
        {
            InitializeComponent();
            initListView();
        }

        public void AddGenerator(FrundGenerator generator)
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

                bool isSuccess = _generator.AddFile(fileName);

                if (isSuccess)
                {
                    editFileName.Text = fileName;
                    UpdateListView();
                }
            }
        }

        private void UpdateListView()
        {
            int countRows = _generator.MoveFiles.Count;

            filesListView.RowCount = countRows;

            int index = 0;
            for(int i = 0; i<_generator.MoveFiles.Count; i++)
            {
                var item = _generator.MoveFiles[i];

                filesListView[0, index].Value = i;
                filesListView[1, index].Value = item.Name;
                filesListView[2, index].Value = item.Title;
                filesListView[3, index].Value = item.Duration / 10e6;
                index++;
            }
        }

        private void initListView()
        {
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
            if (filesListView.CurrentRow != null)            
                _generator.StartMove(filesListView.CurrentRow.Index);
        }

        private void stopMoveButton_Click(object sender, EventArgs e)
        {
            _generator.StopMove();
        }
    }
}
