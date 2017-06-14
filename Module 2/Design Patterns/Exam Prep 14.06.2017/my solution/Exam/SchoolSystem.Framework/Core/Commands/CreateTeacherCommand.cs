using System.Collections.Generic;

using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Core.Factories.Contracts;
using SchoolSystem.Framework.Models;
using SchoolSystem.Framework.Models.Contracts;
using SchoolSystem.Framework.Models.Enums;

namespace SchoolSystem.Framework.Core.Commands
{
    public class CreateTeacherCommand : ICommand
    {
        private int currentTeacherId = 0;
        private readonly ITeacherFactory teacherFactory;
        private readonly IAddTeacher addTeacher;

        public CreateTeacherCommand(ITeacherFactory teacherFactoryDependency, IAddTeacher addTeacherDependency)
        {
            this.teacherFactory = teacherFactoryDependency;
            this.addTeacher = addTeacherDependency;
        }

        public string Execute(IList<string> parameters)
        {
            var firstName = parameters[0];
            var lastName = parameters[1];
            var subject = (Subject)int.Parse(parameters[2]);

            var teacher = this.teacherFactory.CreateTeacher(firstName, lastName, subject);

            this.addTeacher.AddTeacher(currentTeacherId, teacher);

            return $"A new teacher with name {firstName} {lastName}, subject {subject} and ID {currentTeacherId++} was created.";
        }
    }
}
