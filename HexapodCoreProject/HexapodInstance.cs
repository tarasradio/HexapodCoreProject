
using HexapodCoreProject.Management;
using HexapodCoreProject.Masters;
using HexapodInterfacesProject;

namespace HexapodCoreProject
{
    public class HexapodInstance
    {
        private Storage storage;
        private Hexapod hexapod;
        public SourceManager SrcManager { get; set; }
        private Logger logger;
        private PacketMaster packetMaster;
        private SerialPortMaster serialPortMaster;

        public HexapodInstance(string fileName)
        {
            CreateInstances(fileName);
        }

        public void CreateInstances(string fileName)
        {
            logger = new Logger();

            storage = new Storage();
            storage.OpenFile(fileName);

            serialPortMaster = new SerialPortMaster(logger);
            packetMaster = new PacketMaster(serialPortMaster);
            SrcManager = new SourceManager();
            hexapod = new Hexapod(storage, packetMaster, logger);

            logger.AddMessage("Запись работы системы начата");
        }

        public void AddMoveSource(IMoveSource moveSource)
        {
            SrcManager.AddMovementSource(moveSource);
        }

        public Logger GetLogger()
        {
            return logger;
        }

        public SerialPortMaster GetSerialPortMaster()
        {
            return serialPortMaster;
        }

        public Storage GetStorage()
        {
            return storage;
        }

        public Hexapod GetHexapod()
        {
            return hexapod;
        }
		
        public void GoToStart()
        {
            foreach (var servo in storage.Settings.Servos)
                hexapod.ServoSetAngle(servo.Key, 90);
        }
    }
}
