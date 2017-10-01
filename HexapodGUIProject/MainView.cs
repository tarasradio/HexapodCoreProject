using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HexapodInterfacesProject;
using HexapodCoreProject;
using FrundGeneratorProject;
using GateGeneratorProject;
using HexapodGUIProject.ViewModels;
using HexapodGUIProject.ViewPresenters;
using HexapodGUIProject.Views;

namespace HexapodGUIProject
{
    public partial class MainView : Form
    {
        HexapodInstance hexapodInst;
        FrundGenerator frundGenerator;
        GateGenerator gateGenerator;

        ServousModel _servousModel;
        ServousListPresenter _servousListPresenter;
        SelectedServousPresenter _selectedServoPresenter;
        
        public MainView()
        {
            InitializeComponent();
            InitAll();
        }

        public void InitAll()
        {
            hexapodInst = new HexapodInstance("config.json");

            frundGenerator = new FrundGenerator();
            gateGenerator = new GateGenerator();

            hexapodInst.addMoveSource(frundGenerator);
            hexapodInst.addMoveSource(gateGenerator);

            frundGeneratorView.addGenerator(frundGenerator);
            gateGeneratorView.addGenerator(gateGenerator);

            hexapodInst.getLogMaster().onNewMessageAdded 
                += logView.addMessage;

            connectionState.Text = "Ожидание соединения";

            _servousModel = 
                new ServousModel(
                    hexapodInst.getStorage(),
                hexapodInst.gethexapod(),
                hexapodInst.getLogMaster());

            _servousListPresenter = new ServousListPresenter(_servousModel);
            _selectedServoPresenter = new SelectedServousPresenter(_servousModel);
            servousListView.setPresenter(_servousListPresenter);
            selectedServoView.setPresenter(_selectedServoPresenter);

            servousListView.updateFromModel();
        }

        private void updateListPortsButton_Click(object sender, EventArgs e)
        {
            rescanOpenPorts();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            bool isOpenConnect = 
                hexapodInst.getSerialPortMaster().isConnectOpen();

            if (isOpenConnect)
            {
                hexapodInst.getSerialPortMaster().Disconnect();
                
                connectButton.Text = "Подключиться";
                connectionState.Text = "Ожидание соединения";

                rescanOpenPorts();
            }
            else
            {
                string portName = listPortsBox.SelectedItem.ToString();

                bool isOK = hexapodInst.getSerialPortMaster().Connect(portName);

                if (isOK)
                {
                    connectionState.Text = "Установленно соединение с " + portName;
                    hexapodInst.getLogMaster().addMessage(
                        "Открытие подключения - Подключение к " + portName + " открыто");
                    connectButton.Text = "Отключение";
                    isOpenConnect = true;
                }
                else
                {
                    hexapodInst.getLogMaster().addMessage(
                        "Открытие подключения - Ошибка при подключении!");
                    connectionState.Text = "Ожидание соединения";
                }
            }
        }

        public void rescanOpenPorts()
        {
            listPortsBox.Items.Clear();

            List<String> portsNames = new List<string>();

            bool isOpen = 
                hexapodInst.getSerialPortMaster().getOpenPorts(ref portsNames);

            listPortsBox.Items.AddRange(portsNames.ToArray());

            if (isOpen == true)
            {
                hexapodInst.getLogMaster().addMessage(
                    "Поиск портов - Найдены открытые порты");
                connectButton.Enabled = true;
                listPortsBox.SelectedIndex = 0;
            }
            else
            {
                hexapodInst.getLogMaster().addMessage(
                    "Поиск портов - Открытых портов не найдено");
                connectButton.Enabled = false;
                listPortsBox.SelectedText = "";
            }
        }
    }
}
