////-------------------------------------------------------------------------------------------------
//// <copyright file="CoreFactory.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core.Factories
{
    using System;
    using Core.Commands;
    using Core.Contracts.Interfaces;    

    /// <summary>
    /// Produces new instances from all class definitions relevant to the project.
    /// </summary>
    public class CoreFactory : IFactory
    {
        /// <summary>
        /// Holds core factory singleton instance.
        /// </summary>
        private static IFactory instanceHolder = new CoreFactory();

        /// <summary>
        /// Prevents a default instance of the <see cref="CoreFactory"/> class from being created.
        /// </summary>
        private CoreFactory()
        {
        }

        /// <summary>
        /// Gets the core factory singleton instance.
        /// </summary>
        public static IFactory Instance
        {
            get
            {
                return instanceHolder;
            }
        }

        /// <summary>
        /// Gets a new <see cref="ICommand"/>-like object instance.
        /// </summary>
        /// <param name="command">A string command literal.</param>
        /// <returns>A new object of the <see cref="ICommand"/> interface.</returns>
        public ICommand CreateCommand(string command)
        {
            if (command[0] == 'E')
            {
                throw new ArgumentException("end of command line entry requested");
            }
            else if (command[0] == 'A')
            {
                return new AddEventCommand(command);
            }
            else if (command[0] == 'D')
            {
                return new DeleteEventsCommand(command);
            }
            else if (command[0] == 'L')
            {
                return new ListEventsCommand(command);
            }
            else
            {
                throw new ArgumentException("invalid command literal");
            }
        }        
    }
}
