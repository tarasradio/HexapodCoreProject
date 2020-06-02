using HexapodGUIProject.Utils;
using System.Windows.Forms;

namespace HexapodGUIProject.Views
{
    public partial class LogView : UserControl
    {
        public LogView()
        {
            InitializeComponent();
        }

        public void AddMessage(string message)
        {
            this.InvokeThread(()=>{
                logTextBox.AppendText(message);
                logTextBox.Select(logTextBox.Text.Length, 0);
                logTextBox.ScrollToCaret();
            });

        }
    }
}
