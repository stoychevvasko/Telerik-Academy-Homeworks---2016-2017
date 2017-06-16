namespace ProjectManager.ConsoleClient
{
    using Configs;
    using Framework.Core.Common.Contracts;
    using Framework.Services;
    using Ninject;
    using ProjectManager.Configs;

    public class Startup
    {
        public static void Main()
        {
            IKernel kernel = new StandardKernel(new NinjectManagerModule());

            IConfigurationProvider configProvider = kernel.Get<IConfigurationProvider>();

            // This is an example of how to create the caching service. Think about how and where to use it in the project.
            var cacheService = new CachingService(configProvider.CacheDurationInSeconds);

            IEngine engine = kernel.Get<IEngine>();

            engine.Start();
        }
    }
}
