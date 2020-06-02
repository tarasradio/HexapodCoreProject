namespace FrundGeneratorProject.Core
{
    public interface IFileRunner
    {
        void Run(FrundMoveFile move);
        void Terminate();
    }
}