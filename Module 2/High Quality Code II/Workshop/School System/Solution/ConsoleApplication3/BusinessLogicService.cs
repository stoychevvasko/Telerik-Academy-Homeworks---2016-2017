namespace SchoolSystem
{
    using Core;
    using Core.Contracts;
    using Core.Providers;

    // I am not sure if we need this, but too scared to delete. 
    public class BusinessLogicService
    {
        public void Execute(IReader reader, IWriter writer)
        {
            var engine = new Engine(reader, writer);
            engine.Start();
        }
    }
}
