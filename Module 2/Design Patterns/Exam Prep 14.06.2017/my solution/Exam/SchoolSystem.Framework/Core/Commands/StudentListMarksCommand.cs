using System.Collections.Generic;
using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Models.Contracts;

namespace SchoolSystem.Framework.Core.Commands
{
    public class StudentListMarksCommand : ICommand
    {
        private readonly IGetStudent getStudent;

        public StudentListMarksCommand(IGetStudent getStudentDependency)
        {
            this.getStudent = getStudentDependency;
        }

        public string Execute(IList<string> parameters)
        {
            var studentId = int.Parse(parameters[0]);
            var student = this.getStudent.GetStudent(studentId);
            return student.ListMarks();
        }
    }
}
