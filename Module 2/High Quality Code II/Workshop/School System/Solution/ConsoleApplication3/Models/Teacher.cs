namespace SchoolSystem
{
    using Models;
    using Models.Abstract;
    using Models.Contracts;
    using Models.Enumerations;

    /// <summary>Represents a teacher.</summary>
    public class Teacher : Person, IPerson, ITeacher
    {
        private Subject subject;

        /// <summary>Initializes a new instance of the <see cref="Teacher"/> class.</summary>
        /// <param name="firstName">Teacher's first name.</param>
        /// <param name="lastName">Teacher's last name.</param>
        /// <param name="subject">Teacher's subject.</param>
        public Teacher(string firstName, string lastName, Subject subject)
            : base(firstName, lastName)
        {
            this.subject = subject;
        }        

        /// <summary>Gets or sets teacher's subject.</summary>
        public Subject Subject
        {
            get
            {
                return this.subject;
            }

            set
            {
                this.subject = value;
            }
        }

        public void AddMark(IStudent student, float value)
        {
            var newMark = new Mark(this.Subject, value);
            student.Marks.Add(newMark);
        }
    }
}