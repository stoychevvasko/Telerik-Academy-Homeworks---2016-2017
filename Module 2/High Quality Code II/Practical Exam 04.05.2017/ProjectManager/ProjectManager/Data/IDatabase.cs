// <copyright file="IDatabase.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>*hidden*</author>
namespace ProjectManager.Data
{
    using System.Collections.Generic;
    using Core.Contracts.Interfaces;

    /// <summary>Exposes a collection of projects for get-only purposes.</summary>
    public interface IDatabase
    {
        /// <summary>Gets collection of projects</summary>
        IList<IProject> Projects { get; }
    }
}
