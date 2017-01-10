using System.Collections.Generic;

namespace Problem_01
{
    /// <summary>
    /// Provides school-class-specific collections - teachers and students, and a class-specific identifier.
    /// </summary>
    interface ISchoolClass
    {
        /// <summary>
        /// Represents the set of teachers assigned to a class.
        /// </summary>
        ICollection<Teacher> Teachers
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the set of students assigned to a class.
        /// </summary>
        ICollection<Student> Students
        {
            get;
            set;
        }

        /// <summary>
        /// Represents the unique text identifier of a school class.
        /// </summary>
        string UniqueID
        {
            get;
        }
    }
}
