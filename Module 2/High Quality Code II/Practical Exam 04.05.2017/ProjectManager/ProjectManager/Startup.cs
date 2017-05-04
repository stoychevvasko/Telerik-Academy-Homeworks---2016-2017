namespace ProjectManager
{
    using Common;
    using Common.Factories;
    using Common.Providers;
    using Core.Models;
    using Data;

    public class Startup
    {
        public static void Main()
        {
            var newEngine = new Engine(
                new FileLogger(),
                new CommandProcessor(
                    new CommandsFactory(
                        new Database(),
                        new ModelsFactory())),
                new Reader(),
                new Writer());

            var provider = new EnginePRovider(newEngine);
            provider.Start();
        }
    }
}
