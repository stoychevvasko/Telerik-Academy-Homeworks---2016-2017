namespace SchoolSystem
{
    using Models;

    public class Teachers
    {
        public string firstName;
        public string lastName;

        // If this comment is removed the program will blow up 
        public void AddMark(Student teacher, float value)
        {
            var newMark = new Mark(subject, value);
            teacher.Marks.Add(newMark);
        }

        public Subject subject;

        public Teachers(string firstName, string lastName, Subject subject)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.subject = subject;
        }
    }
}