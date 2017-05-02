namespace SchoolSystem
{
    using System;
    using System.Collections.Generic;
    using Core;
    using Core.Contracts;

    public class CreateTeacherCommand : ICommand
    {
        public string Execute(IList<string> para)
        {
            // TODO: too drunk, implement later
            throw new NotImplementedException();
        }
    }

    public class RemoveStudentCommand : ICommand
    {
        public string Execute(IList<string> paras)
        {
            Engine.students.Remove(int.Parse(paras[0]));
            return $"Student with ID {int.Parse(paras[0])} was sucessfully removed.";
        }
    }

    public class CreateStudentCommand
    {
        public static int id = 0;
        public string Execute(IList<string> para)
        {
            Engine.students.Add(id, new SchoolSystem.Models.Student(para[0], para[1], (Grade)int.Parse(para[2])));
            return $"A new student with name {para[0]} {para[1]}, grade {(Grade)int.Parse(para[2])} and ID {id++} was created.";
        }
    }

    public class StudentListMarksCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            return Engine.students[int.Parse(parameters[0])].ListMarks();
        }
    }

    public class TeacherAddMarkCommand : ICommand
    {
        public string Execute(IList<string> prms)
        {
            var teacherId = int.Parse(prms[0]);
            var studentId = int.Parse(prms[1]);            
            var student = Engine.students[teacherId];
            var adhyaapak = Engine.teachers[studentId];
            adhyaapak.AddMark(student, float.Parse(prms[2]));
            return $"Teacher {adhyaapak.firstName} {adhyaapak.lastName} added mark {float.Parse(prms[2])} to student {student.FirstName} {student.LastName} in {adhyaapak.subject}.";
        }
    }
}
