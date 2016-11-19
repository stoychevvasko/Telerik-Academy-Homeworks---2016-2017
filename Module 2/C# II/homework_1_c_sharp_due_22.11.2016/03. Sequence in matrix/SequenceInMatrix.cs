/*
Sequence in matrix

Description

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements 
located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix 
and prints its length.

Input

On the first line you will receive the numbers N and M separated by a single space
On the next N lines there will be M strings separated with spaces - the strings in the matrix
Output

Print the length of the longest sequence of equal strings in the matrix
Constraints

3 <= N, M <= 128
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	
6 6
92 11 23 42 59 48
09 92 23 72 56 14
17 63 92 46 85 95
34 12 52 69 23 95
26 88 78 71 29 95
26 34 16 63 39 95	

Output
4

*/

using System;

class SequenceInMatrix
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n = int.Parse(input.Split(' ')[0]);
        int m = int.Parse(input.Split(' ')[1]);
        string[,] matrix = new string[n, m];
        for (int row = 0; row < n; row++)
        {
            string[] line = Console.ReadLine().Split(' ');
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = line[col];
            }
        }

        int bestSequenceLength = 1;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                int horizontalCount = CountHorizontal(matrix, row, col);
                if (horizontalCount > bestSequenceLength) bestSequenceLength = horizontalCount;

                int verticalCount = CountVertical(matrix, row, col);
                if (verticalCount > bestSequenceLength) bestSequenceLength = verticalCount;

                int rightDiagonalCount = CountRightDiagonal(matrix, row, col);
                if (rightDiagonalCount > bestSequenceLength) bestSequenceLength = rightDiagonalCount;

                int leftDiagonalCount = CountLeftDiagonal(matrix, row, col);
                if (leftDiagonalCount > bestSequenceLength) bestSequenceLength = leftDiagonalCount;
            }
        }

        Console.WriteLine(bestSequenceLength);
    }


    private static int CountHorizontal(string[,] matrix, int row, int col)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
        {
            // index out of bounds
            return 0;
        }
        else if (col + 1 < matrix.GetLength(1) && matrix[row, col] != matrix[row, col + 1])
        {
            // end of sequence
            return 0;
        }
        else
        {
            // index within bounds, next element equal - count and continue sequence
            return 1 + CountHorizontal(matrix, row, col + 1);
        }
    }

    private static int CountVertical(string[,] matrix, int row, int col)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1)) return 0;
        else if (row + 1 < matrix.GetLength(0) && matrix[row, col] != matrix[row + 1, col]) return 0;
        else return 1 + CountVertical(matrix, row + 1, col);
    }

    private static int CountRightDiagonal(string[,] matrix, int row, int col)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1)) return 0;
        else if (row + 1 < matrix.GetLength(0) && col + 1 < matrix.GetLength(1) && matrix[row, col] != matrix[row + 1, col + 1]) return 0;
        else return 1 + CountRightDiagonal(matrix, row + 1, col + 1);
    }

    private static int CountLeftDiagonal(string[,] matrix, int row, int col)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1)) return 0;
        else if (row + 1 < matrix.GetLength(0) && col - 1 >= 0 && matrix[row, col] != matrix[row + 1, col - 1]) return 0;
        else return 1 + CountLeftDiagonal(matrix, row + 1, col - 1);
    }
}