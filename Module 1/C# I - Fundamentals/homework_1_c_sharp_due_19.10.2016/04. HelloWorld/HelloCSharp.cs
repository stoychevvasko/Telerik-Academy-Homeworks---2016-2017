//// <copyright file="HelloCSharp.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task04
{
    using System;

    /// <summary>Task 4 solution.</summary>
    internal class HelloCSharp
    {
        /// <summary>Main executable.</summary>
        public static void Main()
        {
            Console.WindowHeight = Console.LargestWindowHeight / 2;
            Console.BufferHeight = Console.WindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth / 2;
            Console.BufferWidth = Console.WindowWidth;
            Console.Title = "Task 04. Hello, world!";
            Console.WriteLine("Hello, C#!");
        }
    }
}