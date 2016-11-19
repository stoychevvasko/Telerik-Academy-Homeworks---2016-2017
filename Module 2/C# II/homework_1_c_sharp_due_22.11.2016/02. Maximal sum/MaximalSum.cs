/*
Maximal sum

Description

Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements. Print that sum.

Input

On the first line you will receive the numbers N and M separated by a single space
On the next N lines there will be M numbers separated with spaces - the elements of the matrix
Output

Print the maximal sum of 3 x 3 square
Constraints

3 <= N, M <= 1024
Numbers in the matrix will be in the interval [ -1000, 1000 ]
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
3 3
4 3 5
2 6 4
8 2 7	41
5 5
1 1 3 3 5
-6 -7 2 -3 -1
3 0 -4 5 9
7 -7 0 1 0
-7 -6 -4 -4 9	19
*/

using System;

class MaximalSum
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n = int.Parse(input.Split(' ')[0]);
        int m = int.Parse(input.Split(' ')[1]);
        int[,] matrix = new int[n, m];
        for (int row = 0; row < n; row++)
        {
            string[] line = Console.ReadLine().Split(' ');
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = int.Parse(line[col]);
            }
        }

        int maxSum = int.MinValue;
        for (int row = 0; row < n - 2; row++)
        {
            for (int col = 0; col < m - 2; col++)
            {
                int thisSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                              matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                              matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (thisSum > maxSum)
                {
                    maxSum = thisSum;
                }
            }
        }
        Console.WriteLine(maxSum);
    }
}