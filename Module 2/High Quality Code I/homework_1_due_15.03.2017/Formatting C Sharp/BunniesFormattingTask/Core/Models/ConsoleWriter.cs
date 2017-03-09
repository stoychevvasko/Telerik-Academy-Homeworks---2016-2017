////-------------------------------------------------------------------------------------------------
//// <copyright file="ConsoleWriter.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace BunniesFormattingTask.Core.Models
{
    using System;
    using Interfaces;    

    /// <summary>
    /// Provides standard console writer functionality as per the <see cref="IWriter"/> interface contract.
    /// </summary>
    public class ConsoleWriter : IWriter
    {
        /// <summary>
        /// Writes a message appended to the same line.
        /// </summary>
        /// <param name="message">Message in string form.</param>
        public void Write(string message)
        {
            Console.Write(message);
        }

        /// <summary>
        /// Writes message appended to a new line.
        /// </summary>
        /// <param name="message">Message in string form.</param>
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
