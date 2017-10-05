using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HexapodGUIProject.Utils;

namespace HexapodGUIProject.Views
{
    public partial class LogView : UserControl
    {
        public LogView()
        {
            InitializeComponent();
        }

        public void addMessage(string message)
        {
            this.InvokeThread(()=>{
                logTextBox.AppendText(message);
                logTextBox.Select(logTextBox.Text.Length, 0);
                logTextBox.ScrollToCaret();
            });

        }
    }
}
