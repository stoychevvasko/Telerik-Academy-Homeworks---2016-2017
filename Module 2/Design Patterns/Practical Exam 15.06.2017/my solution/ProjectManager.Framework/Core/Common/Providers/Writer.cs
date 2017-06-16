namespace ProjectManager.Framework.Core.Common.Providers
{
    using System;
    using Contracts;

    public class Writer : IWriter
    {
        public void Write(object value)
        {
            Console.Write(value);
        }

        public void WriteLine(object value)
        {
            Console.WriteLine(value);
        }
    }
}
