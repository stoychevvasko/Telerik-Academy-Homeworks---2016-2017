namespace SchoolSystem.Core.Providers
{
    using System;
    using Contracts;

    public class Writer : IWriter
    {
        public void Write(string stringValue)
        {
            Console.Write(stringValue);
        }

        public void WriteLine(string stringValue)
        {
            Console.WriteLine(stringValue);
        }
    }
}
