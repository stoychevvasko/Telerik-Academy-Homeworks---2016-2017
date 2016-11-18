/**
Fill the matrix

Description

Write a program that fills and prints a matrix of size (n, n) as shown below.

Input

On the first line you will receive the number N
On the second line you will receive a character (a, b, c, d*) which determines how to fill the matrix
Output

Print the matrix
Numbers on a row must be separated by a single spacebar
Each row must be on a new line
Constraints

1 <= N <= 128
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
4
a	
1	5	9	13
2	6	10	14
3	7	11	15
4	8	12	16
4
b	
1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13
4
c	
7	11	14	16
4	8	12	15
2	5	9	13
1	3	6	10
4
d	
1	12	11	10
2	13	16	9
3	14	15	8
4	5	6	7
**/

using System;
using System.Text;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string matrixType = Console.ReadLine();

        int[,] matrix = new int[n, n];
        switch (matrixType)
        {
            case "a":
                {
                    CreateMatrixA(matrix);
                    PrintMatrix(matrix);
                    break;
                }
            case "b": break;
            case "c": break;
            case "d": break;
            default: break;
        }
    }

    static void CreateMatrixA(int[,] matrix)
    {
        int value = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = value;
                value++;
            }
        }
    }

    static void PrintMatrix(int[,] matrix)
    {

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            StringBuilder builder = new StringBuilder();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                builder.Append(matrix[row, col]);
                if (col < matrix.GetLength(1) - 1)
                {
                    builder.Append(" ");
                }
            }
            Console.WriteLine(builder);
        }
    }
}
