using RealtimeGeneratorProject;
using FrundGeneratorProject;
using HexapodCoreProject;
using HexapodGUIProject.ViewModels;
using HexapodGUIProject.ViewPresenters;
using HexapodInterfacesProject;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HexapodGUIProject
{
    public partial class MainView : Form
    {
        ILogger _logger;
        HexapodInstance hexapodInst;
        FrundGenerator frundGenerator;
        RealtimeGenerator realtimeGenerator;

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

            _logger = hexapodInst.GetLogger();

            frundGenerator = new FrundGenerator(hexapodInst.GetHexapod(), _logger);
            realtimeGenerator = new RealtimeGenerator(hexapodInst.GetHexapod(), _logger);

            hexapodInst.AddMoveSource(frundGenerator);
            hexapodInst.AddMoveSource(realtimeGenerator);

            frundGeneratorView.AddGenerator(frundGenerator);
            realtimeGeneratorView.AddGenerator(realtimeGenerator);

            hexapodInst.GetLogger().OnNewMessageAdded 
                += logView.AddMessage;

            connectionState.Text = "Ожидание соединения";

            rescanGenerators();

            _servousModel = 
                new ServousModel(
                    hexapodInst.GetStorage(),
                hexapodInst.GetHexapod(),
                hexapodInst.GetLogger());

            _servousListPresenter = new ServousListPresenter(_servousModel);
            _selectedServoPresenter = new SelectedServousPresenter(_servousModel);
            servousListView.SetPresenter(_servousListPresenter);
            selectedServoView.SetPresenter(_selectedServoPresenter);
            
            servousListView.UpdateFromModel();
        }

        private void updateListPortsButton_Click(object sender, EventArgs e)
        {
            RescanOpenPorts();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            bool isOpenConnect = 
                hexapodInst.GetSerialPortMaster().isConnectOpen();

            if (isOpenConnect)
            {
                hexapodInst.GetSerialPortMaster().Disconnect();
                
                connectButton.Text = "Подключиться";
                connectionState.Text = "Ожидание соединения";

                RescanOpenPorts();
            }
            else
            {
                string portName = portsListBox.SelectedItem.ToString();

                bool isOK = hexapodInst.GetSerialPortMaster().Connect(portName);

                if (isOK)
                {
                    connectionState.Text = "Установленно соединение с " + portName;
                    _logger.AddMessage(
                        "Открытие подключения - Подключение к " + portName + " открыто");
                    connectButton.Text = "Отключение";
                    isOpenConnect = true;
					
                    hexapodInst.GoToStart();
                }
                else
                {
                    _logger.AddMessage(
                        "Открытие подключения - Ошибка при подключении!");
                    connectionState.Text = "Ожидание соединения";
                }
            }
        }

        public void RescanOpenPorts()
        {
            portsListBox.Items.Clear();

            List<string> portsNames = new List<string>();

            bool isOpen = 
                hexapodInst.GetSerialPortMaster().getOpenPorts(ref portsNames);

            portsListBox.Items.AddRange(portsNames.ToArray());

            if (isOpen == true)
            {
                _logger.AddMessage(
                    "Поиск портов - Найдены открытые порты");
                connectButton.Enabled = true;
                portsListBox.SelectedIndex = 0;
            }
            else
            {
                _logger.AddMessage(
                    "Поиск портов - Открытых портов не найдено");
                connectButton.Enabled = false;
                portsListBox.SelectedText = "";
            }
        }

        private void rescanGenerators()
        {
            foreach(var source in hexapodInst.SrcManager.getSources())
            {
                sourcesListBox.Items.Add(source.Name);
            }
        }

        private void selectGeneratorButton_Click(object sender, EventArgs e)
        {
            if (sourcesListBox.SelectedItem == null) return;
            string sourceName = sourcesListBox.SelectedItem.ToString();
            hexapodInst.SrcManager.SelectSource(sourceName);
        }

        private void terminateGeneratorButton_Click(object sender, EventArgs e)
        {
            hexapodInst.SrcManager.TerminateSource();
        }

        private void MainView_FormClosing(object sender, FormClosingEventArgs e)
        {
            hexapodInst.GetStorage().SaveFile("config.json");
        }

        private void goToStartButton_Click(object sender, EventArgs e)
        {
            hexapodInst.GoToStart();
        }
    }
}
