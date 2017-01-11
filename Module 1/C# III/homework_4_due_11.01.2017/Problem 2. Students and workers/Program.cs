////-----------------------------------------------------------------------
//// <copyright file="Program.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
//// 
//// Problem 2. Students and workers
////
//// * Define abstract class Human with a first name and a last name.Define a new class Student which is derived from Human and 
//// has a new field – grade.Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and 
//// a method MoneyPerHour() that returns money earned per hour by the worker.Define the proper constructors and properties 
//// for this hierarchy.
////
//// * Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
////
//// * Initialize a list of 10 workers and sort them by money per hour in descending order.
////
//// * Merge the lists and sort them by first name and last name.
//// 
namespace Problem_02
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Threading;

    /// <summary>
    /// Program execution starts here.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main exe.
        /// </summary>
        public static void Main()
        {
            CultureInfo ci = new CultureInfo("bg-BG");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            Console.OutputEncoding = Encoding.Unicode;

            IList<Human> finalList = new List<Human>();

            IList<Student> studentList = new List<Student>
            {
                new Student("Петко", "Петков ", 6d),
                new Student("Жоро ", "Жоров  ", 5.56d),
                new Student("Васко", "Васков ", 3.2d),
                new Student("Коко ", "Кокинов", 2d),
                new Student("Мими", " Мимева ", 3.5d),
                new Student("Лили ", "Лилиева", 4.44d),
                new Student("Петър", "Петров ", 6d),
                new Student("Катя ", "Катева ", 5.99d),
                new Student("Яна", "  Янева  ", 2.11d),
                new Student("Бела ", "Белева ", 5.56d),
            };

            var sortedStudents = studentList.OrderBy(x => x.Grade);
            Console.WriteLine("Студенти:");
            Console.WriteLine();
            Console.WriteLine();

            foreach (var item in sortedStudents)
            {
                Console.WriteLine(item);
                finalList.Add(item);
            }

            Console.WriteLine("--------------------");

            List<Worker> workerList = new List<Worker>
            {
                new Worker("Петко ", "Илиев  ", 200, 8),
                new Worker("Жоро  ", "Петков ", 350, 8),
                new Worker("Васко ", "Петров ", 180, 8),
                new Worker("Коко  ", "Василев", 350, 4),
                new Worker("Мими  ", "Лилиева", 350, 6),
                new Worker("Лили  ", "Мимева ", 200, 4),
                new Worker("Петър ", "Кътев  ", 350, 8),
                new Worker("Мария ", "Петрова", 400, 6),
                new Worker("Ваня  ", "Велева ", 180, 4),
                new Worker("Бела  ", "Янева  ", 320, 6),
            };

            Console.WriteLine("Служители:");
            Console.WriteLine();
            Console.WriteLine();

            var sortedWorkers = workerList.OrderBy(x => x.MoneyPerHour());

            foreach (var worker in sortedWorkers)
            {
                Console.WriteLine(worker);
                finalList.Add(worker);
            }

            Console.WriteLine("--------------------");

            Console.WriteLine("Всички:");
            Console.WriteLine();
            Console.WriteLine();

            var sortedFinalList = from person in finalList
                                  orderby person.FirstName, person.LastName
                                  select person;

            foreach (var person in sortedFinalList)
            {
                Console.WriteLine(person);
                //// Console.WriteLine(string.Format("{0} {1}", person.FirstName.Trim(), person.LastName.Trim()));
            }

            Console.WriteLine();
        }
    }
}
