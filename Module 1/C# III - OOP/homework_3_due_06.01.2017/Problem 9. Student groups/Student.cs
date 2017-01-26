using System.Collections.Generic;

namespace Problem_09
{
    /// <summary>
    /// Represents a student.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Represents a <see cref="Student"/>'s given name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Represents a <see cref="Student"/>'s surname.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Represents a <see cref="Student"/>'s faculty number.
        /// </summary>
        public string FN { get; set; }

        /// <summary>
        /// Represents a <see cref="Student"/>'s telephone number.
        /// </summary>
        public string Tel { get; set; }

        /// <summary>
        /// Represents a <see cref="Student"/>'s email address.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Represents a <see cref="Student"/>'s marks/grades.
        /// </summary>
        public List<int> Marks { get; set; }

        /// <summary>
        /// Represents a <see cref="Student"/>'s group number.
        /// </summary>
        public int GroupNumber { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        /// <param name="fName"><see cref="Student"/>'s first name.</param>
        /// <param name="lName"><see cref="Student"/>'s last name.</param>
        /// <param name="fN"><see cref="Student"/>'s faculty number.</param>
        /// <param name="tel"><see cref="Student"/>'s phone number.</param>
        /// <param name="email"><see cref="Student"/>'s email address.</param>
        /// <param name="marks"><see cref="Student"/>'s marks/grades.</param>
        /// <param name="groupNumber"><see cref="Student"/>'s group number.</param>
        public Student(string fName, string lName, string fN, string tel, string email, List<int> marks, int groupNumber)
        {
            this.FirstName = fName;
            this.LastName = lName;
            this.FN = fN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Student"/> class.
        /// </summary>
        public Student()
            : this("NoName", "NoLastName", "", "", "", new List<int>(), 0)
        {
        }
    }
}
