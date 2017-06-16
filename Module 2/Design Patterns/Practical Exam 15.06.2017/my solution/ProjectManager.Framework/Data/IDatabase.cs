namespace ProjectManager.Framework.Data
{
    using System.Collections.Generic;
    using Models;

    public interface IDatabase
    {
        IList<Project> Projects { get; }
    }
}
