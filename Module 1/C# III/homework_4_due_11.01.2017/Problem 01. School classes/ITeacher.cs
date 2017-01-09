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
        ICollection<Discipline> Disciplines
        {
            get;
        }

        /// <summary>
        /// Adds a new discipline.
        /// </summary>
        /// <param name="discipline">A <see cref="string"/>.</param>
        void AddDiscipline(Discipline discipline);

        /// <summary>
        /// Removes a discipline.
        /// </summary>
        /// <param name="discipline"></param>
        void RemoveDiscipline(Discipline discipline);        
    }
}
