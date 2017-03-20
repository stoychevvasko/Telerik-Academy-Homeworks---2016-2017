//// <copyright file="ConsoleLogger.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task2.Contracts.Providers
{
    using System;
    using Interfaces;

    /// <summary>Provides standard string output functionality.</summary>
    public class ConsoleLogger : ILogger
    {
        /// <summary>Exposes the <c>Console.WriteLine()</c> method in a decoupled way.</summary>
        /// <param name="message">Message to display.</param>
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
