namespace ProjectManager.ConsoleClient.Interceptors
{
    using System;
    using Framework.Core.Common.Contracts;
    using Framework.Core.Common.Exceptions;
    using Ninject.Extensions.Interception;

    public class CatchExceptionInterceptor : IInterceptor
    {
        private readonly IWriter writer;
        private readonly ILogger logger;

        public CatchExceptionInterceptor(IWriter writerDependency, ILogger loggerDependency)
        {
            this.writer = writerDependency;
            this.logger = loggerDependency;
        }

        public void Intercept(IInvocation invocation)
        {
            try
            {
                invocation.Proceed();
            }
            catch (UserValidationException ex)
            {
                this.logger.Error(ex.Message);
                this.writer.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                this.writer.WriteLine("Opps, something happened. Check the log file :(");
                this.logger.Error(ex.Message);
            }
        }
    }
}
