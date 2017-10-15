using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;

using HexapodCoreProject.Interfaces;

namespace HexapodCoreProject.Masters
{
    public class SerialPortMaster : IPortMaster
    {
        public delegate void newDataReceiveHandler(byte[] data, int lenght);
        public event newDataReceiveHandler onNewDataReceived;

        LogMaster _logMaster;

        SerialPort port;
        bool isOpenConnect;
        byte[] buffer;
        bool isReceived = false;

        public SerialPortMaster(LogMaster logMaster)
        {
            _logMaster = logMaster;
            port = new SerialPort();
            port.DataReceived += DataReceived;
            isOpenConnect = false;
            isReceived = false;
        }

        public bool isConnectOpen()
        {
            return isOpenConnect;
        }

        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            buffer = new byte[port.BytesToRead];
            port.Read(buffer, 0, buffer.Length);
            isReceived = true;

            onNewDataReceived?.Invoke(buffer, buffer.Length);
        }

        public bool getOpenPorts(ref List<String> ports)
        {
            List<string> Ports = new List<string>();
            bool available = false;

            foreach (string str in System.IO.Ports.SerialPort.GetPortNames())
            {
                try
                {
                    ports.Add(str);
                    available = true;
                }
                catch (Exception ex)
                {
                    _logMaster.addMessage("Ошибка при сканировании!");
                }
            }

            return available;
        }

        public bool Connect(string portName)
        {
            bool isOK = false;

            port = new System.IO.Ports.SerialPort(portName);
            port.BaudRate = 9600;
            port.DataBits = 8;
            port.Open();

            if (port.IsOpen)
            {
                isOpenConnect = true;
                isOK = true;
            }

            return isOK;
        }

        public void Disconnect()
        {
            port.Close();
            isOpenConnect = false;
        }

        public void Write(byte[] data, int size)
        {
            try
            {
                port.Write(data, 0, size);

                while (port.BytesToWrite != 0) ;

                System.Threading.Thread.Sleep(5);
            }
            catch (Exception ex)
            {
                //_logMaster.addMessage("Ошибка при попытке записи в порт");
            }
        }

        public void Write(string data)
        {
            try
            {
                if (!(port.IsOpen)) port.Open();
                port.Write(data);
            }
            catch (Exception ex)
            {
                _logMaster.addMessage("Ошибка при попытке записи в порт");
            }
        }

        public byte[] Read()
        {
            if (isReceived)
                return buffer;
            else
                return null;
        }
    }
}
