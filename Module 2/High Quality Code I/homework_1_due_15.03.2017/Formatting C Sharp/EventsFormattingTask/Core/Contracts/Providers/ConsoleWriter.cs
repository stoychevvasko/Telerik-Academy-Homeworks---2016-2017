////-------------------------------------------------------------------------------------------------
//// <copyright file="ConsoleWriter.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core.Contracts.Providers
{
    using System;
    using Core.Contracts.Interfaces;

    /// <summary>
    /// Provides text writing functionality via standard console.
    /// </summary>
    public class ConsoleWriter : IWriter
    {
        /// <summary>
        /// Writes a line of text on the console.
        /// </summary>
        /// <param name="message">String literal.</param>
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
