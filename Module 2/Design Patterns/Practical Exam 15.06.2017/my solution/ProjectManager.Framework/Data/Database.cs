namespace ProjectManager.Data
{
    using System.Collections.Generic;
    using Framework.Data;
    using Framework.Data.Models;

    // You are not allowed to modify this class (not even to remove this comment)
    public class Database : IDatabase
    {
        private IList<Project> projects;

        public Database()
        {
            this.projects = new List<Project>();
        }

        public IList<Project> Projects
        {
            get
            {
                return this.projects;
            }
        }
    }
}
