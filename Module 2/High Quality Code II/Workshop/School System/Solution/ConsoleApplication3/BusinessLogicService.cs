namespace SchoolSystem
{
    using Core;
    using Core.Providers;    

    // I am not sure if we need this, but too scared to delete. 
    public class BusinessLogicService
    {
        public void Execute(Reader reader)
        {
            var engine = new Engine(reader);
            engine.Start();
        }
    }
}
