namespace SchoolSystem.Models.Contracts
{
    using System.Collections.Generic;
    using Enumerations;

    /// <summary>Provides student-related functionality.</summary>
    public interface IStudent
    {
        /// <summary>Gets or sets student's grade.</summary>
        Grade Grade
        {
            get;
            set;
        }

        /// <summary>Gets or sets student's marks.</summary>
        IList<Mark> Marks
        {
            get;
            set;
        }

        /// <summary>Lists all student marks as a string value.</summary>
        /// <returns>Student marks as string.</returns>
        string ListMarks();
    }
}
