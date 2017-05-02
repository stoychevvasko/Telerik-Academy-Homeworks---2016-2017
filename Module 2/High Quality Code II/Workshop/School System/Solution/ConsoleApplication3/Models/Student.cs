namespace SchoolSystem.Models
{
    using System.Collections.Generic;
    using System.Linq;    

    /// <summary>Represents a student.</summary>
    public class Student
    {
        private string firstName;

        private string lastName;

        private Grade grade;

        private List<Mark> marks;

        public Student(string firstName, string lastName, Grade grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
            this.marks = new List<Mark>();
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            set
            {
                this.lastName = value;
            }
        }

        public Grade Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                this.grade = value;
            }
        }

        public List<Mark> Marks
        {
            get
            {
                return this.marks;
            }

            set
            {
                this.marks = value;
            }            
        }

        public string ListMarks()
        {
            var listOfMarks = this.Marks.Select(m => $"{m.Subject} => {m.Value}").ToList();
            return string.Join("\n", listOfMarks);
        }
    }
}
