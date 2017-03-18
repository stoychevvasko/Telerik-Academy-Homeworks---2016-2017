//// <copyright file="MockConsole.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task_1_class_123_in_C_sharp.Core.Models
{
    /// <summary>Provides console-like functionality.</summary>
    internal class MockConsole
    {
        /// <summary>Maximum allowed number of items counted as per standard specifications.</summary>
        private const int MaxCount = 6;

        /// <summary>Writes <see cref="bool"/> true value as string on the <see cref="MockConsole"/>.</summary>
        public static void LogLineTrue()
        {
            MockConsole.Instance console = new MockConsole.Instance();
            console.WriteLine(true);
        }

        /// <summary>Holds the <see cref="MockConsole"/> WriteLine method for boolean values.</summary>
        private class Instance
        {
            /// <summary>Writes a boolean value as string on the standard console output.</summary><param name="booleanValue">A true or false statement.</param>
            public void WriteLine(bool booleanValue)
            {
                string stringRepresentation = booleanValue.ToString();
                System.Console.WriteLine(stringRepresentation);
            }
        }        
    }
}
