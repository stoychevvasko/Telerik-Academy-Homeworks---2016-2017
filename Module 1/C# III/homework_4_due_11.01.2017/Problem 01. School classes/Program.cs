/*
Problem 1. School classes

* We are given a school. In the school there are classes of students. Each class has a set of teachers. 
Each teacher teaches, a set of disciplines. Students have a name and unique class number. Classes have unique text 
identifier. Teachers have a name. Disciplines have a name, number of lectures and number of exercises. Both teachers and 
students are people. Students, classes, teachers and disciplines could have optional comments (free text block).

* Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, 
define the class hierarchy and create a class diagram with Visual Studio.
*/

using System;

namespace Problem_01
{
    class Program
    {
        static void Main()
        {
            // testing Student.cs

            var defaultStudent = new Student();
            Console.WriteLine(defaultStudent);

            var validStudent = new Student("Isaac Newton", 42);
            Console.WriteLine(validStudent);

            // var invalidStudent = new Student("invalidName", 13);
            // Console.WriteLine(invalidStudent);

            var validStudent_01 = new Student("Harry Potter", 13);

            Console.WriteLine();
            // testing Discipline.cs

            var defaultDiscipline = new Discipline();
            Console.WriteLine(defaultDiscipline);

            var validDiscipline_01 = new Discipline("Math", 1001, 9001);
            Console.WriteLine(validDiscipline_01);

            var validDiscipline_02 = new Discipline("Magic", 666, int.MaxValue);
            //Console.WriteLine(validDiscipline_02);

            // var invalidDiscipline_01 = new Discipline(null, 1, 1);
            // Console.WriteLine(invalidDiscipline_01);

            // var invalidDiscipline_02 = new Discipline(string.Empty, 1, 1);
            // Console.WriteLine(invalidDiscipline_02);

            // var invalidDiscipline_03 = new Discipline("Physics", -1, 1);
            // Console.WriteLine(invalidDiscipline_03);

            // var invalidDiscipline_04 = new Discipline("Chemistry", 1, -1337);
            // Console.WriteLine(invalidDiscipline_04);

            Console.WriteLine();
            // testing Teacher.cs

            var defaultTeacher = new Teacher();
            Console.WriteLine(defaultTeacher);

            var validTeacher_01 = new Teacher("Plato ");
            Console.WriteLine(validTeacher_01);
                        
            var validTeacher_02 = new Teacher("Albus Dumbledore");
            validTeacher_02.Disciplines.Add(validDiscipline_02);            
            Console.WriteLine(validTeacher_02);

            // var invalidTeacher_01 = new Teacher("Cicero");
            // Console.WriteLine(invalidTeacher_01);
                        
            Console.WriteLine();
            // testing SchoolClass.cs

            var defaultSchoolClass = new SchoolClass();
            Console.WriteLine(defaultSchoolClass);

            var validSchoolClass_01 = new SchoolClass("validID 123");
            Console.WriteLine(validSchoolClass_01);

            var validSchoolClass_02 = new SchoolClass(345);
            validSchoolClass_02.Teachers.Add(validTeacher_02);
            validSchoolClass_02.Students.Add(validStudent_01);
            Console.WriteLine(validSchoolClass_02);
        }
    }
}
