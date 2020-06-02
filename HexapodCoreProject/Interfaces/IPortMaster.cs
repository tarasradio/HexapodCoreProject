namespace HexapodCoreProject.Interfaces
{
    public interface IPortMaster
    {
        void Write(byte[] data, int size);
        void Write(string data);
    }
}
