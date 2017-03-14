////-------------------------------------------------------------------------------------------------
//// <copyright file="IEvent.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace EventsFormattingTask.Core.Contracts.Interfaces
{
    using System;

    /// <summary>
    /// Provides event functionality.
    /// </summary>
    public interface IEvent
    {
        /// <summary>
        /// Gets or sets the date value of the the event.
        /// </summary>
        DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the title value of the event.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets the location value of this event.
        /// </summary>
        string Location { get; set; }

        /// <summary>
        /// Compares for difference one <see cref="IEvent"/>-like object against another.
        /// </summary>
        /// <param name="obj">The target <see cref="IEvent"/>-like object subject to comparison.</param>
        /// <returns>Result value from the comparison performed.</returns>
        int CompareTo(object obj);

        /// <summary>
        /// Represents an <see cref="IEvent"/>-like object in <see cref="string"/> form.
        /// </summary>
        /// <returns>A new <see cref="string"/>.</returns>
        string ToString();
    }
}
