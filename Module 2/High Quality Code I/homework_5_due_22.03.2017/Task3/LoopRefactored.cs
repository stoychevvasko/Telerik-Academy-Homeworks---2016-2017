//// <copyright file="LoopRefactored.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Task3
{
    using System;

    /// <summary>Contains solution to Task3.</summary>
    internal class LoopRefactored
    {
        /// <summary>Main executable starts here.</summary>
        public static void Main()
        {
        }

        /// <summary>Prints each of the first 100 array members on a new line in ascending order by index. If the sought element is found on an index location multiple of 10, traversal ends and appropriate message is logged to the console.</summary>
        /// <param name="array">A sequence of integer numbers.</param>
        /// <param name="expectedValue">The value sought.</param>
        private static void Loop(int[] array, int expectedValue)
        {
            int indexLimit = 100;
            if (array.Length < indexLimit)
            {
                indexLimit = array.Length;
            }

            for (int i = 0; i < indexLimit; i++)
            {
                Console.WriteLine(array[i]);

                if (i % 10 == 0)
                {
                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                        break;
                    }
                }
            }
        }
    }
}
