namespace SchoolSystem.Models.Contracts
{
    using Enumerations;

    /// <summary>Provides teacher-related functionality.</summary>
    public interface ITeacher
    {
        /// <summary>Gets or sets teacher's subject.</summary>
        Subject Subject
        {
            get;
            set;
        }

        /// <summary>Awards mark to student.</summary>
        /// <param name="student">Student in subject in this teacher's class.</param>
        /// <param name="value">Value of student's mark.</param>
        void AddMark(IStudent student, float value);
    }
}
