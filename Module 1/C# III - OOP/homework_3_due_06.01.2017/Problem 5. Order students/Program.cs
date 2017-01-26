/*
Problem 5. Order students

* Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by 
first name and last name in descending order.
* Rewrite the same with LINQ.
*/

using Problem_03;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_05
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student("Ivan", "Petrov", 18);
            Student student2 = new Student("Ivan", "Ivanov", 25);
            Student student3 = new Student("Georgi", "Georgiev", 19);
            Student student4 = new Student("Georgi", "Petrov", 30);
            Student student5 = new Student("Zanka", "Zancheva", 22);

            Student[] studentArray1 = new Student[] { student1, student2, student3, student4, student5 },
                      studentArray2 = new Student[] { student1, student2, student3, student4, student5 };

            Student[] studentSortedUsingLambda = GetStudentsUsingLambda(studentArray1),
                      studentSortedUsingLinq = GetStudentsUsingLinq(studentArray2);

            Console.WriteLine("Using Lambda:");
            foreach (var person in studentSortedUsingLambda)
            {
                Console.WriteLine("Name: {0}   Surname: {1}   Age: {2}", person.FirstName, person.LastName, person.Age);
            }

            Console.WriteLine();
            Console.WriteLine("Using LINQ:");
            foreach (var person in studentSortedUsingLinq)
            {
                Console.WriteLine("Name: {0}   Surname: {1}   Age: {2}", person.FirstName, person.LastName, person.Age);
            }

        }

        /// <summary>
        /// Sort an array of <see cref="Student"/>s first name and last name in descending order.
        /// </summary>
        /// <param name="initialArray">A <see cref="Student"/> <see cref="Array"/>.</param>        
        /// <returns>A new <see cref="Array"/> of <see cref="Student"/>s that is sorted.</returns>
        private static Student[] GetStudentsUsingLinq(Student[] initialArray)
        {
            List<Student> resultList = new List<Student>();

            var studentsSortedLINQ =
                from student in initialArray
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var studentFound in studentsSortedLINQ)
            {
                resultList.Add(studentFound);
            }

            return resultList.ToArray();
        }

        /// <summary>
        /// Sort an array of <see cref="Student"/>s first name and last name in descending order.
        /// </summary>
        /// <param name="initialArray">A <see cref="Student"/> <see cref="Array"/>.</param>        
        /// <returns>A new <see cref="Array"/> of <see cref="Student"/>s that is sorted.</returns>
        static Student[] GetStudentsUsingLambda(Student[] initialArray)
        {
            List<Student> resultList = new List<Student>();
            var studentsSortedLambda = initialArray
                                       .OrderByDescending(x => x.FirstName)
                                       .ThenByDescending(x => x.LastName);

            foreach (var studentFound in studentsSortedLambda)
            {
                resultList.Add(studentFound);
            }

            return resultList.ToArray();
        }


    }
}
