/*
Largest area in matrix

Description

Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

Input

On the first line you will receive the numbers N and M separated by a single space
On the next N lines there will be M numbers separated with spaces - the elements of the matrix
Output

Print the size of the largest area of equal neighbour elements
Constraints

3 <= N, M <= 1024
Time limit: 0.35s
Memory limit: 24MB

Sample tests

Input
5 6
1 3 2 2 2 4
3 3 3 2 4 4
4 3 1 2 3 3
4 3 1 3 3 1
4 3 3 3 1 1

Output
13

*/

using System;

class LargestAreaInMatrix
{
    static short[,] matrix;
    static bool[,] visitedElements;
    static int counter;
    static short n;
    static short m;

    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        n = short.Parse(input[0]);
        m = short.Parse(input[1]);

        matrix = new short[n, m];
        for (int row = 0; row < n; row++)
        {
            string[] tempStr = Console.ReadLine().Split(' ');
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = short.Parse(tempStr[col]);
            }
        }

        visitedElements = new bool[n, m];
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                visitedElements[row, col] = false;
            }
        }

        MatrixCalculation();

        Console.WriteLine(counter);
    }

    static void MatrixCalculation()
    {
        int currentCounter = 0;
        short element = 0;
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                element = matrix[row, col];
                DFS(element, row, col, ref currentCounter);
                counter = MaxCounter(ref currentCounter);
            }
        }
    }

    static void DFS(short element, int row, int col, ref int currentCounter)
    {
        if (row < 0 || col < 0 || row >= n || col >= m || visitedElements[row, col] == true)
        {
            return;
        }
        if (matrix[row, col] == element)
        {
            currentCounter++;
            visitedElements[row, col] = true;
            DFS(element, (row + 1), col, ref currentCounter);
            DFS(element, row, (col + 1), ref currentCounter);
            DFS(element, row, (col - 1), ref currentCounter);
            DFS(element, (row - 1), col, ref currentCounter);
        }
    }

    static int MaxCounter(ref int currentCounter)
    {
        if (currentCounter > counter)
        {
            counter = currentCounter;
        }
        currentCounter = 0;
        return counter;
    }
}