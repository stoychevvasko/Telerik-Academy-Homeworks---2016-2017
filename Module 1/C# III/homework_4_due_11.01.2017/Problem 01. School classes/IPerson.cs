////-----------------------------------------------------------------------
//// <copyright file="IPerson.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_01
{
    /// <summary>
    /// Exposes an individual's personal details, attributes and public behaviors.
    /// </summary>
    public interface IPerson
    {
        /// <summary>
        /// Gets or sets a person's full name.
        /// </summary>
        string Name
        {
            get;
            set;
        }
    }
}