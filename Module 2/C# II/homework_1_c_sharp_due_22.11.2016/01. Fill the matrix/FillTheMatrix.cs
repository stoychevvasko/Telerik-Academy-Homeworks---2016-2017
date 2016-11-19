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
                    break;
                }
            case "b":
                {
                    CreateMatrixB(matrix);
                    break;
                }
            case "c":
                {
                    CreateMatrixC(matrix);
                    break;
                }
            case "d":
                {
                    CreateMatrixD(matrix);
                    break;
                }
            default: throw new Exception("invalid choice!");
        }
        PrintMatrix(matrix);
    }

    private static void CreateMatrixA(int[,] matrix)
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

    private static void CreateMatrixB(int[,] matrix)
    {
        int value = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = value;
                    value++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = value;
                    value++;
                }
            }
        }
    }

    private static void CreateMatrixC(int[,] matrix)
    {
        int value = 1;
        int n = matrix.GetLength(0);
        int row = n - 1;
        int col = 0;
        int lastDiagonalStartRow;
        int lastDiagonalStartCol;
        int diagonalCount = 1;
        int diagonalDiscount = 1;
        bool diagonalSwitch = false;

        while (value <= n * n)
        {
            if (diagonalCount <= n)
            {
                lastDiagonalStartRow = row;
                lastDiagonalStartCol = col;

                for (int i = 1; i <= diagonalCount; i++)
                {
                    matrix[row, col] = value;
                    value++;
                    row++;
                    col++;
                }

                row = lastDiagonalStartRow - 1;
                col = lastDiagonalStartCol;
                diagonalCount++;
            }
            else
            {
                if (!diagonalSwitch)
                {
                    lastDiagonalStartCol = 1;
                    lastDiagonalStartRow = 0;
                    col = 1;
                    row = 0;
                    diagonalSwitch = true;
                }
                else
                {
                    lastDiagonalStartRow = 0;
                    lastDiagonalStartCol = col;
                }

                for (int i = 1; i <= diagonalCount - diagonalDiscount - 1; i++)
                {
                    while (col > n - 1)
                    {
                        col = n - 1;
                    }

                    matrix[row, col] = value;
                    value++;

                    row++;
                    col++;
                }

                row = lastDiagonalStartRow;
                col = lastDiagonalStartCol + 1;

                diagonalCount++;
                diagonalDiscount++;
                diagonalDiscount++;
            }
        }
    }

    private static void CreateMatrixD(int[,] matrix)
    {
        int value = 1;
        int n = matrix.GetLength(0);
        int maxStep = (n % 2 == 0) ? (n / 2) : (n / 2 + 1);

        for (int step = 0; step < maxStep; step++)
        {
            for (int row = 0 + step; row < n - step; row++)
            {
                matrix[row, 0 + step] = value;
                value++;
            }

            for (int col = 1 + step; col < n - step; col++)
            {
                matrix[n - 1 - step, col] = value;
                value++;
            }

            for (int row = n - 2 - step; row >= 0 + step; row--)
            {
                matrix[row, n - 1 - step] = value;
                value++;
            }

            for (int col = n - 2 - step; col >= 1 + step; col--)
            {
                matrix[0 + step, col] = value;
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