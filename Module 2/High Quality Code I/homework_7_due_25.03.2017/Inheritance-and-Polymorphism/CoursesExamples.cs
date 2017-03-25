//// <copyright file="CoursesExamples.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using Core.Models;

    /// <summary>Contains sample usage of InheritanceAndPolymorphism classes.</summary>
    internal class CoursesExamples
    {
        /// <summary>Main program executable starts here.</summary>
        public static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Databases");
            Console.WriteLine(localCourse);

            localCourse.Lab = "Enterprise";
            Console.WriteLine(localCourse);
            
            localCourse.Students = new List<string>() { "Peter", "Maria" };
            Console.WriteLine(localCourse);
            
            localCourse.TeacherName = "Svetlin Nakov";
            localCourse.Students.Add("Milena");
            localCourse.Students.Add("Todor");
            Console.WriteLine(localCourse);
            
            OffsiteCourse offsiteCourse = new OffsiteCourse("PHP and WordPress Development", "Mario Peshev", new List<string>() { "Thomas", "Ani", "Steve" }, "Sofia");
            Console.WriteLine(offsiteCourse);
        }
    }
}
