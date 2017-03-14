////-------------------------------------------------------------------------------------------------
//// <copyright file="CommandParser.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core.Contracts.Providers
{
    using System;
    using Core.Contracts.Interfaces;
    using Core.Factories;

    /// <summary>
    /// Provides command parsing capabilities.
    /// </summary>
    public class CommandParser : IParser
    {
        /// <summary>
        /// Parses a command string into an <see cref="ICommand"/>-like object.
        /// </summary>
        /// <param name="command">Command literal.</param>
        /// <returns>Parsed command.</returns>
        public ICommand ParseCommand(string command)
        {
            if (command[0] != 'A' && command[0] != 'D' && command[0] != 'L')
            {
                if (command[0] == 'E')
                {
                    throw new ArgumentException("end of command line entry requested");
                }

                throw new ArgumentException($"invalid command {command}");
            }            

            var commandInstance = CoreFactory.Instance.CreateCommand(command);
            return commandInstance;
        }        
    }
}
