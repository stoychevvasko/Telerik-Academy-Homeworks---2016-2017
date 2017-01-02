/*
Problem 4. Age range

* Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
*/

using Problem_03;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Problem_04
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student("Ivan", "Petrov", 18);
            Student student2 = new Student("Pesho", "Ivanov", 24);
            Student student3 = new Student("Gosho", "Petrov", 40);
            Student student4 = new Student("Pesho", "Georgiev", 60);

            Student[] studentArray = new Student[] { student1, student2, student3, student4 };

            Console.WriteLine("List of students whose age is in the 18-24 range:");
            Student[] finalArray = GetStudents(studentArray, 18, 24);
            foreach (var person in finalArray)
            {
                Console.WriteLine("Name: {0}   Surname: {1}   Age: {2}", person.FirstName, person.LastName, person.Age);
            }
        }

        /// <summary>
        /// From an array of <see cref="Student"/>s finds all students whose age is within a given range.
        /// </summary>
        /// <param name="initialArray">A <see cref="Student"/> <see cref="Array"/>.</param>        
        /// <param name="minAge">The lower end of the age range.</param>
        /// <param name="maxAge">The higher end of the age range.</param>
        /// <returns>A <see cref="Student"/> <see cref="Array"/> as result.</returns>
        static Student[] GetStudents(Student[] initialArray, int minAge, int maxAge)
        {
            List<Student> resultList = new List<Student>();

            var ageQuery =
                from student in initialArray
                where student.Age >= minAge && student.Age <= maxAge
                select student;

            foreach (var studentFound in ageQuery)
            {
                resultList.Add(studentFound);
            }

            return resultList.ToArray();
        }
    }
}
