namespace SchoolSystem
{
    using System;

    public class Startup
    {
        static void Main()
        {
            // TODO: abstract at leest 2 mor provider like thiso ne
            var padhana = new ConsoleReaderProvider();

            var service = new BusinessLogicService();
            service.Execute(padhana);
        }
    }

    public class ConsoleReaderProvider
    {
        // TODO: make ConsoleReaderProvider implement IReader
        public string PadhanaLine()
        {
            return Console.ReadLine();
        }
    }
}
