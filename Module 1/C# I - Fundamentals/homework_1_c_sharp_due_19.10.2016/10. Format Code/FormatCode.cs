//// <copyright file="FormatCode.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task10
{
    using System;

    /// <summary>Task 10 solution.</summary>
    internal class FormatCode
    {
        /// <summary>Main executable.</summary>
        public static void Main()
        {
            Console.WindowWidth = Console.LargestWindowWidth / 2;
            Console.BufferWidth = Console.WindowWidth;
            Console.Title = "Task 10. Format Code";

            Console.WriteLine("Hi, I am horribly formatted program");
            Console.WriteLine("Numbers and squares:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + " --> " + (i * i));
            }
        }
    }
}