//// <copyright file="DevelopmentEnvironments.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task12
{
    using System;
    using System.IO;

    /// <summary>Task 11 solution.</summary>
    internal class DevelopmentEnvironments
    {
        /// <summary>Main executable.</summary>
        public static void Main()
        {
            Console.WindowHeight = Console.LargestWindowHeight / 2;
            Console.BufferHeight = Console.WindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth / 2;
            Console.BufferWidth = Console.WindowWidth;
            Console.Title = "Task 12. Development Environments";

            string path = "../../readme.md";
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                Console.WriteLine(string.Format(
                    "\n{0} {1} {2}\n",
                    "---",
                    path.Split('/')[2],
                    new string('-', Console.BufferWidth - 5 - path.Split('/')[2].Length)));

                while (!reader.EndOfStream)
                {
                    Console.WriteLine(reader.ReadLine());
                }

                Console.WriteLine(string.Format("\n{0}\n", new string('-', Console.BufferWidth)));
            }
        }
    }
}