// <copyright file="IModelsFactory.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>*hidden*</author>
namespace ProjectManager.Common.Factories.Contracts.Interfaces
{
    using Core.Models;
    using Models;

    /// <summary>Exposes factory functionality for the models in the current project.</summary>
    public interface IModelsFactory
    {
        /// <summary>Creates a new project instance.</summary>
        /// <param name="name">Project name.</param>
        /// <param name="startingDate">Starting date of project.</param>
        /// <param name="endingDate">Ending date of project.</param>
        /// <param name="state">Current project state.</param>
        /// <returns>New project instance.</returns>
        Project CreateProject(string name, string startingDate, string endingDate, string state);

        /// <summary>Creates a new task instance.</summary>
        /// <param name="owner">Task owner name.</param>
        /// <param name="name">Task name.</param>
        /// <param name="state">Current task state.</param>
        /// <returns>A new task instance.</returns>
        Task CreateTask(User owner, string name, string state);

        /// <summary>Creates a new user instance.</summary>
        /// <param name="username">User's username.</param>
        /// <param name="email">User email.</param>
        /// <returns>A new user instance.</returns>
        User CreateUser(string username, string email);
    }
}
