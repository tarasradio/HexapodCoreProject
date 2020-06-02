
using HexapodCoreProject.Management;
using HexapodCoreProject.Masters;
using HexapodInterfacesProject;

namespace HexapodCoreProject
{
    public class HexapodInstance
    {
        private Storage _storage;
        private Hexapod _hexapod;
        private SourceManager _sourceManager;
        private LogMaster _logger;
        private PacketMaster _packetMaster;
        private SerialPortMaster _serialPortmaster;

        public HexapodInstance(string fileName)
        {
            CreateInstances(fileName);
        }

        public void CreateInstances(string fileName)
        {
            _storage = new Storage();
            _storage.OpenFile(fileName);

            _logger = new LogMaster();
            _serialPortmaster = new SerialPortMaster(_logger);
            _packetMaster = new PacketMaster(_serialPortmaster);
            _sourceManager = new SourceManager();
            _hexapod = new Hexapod(_storage, _packetMaster, _logger);

            _logger.AddMessage("Запись работы системы начата");
        }

        public void AddMoveSource(IMoveSource moveSource)
        {
            _sourceManager.AddMovementSource(moveSource);
        }

        public LogMaster GetLogger()
        {
            return _logger;
        }

        public SerialPortMaster GetSerialPortMaster()
        {
            return _serialPortmaster;
        }

        public Storage GetStorage()
        {
            return _storage;
        }

        public Hexapod GetHexapod()
        {
            return _hexapod;
        }

        public SourceManager GetSourceManager()
        {
            return _sourceManager;
        }
        
        public void GoToStart()
        {
            _hexapod.SetAllCoxaAngle(90);
            _hexapod.SetAllFemurAngle(90);
            _hexapod.SetAllTibiaAngle(90);
        }
    }
}
