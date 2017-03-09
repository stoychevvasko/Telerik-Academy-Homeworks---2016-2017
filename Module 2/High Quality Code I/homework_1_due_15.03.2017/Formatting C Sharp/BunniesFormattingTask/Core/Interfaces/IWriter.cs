////-------------------------------------------------------------------------------------------------
//// <copyright file="IWriter.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace BunniesFormattingTask.Core.Interfaces
{
    /// <summary>
    /// Provides writer-related functionality.
    /// </summary>
    public interface IWriter
    {
        /// <summary>
        /// Writes a message appended to the same line.
        /// </summary>
        /// <param name="message">Message in string form.</param>
        void Write(string message);

        /// <summary>
        /// Writes message appended to a new line.
        /// </summary>
        /// <param name="message">Message in string form.</param>
        void WriteLine(string message);
    }
}
