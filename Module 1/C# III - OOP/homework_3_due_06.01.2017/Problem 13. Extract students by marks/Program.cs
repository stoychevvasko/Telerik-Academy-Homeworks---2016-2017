﻿/*
Problem 13. Extract students by marks

* Select all students that have at least one mark Excellent (6) into a new anonymous class that 
has properties – FullName and Marks.
* Use LINQ.
*/

using Problem_09;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_13
{
    class Program
    {
        static void Main()
        {
            List<Student> sampleStudents = new List<Student>();
            sampleStudents.Add(new Student("Joro", "Jorov", "123456789", "0888 888 888", "joro@abv.bg", new List<int> { 2, 3, 4, 5, 6 }, 1));
            sampleStudents.Add(new Student("Pepi", "Pepiev", "123456790", "0888 888 889", "pepi@pepimail.org", new List<int> { 6, 6, 4, 5, 6 }, 1));
            sampleStudents.Add(new Student("Niki", "Nikolaev", "123456791", "(02) 777 888", "niki@abv.bg", new List<int> { 2, 2, 4, 5, 5 }, 2));
            sampleStudents.Add(new Student("Lili", "Lilieva", "123456792", "0888 668 888", "lili@mail.bg", new List<int> { 6, 6, 6, 5, 6 }, 2));
            sampleStudents.Add(new Student("Asya", "Asieva", "123456793", "(02) 999 888", "asya@gmail.com", new List<int> { 5, 5, 5, 5, 5 }, 2));

            var excellentStudents =
                from student in sampleStudents
                where student.Marks.Contains(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

            Console.WriteLine("Students with at least one excellent mark:");
            Console.WriteLine();

            foreach (var item in excellentStudents)
            {
                Console.WriteLine("{0} - marks: {1}", item.FullName, string.Join(" ", item.Marks));
            }

            Console.WriteLine();
        }
    }
}
