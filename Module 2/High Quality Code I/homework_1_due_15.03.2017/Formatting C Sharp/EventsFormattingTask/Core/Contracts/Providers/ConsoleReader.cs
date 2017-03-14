////-------------------------------------------------------------------------------------------------
//// <copyright file="ConsoleReader.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core.Contracts.Providers
{
    using System;
    using Core.Contracts.Interfaces;

    /// <summary>
    /// Provides console-reading capabilities.
    /// </summary>
    public class ConsoleReader : IReader
    {
        /// <summary>
        /// Reads a line of text from the console.
        /// </summary>
        /// <returns>A string literal.</returns>
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
