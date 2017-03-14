////-------------------------------------------------------------------------------------------------
//// <copyright file="IEngine.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core.Contracts.Interfaces
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Provides engine-related capabilities.
    /// </summary>
    public interface IEngine
    {
        /// <summary>
        /// Gets or sets the engine parser.
        /// </summary>
        IParser Parser { get; set; }

        /// <summary>
        /// Gets or sets the engine reader.
        /// </summary>
        IReader Reader { get; set; }

        /// <summary>
        /// Gets or sets the engine writer
        /// </summary>
        IWriter Writer { get; set; }

        /// <summary>
        /// Sets the engine in motion.
        /// </summary>        
        void Start();

        /// <summary>
        /// Lists all events from the engine.
        /// </summary>
        /// <param name="date">Event date.</param>
        /// <param name="count">Number of events.</param>
        void ListEvents(DateTime date, int count);

        /// <summary>
        /// Adds a new event.
        /// </summary>
        /// <param name="date">Event date.</param>
        /// <param name="title">Event title.</param>
        /// <param name="location">Event location.</param>
        void AddEvent(DateTime date, string title, string location);

        /// <summary>
        /// Deletes events by title.
        /// </summary>
        /// <param name="titleToDelete">Event title.</param>
        void DeleteEvents(string titleToDelete);
    }
}
