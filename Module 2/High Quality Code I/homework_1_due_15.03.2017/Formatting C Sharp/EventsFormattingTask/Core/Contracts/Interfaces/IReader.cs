////-------------------------------------------------------------------------------------------------
//// <copyright file="IReader.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core.Contracts.Interfaces
{
    /// <summary>
    /// Provides ReadLine() support.
    /// </summary>
    public interface IReader
    {
        /// <summary>
        /// Reads a line of text input.
        /// </summary>
        /// <returns>A string literal.</returns>
        string ReadLine();
    }
}
