//// <copyright file="ILogger.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task2.Contracts.Interfaces
{
    /// <summary>Provides the <c>Console.WriteLine()</c> method decoupled.</summary>
    public interface ILogger
    {
        /// <summary>Writes a new line of text to the standard output.</summary><param name="message">String message to be displayed.</param>
        void WriteLine(string message);
    }
}
