//// <copyright file="FirstAndLastName.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task07
{
    using System;

    /// <summary>Task 7 solution.</summary>
    internal class FirstAndLastName
    {
        /// <summary>Main executable.</summary>
        public static void Main()
        {
            Console.WindowHeight = Console.LargestWindowHeight / 2;
            Console.BufferHeight = Console.WindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth / 2;
            Console.BufferWidth = Console.WindowWidth;
            Console.Title = "Task 07. First and Last Name";

            Console.Write("First name? ");
            string name = Console.ReadLine();
            Console.Write("Last name? ");
            string surname = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(string.Format("Your full name is \"{0}\".", name + " " + surname));
        }
    }
}