namespace ProjectManager.Common.Providers
{
    using Contracts.Interfaces;
    using log4net;

    public class FileLogger : IFileLogger
    {
        private static ILog log;

        static FileLogger()
        {
            log = LogManager.GetLogger(typeof(FileLogger));
        }

        public void Info(object message)
        {
            log.Info(message);
        }

        public void Error(object message)
        {
            log.Error(message);
        }

        public void Fatal(object message)
        {
            log.Fatal(message);
        }
    }
}
