////-------------------------------------------------------------------------------------------------
//// <copyright file="Engine.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core
{
    using System;
    using System.Text;
    using Core.Assets;
    using Core.Contracts.Interfaces;
    using Core.Contracts.Providers;
    using Core.Factories;
    using Core.Models;

    /// <summary>
    /// Engine for command line execution.
    /// </summary>
    public class Engine : IEngine
    {
        /// <summary>
        /// Holds engine singleton instance.
        /// </summary>
        private static IEngine instanceHolder = new Engine();

        /// <summary>
        /// Holds all event items.
        /// </summary>
        private static EventHolder events = new EventHolder();

        /// <summary>
        /// Holds engine operations output.
        /// </summary>
        private static StringBuilder output = new StringBuilder();

        /// <summary>
        /// Prevents a default instance of the <see cref="Engine"/> class from being created.
        /// </summary>
        private Engine()
        {
            this.Parser = new CommandParser();
            this.Reader = new ConsoleReader();
            this.Writer = new ConsoleWriter();
        }

        /// <summary>
        /// Gets the engine singleton instance.
        /// </summary>
        public static IEngine Instance
        {
            get
            {
                return Engine.instanceHolder;
            }
        }

        /// <summary>
        /// Gets or sets the engine parser.
        /// </summary>
        public IParser Parser
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the engine reader.
        /// </summary>
        public IReader Reader
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the engine writer.
        /// </summary>
        public IWriter Writer
        {
            get;
            set;
        }

        /// <summary>
        /// Sets the engine in motion.
        /// </summary>
        public void Start()
        {
            while (Engine.ExecuteNextCommand())
            {
            }

            Engine.Instance.Writer.WriteLine(Messages.Output);
        }

        /// <summary>
        /// Lists all events.
        /// </summary>
        /// <param name="date">Date parameter.</param>
        /// <param name="count">Count parameter.</param>
        public void ListEvents(DateTime date, int count)
        {
            Engine.events.ListEvents(date, count);
        }

        /// <summary>
        /// Adds a new event.
        /// </summary>
        /// <param name="date">Event date.</param>
        /// <param name="title">Event title.</param>
        /// <param name="location">Event location.</param>
        public void AddEvent(DateTime date, string title, string location)
        {
            Engine.events.AddEvent(date, title, location);
        }

        /// <summary>
        /// Deletes events by title.
        /// </summary>
        /// <param name="titleToDelete">Event title.</param>
        public void DeleteEvents(string titleToDelete)
        {
            Engine.events.DeleteEvents(titleToDelete);
        }

        /// <summary>
        /// Executes the next command.
        /// </summary>
        /// <returns>A <see cref="bool"/> result indicating command execution status.</returns>
        private static bool ExecuteNextCommand()
        {
            string command = Engine.Instance.Reader.ReadLine();
            try
            {
                var commandObject = CoreFactory.Instance.CreateCommand(command);
                commandObject.Execute();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
