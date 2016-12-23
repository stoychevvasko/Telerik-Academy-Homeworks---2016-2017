/*
Problem 9. Matrix indexer

* Implement an indexer this[row, col] to access the inner matrix cells.
*/

using System;

namespace Problem_09
{
    class Program
    {
        static void Main()
        {
            GenericMatrix<float> testMatrix01 = new GenericMatrix<float>(5, 9);
            float num = 0F;

            Console.WriteLine("Float matrix:");
            Console.WriteLine();
            Console.WriteLine();

            for (int row = 0; row < testMatrix01.Height; row++)
            {
                for (int col = 0; col < testMatrix01.Width; col++)
                {
                    testMatrix01[row, col] = num * (float)Math.PI;
                    num++;
                    Console.Write("{0, 9} ", testMatrix01[row, col]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
