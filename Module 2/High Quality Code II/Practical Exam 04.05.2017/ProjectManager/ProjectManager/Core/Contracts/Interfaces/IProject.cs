namespace ProjectManager.Core.Contracts.Interfaces
{
    using System;
    using System.Collections.Generic;
    using Models;
    using ProjectManager.Models;

    public interface IProject
    {
        string Name
        {
            get;
            set;
        }

        DateTime StartingDate
        {
            get;
            set;
        }

        DateTime EndingDate
        {
            get;
            set;
        }

        string State
        {
            get;
            set;
        }

        List<User> Users
        {
            get;
            set;
        }

        List<Task> Tasks
        {
            get;
            set;
        }
    }
}
