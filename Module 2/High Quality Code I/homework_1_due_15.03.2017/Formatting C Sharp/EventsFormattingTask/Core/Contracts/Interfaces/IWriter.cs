////-------------------------------------------------------------------------------------------------
//// <copyright file="IWriter.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core.Contracts.Interfaces
{
    /// <summary>
    /// Provides text writing functionality.
    /// </summary>
    public interface IWriter
    {
        /// <summary>
        /// Writes a line of text on an output interface.
        /// </summary>
        /// /// <param name="message">String literal.</param>
        void WriteLine(string message);
    }
}
