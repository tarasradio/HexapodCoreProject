using HexapodInterfacesProject;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System;

namespace RealtimeGeneratorProject.Core
{
    public class TrajectoryReceiver
    {
        IRobot hexapod;
        ILogger logger;

        Socket frundSocket;

        byte[] buffer = new byte[300 * 8];

        EndPoint frundEndPoint = new IPEndPoint(IPAddress.Any, 0);

        private Thread thread;

        public TrajectoryReceiver(IRobot hexapod, ILogger logger)
        {
            this.hexapod = hexapod;
            this.logger = logger;

            frundSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
        }

        public void Run(int port)
        {
            IPEndPoint localIP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);
            if(!frundSocket.IsBound)
                frundSocket.Bind(localIP);

            thread = new Thread(FrundExchange);
            thread.IsBackground = true;
            thread.Start();
        }

        public void Terminate()
        {
            thread.Abort();
        }

        const int bytesPerJoint = 2;

        private void FrundExchange()
        {
            while(true)
            {
                int bytes = frundSocket.ReceiveFrom(buffer, ref frundEndPoint);

                Console.WriteLine($"Received {bytes} bytes.");

                float time = BitConverter.ToSingle(buffer, 0);

                Console.WriteLine($"Time = {time}");

                for(int i = 0; i < 18; i++)
                {
                    int jointNumber = (int)BitConverter.ToSingle(buffer, i * sizeof(float) * bytesPerJoint + 4);
                    double angle = BitConverter.ToSingle(buffer, i * sizeof(float) * bytesPerJoint + 8);

                    int angleDegrees = ConvertToDegrees(angle);

                    hexapod.SetAngle(jointNumber, angleDegrees, true);
                    //Console.WriteLine($"joint[{jointNumber}] = {angleDegrees};");
                }

                // Ответный покет отправлять не нужно
                //bytes = _socket.SendTo(_buffer, remoteIp);

                //Console.WriteLine($"Sended {bytes} bytes.");
            }
        }

        private static int ConvertToDegrees(double angle)
        {
            int angleDegrees = (int)((180.0 / Math.PI) * angle);

            angleDegrees *= -1;
            angleDegrees += 90;

            return angleDegrees;
        }
    }
}
