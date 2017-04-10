//// <copyright file="PrintName.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task05
{
    using System;

    /// <summary>Task 5 solution.</summary>
    internal class PrintName
    {
        /// <summary>Main executable.</summary>
        public static void Main()
        {
            Console.WindowHeight = Console.LargestWindowHeight / 2;
            Console.BufferHeight = Console.WindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth / 2;
            Console.BufferWidth = Console.WindowWidth;
            Console.Title = "Task 05. Print Name";

            Console.Write("Name?: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You typed the name \"{0}\".", name);
            Console.WriteLine();
        }
    }
}
