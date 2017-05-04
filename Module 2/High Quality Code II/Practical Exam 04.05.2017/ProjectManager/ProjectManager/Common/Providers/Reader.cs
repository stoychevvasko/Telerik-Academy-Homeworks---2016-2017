namespace ProjectManager.Common.Providers
{
    using System;
    using Contracts.Interfaces;

    public class Reader : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
