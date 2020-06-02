using HexapodCoreProject.Interfaces;
using System;
using System.Collections.Generic;
using System.IO.Ports;

namespace HexapodCoreProject.Masters
{
    public class SerialPortMaster : IPortMaster
    {
        public delegate void NewDataReceiveHandler(byte[] data, int lenght);
        public event NewDataReceiveHandler OnNewDataReceived;

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

            OnNewDataReceived?.Invoke(buffer, buffer.Length);
        }

        public bool getOpenPorts(ref List<String> ports)
        {
            List<string> Ports = new List<string>();
            bool available = false;

            foreach (string str in SerialPort.GetPortNames())
            {
                try
                {
                    ports.Add(str);
                    available = true;
                }
                catch (Exception ex)
                {
                    _logMaster.AddMessage("Ошибка при сканировании!");
                }
            }

            return available;
        }

        public bool Connect(string portName)
        {
            bool isOK = false;

            port = new SerialPort(portName)
            {
                BaudRate = 115200,
                DataBits = 8
            };

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
            }
            catch (Exception ex)
            {
                _logMaster.AddMessage("Ошибка при попытке записи в порт");
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
                _logMaster.AddMessage("Ошибка при попытке записи в порт");
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
