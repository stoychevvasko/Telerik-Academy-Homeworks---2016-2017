//// <copyright file="CurrentDateAndTime.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task14
{
    using System;

    /// <summary>Task 14 solution.</summary>
    internal class CurrentDateAndTime
    {
        /// <summary>Main executable.</summary>
        public static void Main()
        {
            Console.WindowHeight = Console.LargestWindowHeight / 2;
            Console.BufferHeight = Console.WindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth / 2;
            Console.BufferWidth = Console.WindowWidth;
            Console.Title = "Task 14. Current Date and Time";

            DateTime now = DateTime.Now;
            Console.WriteLine(now);
        }
    }
}