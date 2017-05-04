namespace ProjectManager.Common.Providers.Contracts.Interfaces
{
    public interface IFileLogger
    {
        void Info(object message);

        void Error(object message);

        void Fatal(object message);
    }
}
