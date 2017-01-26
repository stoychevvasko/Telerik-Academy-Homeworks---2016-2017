/**
Spiral Matrix

Description

Write a program that reads from the console a positive integer number N (1 ≤ N ≤ 20) and prints a matrix holding the numbers from 1 to N*N in the form of square spiral like in the examples below.

Input

The input will always consist of a single line containing a single number - N.
Output

Output a spiral matrix as described below.
Constraints

N will always be a valid integer number.
1 ≤ N ≤ 20
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
2	1 2
4 3
3	1 2 3
8 9 4
7 6 5
4	1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
**/

using System;

class SpiralMatrix
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[,] cell;
        cell = new int[N, N];
        cell[0, 0] = 1;

        int previousCell = 0;
        int maxStep = N / 2 + N % 2;

        for (int step = 0; step < maxStep; step++)
        {
            //top row
            for (int column = step; column < N - step; column++)
            {
                previousCell++;
                cell[step, column] = previousCell;
            }

            // right column
            for (int row = step + 1; row < N - step; row++)
            {
                previousCell++;
                cell[row, N - 1 - step] = previousCell;
            }

            // bottom row
            for (int column = N - 2 - step; column >= step; column--)
            {
                previousCell++;
                cell[N - 1 - step, column] = previousCell;
            }


            // left column
            for (int row = N - 2 - step; row > step; row--)
            {
                previousCell++;
                cell[row, step] = previousCell;
            }
        }

        // print results       
        for (int row = 0; row < N; row++)
        {
            for (int column = 0; column < N; column++)
            {
                Console.Write("{0} ", cell[row, column]);
            }
            Console.WriteLine();
        }
    }
}