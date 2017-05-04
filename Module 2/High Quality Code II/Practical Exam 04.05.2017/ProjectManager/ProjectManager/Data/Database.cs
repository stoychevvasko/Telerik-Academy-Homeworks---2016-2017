// <copyright file="Database.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>*hidden*</author>
namespace ProjectManager.Data
{
    using System.Collections.Generic;
    using Core.Contracts.Interfaces;

    /// <summary>Provides database functionality for project management purposes.</summary>
    public class Database : IDatabase
    {
        private static IList<IProject> projects;

        /// <summary>Initializes static fields.</summary>
        static Database()
        {
            projects = new List<IProject>();
        }

        /// <summary>Gets a collection of projects.</summary>
        public IList<IProject> Projects
        {
            get
            {
                return projects;
            }
        }
    }
}
