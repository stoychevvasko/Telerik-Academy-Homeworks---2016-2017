﻿////-------------------------------------------------------------------------------------------------
//// <copyright file="IdProvider.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace SchoolSystem.Core.Providers
{
    using SchoolSystem.Core.Contracts;

    /// <summary>
    /// Providers unique ids.
    /// </summary>
    public class IdProvider : IIdProvider
    {
        /// <summary>
        /// Holds the current id value;
        /// </summary>
        private static int currentId = 10000;

        /// <summary>
        /// Returns the next unique id integer.
        /// </summary>
        /// <returns>An integer value</returns>
        public int NextId()
        {
            return currentId++;
        }
    }
}
