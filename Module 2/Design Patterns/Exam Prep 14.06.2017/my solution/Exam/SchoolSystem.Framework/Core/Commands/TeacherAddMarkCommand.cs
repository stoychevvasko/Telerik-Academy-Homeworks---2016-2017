﻿using System.Collections.Generic;

using SchoolSystem.Framework.Core.Commands.Contracts;
using SchoolSystem.Framework.Models.Contracts;

namespace SchoolSystem.Framework.Core.Commands
{
    public class TeacherAddMarkCommand : ICommand
    {
        private readonly IGetStudentAndTeacher getStudentAndTeacher;

        public TeacherAddMarkCommand(IGetStudentAndTeacher getTeacherAndStudentDependency)
        {
            this.getStudentAndTeacher = getTeacherAndStudentDependency;            
        }

        public string Execute(IList<string> parameters)
        {
            var teacherId = int.Parse(parameters[0]);
            var studentId = int.Parse(parameters[1]);
            var mark = float.Parse(parameters[2]);

            var student = this.getStudentAndTeacher.GetStudent(studentId);
            var teacher = this.getStudentAndTeacher.GetTeacher(teacherId);

            teacher.AddMark(student, mark);
            return $"Teacher {teacher.FirstName} {teacher.LastName} added mark {mark} to student {student.FirstName} {student.LastName} in {teacher.Subject}.";
        }
    }
}
