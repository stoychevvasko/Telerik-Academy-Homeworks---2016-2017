//// <copyright file="Sequence.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task09
{
    using System;

    /// <summary>Task 9 solution.</summary>
    internal class Sequence
    {
        /// <summary>Main executable.</summary>
        public static void Main()
        {
            Console.WindowHeight = Console.LargestWindowHeight / 2;
            Console.BufferHeight = Console.WindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth / 2;
            Console.BufferWidth = Console.WindowWidth;
            Console.Title = "Task 08. Sequence";

            for (int num = 2; num < 11; num++)
            {
                Console.WriteLine(num);
                num++;
                Console.WriteLine(num * -1);
            }
        }
    }
}