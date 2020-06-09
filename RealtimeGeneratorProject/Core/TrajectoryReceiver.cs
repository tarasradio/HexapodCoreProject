using HexapodInterfacesProject;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System;

namespace RealtimeGeneratorProject.Core
{
    public class TrajectoryReceiver
    {
        IRobot _hexapod;
        ILogger _logger;

        Socket _socket;

        byte[] _buffer = new byte[300 * 8];

        EndPoint _frund = new IPEndPoint(IPAddress.Any, 0);

        private Thread _runThread;

        public TrajectoryReceiver(IRobot hexapod, ILogger logger)
        {
            _hexapod = hexapod;
            _logger = logger;

            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }

        public void Run(int port)
        {
            IPEndPoint localIP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            if(!_socket.IsBound)
                _socket.Bind(localIP);

            _runThread = new Thread(threadFunction);
            _runThread.Start();
        }

        public void Terminate()
        {
            _runThread.Abort();
        }

        const int bytesPerJoint = 2;

        private void threadFunction()
        {
            while(true)
            {
                int bytes = _socket.ReceiveFrom(_buffer, ref _frund);

                Console.WriteLine($"Received {bytes} bytes.");

                float time = BitConverter.ToSingle(_buffer, 0);

                Console.WriteLine($"Time = {time}");

                for(int i = 0; i < 18; i++)
                {
                    int jointNumber = (int)BitConverter.ToSingle(_buffer, i * sizeof(float) * bytesPerJoint + 4);
                    double angle = BitConverter.ToSingle(_buffer, i * sizeof(float) * bytesPerJoint + 8);
                    
                    int angleDegrees = (int)((180.0 / Math.PI) * angle);

                    angleDegrees *= -1;
                    angleDegrees += 90;

                    _hexapod.SetAngle(jointNumber, angleDegrees, true);
                    //Console.WriteLine($"joint[{jointNumber}] = {angleDegrees};");
                }

                // Ответный покет отправлять не нужно
                //bytes = _socket.SendTo(_buffer, remoteIp);

                //Console.WriteLine($"Sended {bytes} bytes.");
            }
        }
    }
}
