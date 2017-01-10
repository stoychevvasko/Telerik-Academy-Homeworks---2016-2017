////-----------------------------------------------------------------------
//// <copyright file="IClassNumber.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_01
{
    /// <summary>
    /// Exposes the unique id number property.
    /// </summary>
    public interface IClassNumber
    {
        /// <summary>
        /// Gets or sets the unique id number of a class at school.
        /// </summary>
        int ClassNumber
        {
            get;
            set;
        }
    }
}
