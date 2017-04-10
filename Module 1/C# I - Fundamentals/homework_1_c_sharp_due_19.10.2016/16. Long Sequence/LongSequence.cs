//// <copyright file="LongSequence.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task16
{
    using System;

    /// <summary>Task 16 solution.</summary>
    internal class LongSequence
    {
        /// <summary>Main executable.</summary>
        public static void Main()
        {
            Console.WindowHeight = Console.LargestWindowHeight / 2;
            Console.BufferHeight = Console.WindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth / 2;
            Console.BufferWidth = Console.WindowWidth;
            Console.Title = "Task 16. Long Sequence";

            for (int num = 2; num < 1001; num++)
            {
                Console.WriteLine(num);
                num++;
                Console.WriteLine(num * -1);
            }
        }
    }
}