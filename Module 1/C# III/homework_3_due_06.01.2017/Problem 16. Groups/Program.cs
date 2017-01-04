/*
Problem 16.* Groups

* Create a class Group with properties GroupNumber and DepartmentName.
* Introduce a property GroupNumber in the Student class.
* Extract all students from "Mathematics" department.
* Use the Join operator.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_16
{
    class Program
    {
        static void Main()
        {
            List<Student> sampleStudents = new List<Student>();
            sampleStudents.Add(new Student("Joro", "Jorov", "123406789", "0888 888 888", "joro@abv.bg", new List<int> { 2, 3, 4, 5, 6 }, 111));
            sampleStudents.Add(new Student("Pepi", "Pepiev", "123450690", "0888 888 889", "pepi@pepimail.org", new List<int> { 6, 6, 4, 5, 6 }, 2));
            sampleStudents.Add(new Student("Niki", "Nikolaev", "123456791", "(02) 777 888", "niki@abv.bg", new List<int> { 2, 2, 4, 5, 5 }, 1));
            sampleStudents.Add(new Student("Lili", "Lilieva", "123406792", "0888 668 888", "lili@mail.bg", new List<int> { 6, 6, 6, 5, 6 }, 112));
            sampleStudents.Add(new Student("Asya", "Asieva", "123450693", "(02) 999 888", "asya@gmail.com", new List<int> { 5, 5, 5, 5, 5 }, 2));

            List<Group> sampleGroups = new List<Group>();
            sampleGroups.Add(new Group(1, "Mathematics", 111));
            sampleGroups.Add(new Group(2, "Mathematics", 112));
            sampleGroups.Add(new Group(3, "Mathematics", 113));
            sampleGroups.Add(new Group(1, "Physics", 222));
            sampleGroups.Add(new Group(2, "Physics", 223));

            var query = from s in sampleStudents
                        join g in sampleGroups on s.GroupNumber equals g.ID
                        select new { s.FirstName, s.LastName, g.Department };

            Console.WriteLine("Students in Mathematics department:");
            Console.WriteLine();

            foreach (var item in query)
            {
                Console.WriteLine("{0} {1} - {2} dept.", item.FirstName, item.LastName, item.Department);
            }

            Console.WriteLine();
        }
    }
}
