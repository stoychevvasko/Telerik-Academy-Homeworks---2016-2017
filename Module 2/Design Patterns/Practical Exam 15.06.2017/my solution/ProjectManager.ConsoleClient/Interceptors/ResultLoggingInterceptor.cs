namespace ProjectManager.ConsoleClient.Interceptors
{
    using Bytes2you.Validation;
    using Framework.Core.Common.Contracts;
    using Ninject.Extensions.Interception;

    public class ResultLoggingInterceptor : IInterceptor
    {
        private readonly IWriter writer;

        public ResultLoggingInterceptor(IWriter writerDependency)
        {
            Guard.WhenArgument(writerDependency, "Writer provider").IsNull().Throw();
            this.writer = writerDependency;
        }

        public void Intercept(IInvocation invocation)
        {
            invocation.Proceed();
            this.writer.WriteLine(invocation.ReturnValue);
        }
    }
}
