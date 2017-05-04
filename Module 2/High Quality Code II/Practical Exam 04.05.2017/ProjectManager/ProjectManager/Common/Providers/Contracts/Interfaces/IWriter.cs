namespace ProjectManager.Common.Providers.Contracts.Interfaces
{
    public interface IWriter
    {
        void Write(string text);

        void WriteLine(string text);
    }
}