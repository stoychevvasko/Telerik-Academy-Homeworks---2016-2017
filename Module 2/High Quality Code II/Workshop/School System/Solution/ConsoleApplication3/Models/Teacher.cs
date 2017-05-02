namespace SchoolSystem
{
    using Models;
    using Models.Enumerations;

    public class Teacher
    {
        private string firstName;

        private string lastName;

        private Subject subject;

        public Teacher(string firstName, string lastName, Subject subject)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.subject = subject;
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

        public void AddMark(Student teacher, float value)
        {
            var newMark = new Mark(this.Subject, value);
            teacher.Marks.Add(newMark);
        }
    }
}