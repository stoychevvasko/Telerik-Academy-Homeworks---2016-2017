using System;
using SchoolSystem.Framework.Core.Factories.Contracts;
using SchoolSystem.Framework.Models.Abstractions;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;

namespace SchoolSystem.Framework.Models
{
    public class Teacher : Person, ITeacher
    {
        private readonly IMarkFactory markFactory;

        public const int MaxStudentMarksCount = 20;

        public Teacher(string firstName, string lastName, Subject subject, IMarkFactory markFactoryDependency)
            : base(firstName, lastName)
        {
            this.markFactory = markFactoryDependency;
            this.Subject = subject;
        }

        public Subject Subject { get; set; }

        public void AddMark(IStudent student, float mark)
        {
            if (student.Marks.Count >= MaxStudentMarksCount)
            {
                throw new ArgumentException($"The student's marks count exceed the maximum count of {MaxStudentMarksCount} marks");
            }

            var newMark = this.markFactory.CreateMark(this.Subject, mark);
            student.Marks.Add(newMark);
        }
    }
}
