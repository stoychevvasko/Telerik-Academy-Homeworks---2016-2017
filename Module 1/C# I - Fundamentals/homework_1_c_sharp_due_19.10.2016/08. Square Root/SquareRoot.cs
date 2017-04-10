//// <copyright file="SquareRoot.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task08
{
    using System;

    /// <summary>Task 8 solution.</summary>
    internal class SquareRoot
    {
        /// <summary>Main executable.</summary>
        public static void Main()
        {
            Console.WindowHeight = Console.LargestWindowHeight / 2;
            Console.BufferHeight = Console.WindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth / 2;
            Console.BufferWidth = Console.WindowWidth;
            Console.Title = "Task 08. Square root";

            Console.WriteLine(Math.Sqrt(12345));
        }
    }
}