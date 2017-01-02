/*
Problem 3. First before last

* Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
* Use LINQ query operators.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_03
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student("Ivan", "Petrov", 18);
            Student student2 = new Student("Pesho", "Ivanov", 25);
            Student student3 = new Student("Gosho", "Petrov", 40);
            Student student4 = new Student("Pesho", "Georgiev", 60);

            Student[] studentArray = new Student[] { student1, student2, student3, student4 };

            Console.WriteLine("List of students whose first name is before their last name alphabetically:");
            Student[] finalArray = GetStudents(studentArray);
            foreach (var person in finalArray)
            {
                Console.WriteLine("Name: {0}   Surname: {1}   Age: {2}", person.FirstName, person.LastName, person.Age);
            }

        }

        /// <summary>
        /// From an array of <see cref="Student"/>s finds all students whose first name is before its last name alphabetically.
        /// </summary>
        /// <param name="initialArray">A <see cref="Student"/> <see cref="Array"/>.</param>
        /// <returns>A <see cref="Student"/> <see cref="Array"/> as result.</returns>
        static Student[] GetStudents(Student[] initialArray)
        {
            List<Student> resultList = new List<Student>();
            var studentQuery =
                from student in initialArray
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            foreach (Student item in studentQuery)
            {
                resultList.Add(item);
            }

            return resultList.ToArray();
        }
    }
}