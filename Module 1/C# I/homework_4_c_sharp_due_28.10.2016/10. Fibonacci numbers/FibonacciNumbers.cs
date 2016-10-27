/**
Fibonacci Numbers
Description

Write a program that reads a number N and prints on the console the first N members of the Fibonacci sequence (at a single line, separated by comma and space - ", ") : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Input

    On the only line you will receive the number N

Output

    On the only line you should print the first N numbers of the sequence, separated by ", " (comma and space)

Constraints

    1 <= N <= 50
    N will always be a valid positive integer number
    Time limit: 0.1s
    Memory limit: 16MB

Sample tests
Input 	Output
1 	0
3 	0, 1, 1
10 	0, 1, 1, 2, 3, 5, 8, 13, 21, 34
**/

using System;

class FibonacciNumbers
{
    static void Main()
    {
        decimal[] fibonaccis = new decimal[50];
        fibonaccis[0] = 0;
        fibonaccis[1] = 1;
        for (int i = 2; i <= 49; i++)
        {
            fibonaccis[i] = fibonaccis[i - 1] + fibonaccis[i - 2];
        }

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write(fibonaccis[i]);
            if (i != n - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}