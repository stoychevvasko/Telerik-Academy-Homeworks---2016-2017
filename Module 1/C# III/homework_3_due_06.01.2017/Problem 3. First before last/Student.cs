namespace Problem_03
{
    /// <summary>
    /// Represents a student.
    /// </summary>
    public class Student
    {        
        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="firstName">Student's first name.</param>
        /// <param name="lastName">Student's surname.</param>
        /// <param name="age">Student age.</param>
        public Student(string firstName, string lastName, byte age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        public Student()
            : this("NoName", "NoLastName", 255)
        {
        }

        /// <summary>
        /// Represents a student's first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents a student's last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents a student's age.
        /// </summary>
        public byte Age { get; set; }
    }
}
