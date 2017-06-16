namespace ProjectManager.Configs
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using ConsoleClient.Configs;
    using ConsoleClient.Interceptors;
    using Data;
    using Framework.Core;
    using Framework.Core.Commands.Contracts;
    using Framework.Core.Commands.Creational;
    using Framework.Core.Commands.Listing;
    using Framework.Core.Common.Contracts;
    using Framework.Core.Common.Providers;
    using Framework.Data;
    using Ninject;
    using Ninject.Extensions.Conventions;
    using Ninject.Extensions.Factory;
    using Ninject.Extensions.Interception.Infrastructure.Language;
    using Ninject.Modules;

    public class NinjectManagerModule : NinjectModule
    {
        public override void Load()
        {
            Kernel.Bind(x =>
            {
                x.FromAssembliesInPath(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location))
                .SelectAllClasses()
                .Where(type =>
                    type != typeof(Engine) &&
                    type != typeof(Database))
                .BindDefaultInterface();
            });

            this.Bind<IEngine>().To<Engine>().InSingletonScope();
            this.Bind<IDatabase>().To<Database>().InSingletonScope();

            IConfigurationProvider configurationProvider = Kernel.Get<IConfigurationProvider>();

            this.Bind<ILogger>().To<FileLogger>().InSingletonScope().WithConstructorArgument(configurationProvider.LogFilePath);
            var processorBinding = Bind<IProcessor>().To<CommandProcessor>().InSingletonScope();
            processorBinding.Intercept().With<ResultLoggingInterceptor>();
            processorBinding.Intercept().With<CatchExceptionInterceptor>();

            this.Bind<ICommandsFactory>().ToFactory().InSingletonScope();

            this.Bind<CreateProjectCommand>().ToSelf().InSingletonScope();
            this.Bind<CreateTaskCommand>().ToSelf().InSingletonScope();
            this.Bind<CreateUserCommand>().ToSelf().InSingletonScope();
            this.Bind<ListProjectDetailsCommand>().ToSelf().InSingletonScope();
            this.Bind<ListProjectsCommand>().ToSelf().InSingletonScope();

            Bind<ICommand>().ToMethod(context =>
            {
                Type commandType = (Type)context.Parameters.Single().GetValue(context, null);
                return (ICommand)context.Kernel.Get(commandType);
            }).NamedLikeFactoryMethod((ICommandsFactory commandFactory) => commandFactory.GetCommand(null));
        }
    }
}
