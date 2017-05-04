namespace ProjectManager.Common.Factories
{
    using System;
    using Bytes2you.Validation;
    using Core.Models;
    using Exceptions;
    using Models;
    using Providers;

    public class ModelsFactory
    {
        private readonly Validator validator = new Validator();

        public Project CreateProject(string name, string startingDate, string endingDate, string state)
        {
            DateTime beginning;
            DateTime end;
            var startingDateSuccessful = DateTime.TryParse(startingDate, out beginning);
            var endDateSuccessful = DateTime.TryParse(endingDate, out end);

            if (!startingDateSuccessful)
            {
                throw new UserValidationException("Failed to parse the passed starting date!");
            }

            if (!endDateSuccessful)
            {
                throw new UserValidationException("Failed to parse the passed ending date!");
            }

            var newProject = new Project(name, beginning, end, state);
            this.validator.Validate(newProject);

            return newProject;
        }

        public Task CreateTask(User owner, string name, string state)
        {
            var task = new Task(name, owner, state);
            this.validator.Validate(task);
            return task;
        }

        public User CreateUser(string username, string email)
        {
            var user = new User(username, email);
            this.validator.Validate(user);

            return user;
        }
    }
}
