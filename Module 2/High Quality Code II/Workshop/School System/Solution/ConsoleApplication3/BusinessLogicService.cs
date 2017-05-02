namespace SchoolSystem
{
    using SchoolSystem.Core;

    // I am not sure if we need this, but too scared to delete. 
    public class BusinessLogicService
    {
        public void Execute(ConsoleReaderProvider padhana)
        {
            var injan = new Engine(padhana);
            injan.Start();
        }
    }
}
