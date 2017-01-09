using System.Collections.Generic;

namespace Problem_01
{
    /// <summary>
    /// Reveals, expands or limits a teacher's set of disciplines taught.
    /// </summary>
    interface ITeacher
    {
        /// <summary>
        /// Returns the set of disciplines taught by a teacher.
        /// </summary>
        HashSet<Discipline> Disciplines
        {
            get;
            set;
        }  
    }
}
