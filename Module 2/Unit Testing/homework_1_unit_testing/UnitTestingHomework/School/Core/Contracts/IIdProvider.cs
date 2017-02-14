////-------------------------------------------------------------------------------------------------
//// <copyright file="IIdProvider.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-------------------------------------------------------------------------------------------------
namespace SchoolSystem.Core.Contracts
{
    /// <summary>
    /// Provides unique id-related functionality.
    /// </summary>
    public interface IIdProvider
    {
        /// <summary>
        /// Gets next unique id.
        /// </summary>
        /// <returns>Unique id number as integer.</returns>
        int NextId();
    }
}
