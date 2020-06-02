namespace HexapodInterfacesProject
{
    public interface IMoveSource
    {
        string Name { get; }
        void Enable();
        void Disable();
    }
}
