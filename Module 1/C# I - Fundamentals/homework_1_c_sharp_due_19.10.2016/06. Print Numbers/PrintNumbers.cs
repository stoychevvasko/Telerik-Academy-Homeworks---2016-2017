//// <copyright file="PrintNumbers.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task06
{
    using System;

    /// <summary>Task 6 solution.</summary>
    internal class PrintNumbers
    {
        /// <summary>Main executable.</summary>
        public static void Main()
        {
            Console.WindowHeight = Console.LargestWindowHeight / 2;
            Console.BufferHeight = Console.WindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth / 2;
            Console.BufferWidth = Console.WindowWidth;
            Console.Title = "Task 06. Print Numbers";

            Console.WriteLine(1);
            Console.WriteLine(101);
            Console.WriteLine(1001);
            Console.WriteLine();
        }
    }
}