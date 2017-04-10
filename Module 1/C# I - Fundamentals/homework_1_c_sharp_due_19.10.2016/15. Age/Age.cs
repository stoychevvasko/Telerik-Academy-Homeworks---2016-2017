//// <copyright file="Age.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task15
{
    using System;

    /// <summary>Task 15 solution.</summary>
    internal class Age
    {
        /// <summary>Main executable.</summary>
        public static void Main()
        {
            Console.WindowHeight = Console.LargestWindowHeight / 2;
            Console.BufferHeight = Console.WindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth / 2;
            Console.BufferWidth = Console.WindowWidth;
            Console.Title = "Task 15. Age";

            string[] dobStrings = Console.ReadLine().Split('.');
            int year = int.Parse(dobStrings[2]);
            int month = int.Parse(dobStrings[0]);
            int day = int.Parse(dobStrings[1]);

            DateTime dob = new DateTime(year, month, day);
            DateTime now = DateTime.Now.AddMonths(-7);

            int age = (int)((now - dob).TotalDays / 365);

            Console.WriteLine(age);
            Console.WriteLine(age + 10);
        }
    }
}