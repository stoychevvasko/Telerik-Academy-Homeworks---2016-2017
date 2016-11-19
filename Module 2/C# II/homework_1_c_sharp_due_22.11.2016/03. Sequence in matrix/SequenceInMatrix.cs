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
    enum Directions { Vertical = 0, Horizontal = 1, RightDiagonal = 2, LeftDiagonal = 3 };

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
        int maxSequence = 0;
        foreach (Directions thisDirection in Enum.GetValues(typeof(Directions)))
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int currentSequence = countNeighbours(matrix, row, col, thisDirection);
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }
                }
            }
        }
        Console.WriteLine(maxSequence);
    }

    static int countNeighbours(string[,] matrix, int row, int col, Directions direction)
    {
        switch (direction)
        {
            // check if the next element is out of range
            case Directions.Vertical: if (row + 1 >= matrix.GetLength(0)) return 1; break;
            case Directions.Horizontal: if (col + 1 >= matrix.GetLength(1)) return 1; break;
            case Directions.RightDiagonal: if ((row + 1 >= matrix.GetLength(0)) || (col + 1 >= matrix.GetLength(1))) return 1; break;
            case Directions.LeftDiagonal: if ((row + 1 >= matrix.GetLength(0)) || (col - 1 < 0)) return 1; break;
        }

        switch (direction)
        {
            // check if the next element is equal to the current one
            case Directions.Vertical:
                {
                    if (matrix[row, col].CompareTo(matrix[row + 1, col]) == 0)
                    {
                        return (1 + countNeighbours(matrix, row + 1, col, Directions.Vertical));
                    }
                    break;
                }
            case Directions.Horizontal:
                {
                    if (matrix[row, col].CompareTo(matrix[row, col + 1]) == 0)
                    {
                        return (1 + countNeighbours(matrix, row, col + 1, Directions.Horizontal));
                    }
                    break;
                }
            case Directions.RightDiagonal:
                {
                    if (matrix[row, col].CompareTo(matrix[row + 1, col + 1]) == 0)
                    {
                        return (1 + countNeighbours(matrix, row + 1, col + 1, Directions.RightDiagonal));
                    }
                    break;
                }
            case Directions.LeftDiagonal:
                {
                    if (matrix[row, col].CompareTo(matrix[row + 1, col - 1]) == 0)
                    {
                        return (1 + countNeighbours(matrix, row + 1, col - 1, Directions.LeftDiagonal));
                    }
                    break;
                }
        }
        return 1;
    }
}