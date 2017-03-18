//// <copyright file="DateTimeProvider.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Minesweeper.Core.Providers
{
    using System;

    /// <summary>Provides fuzzy rounded <see cref="DateTime.Now"/> clones.</summary>
    internal abstract class DateTimeProvider
    {
        /// <summary>Gets newly-created fuzzy clone of <seealso cref="DateTime.Now"/>.</summary>
        public static DateTime Now
        {
            get
            {
                var now = DateTime.Now;
                return new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);
            }
        }
    }
}
