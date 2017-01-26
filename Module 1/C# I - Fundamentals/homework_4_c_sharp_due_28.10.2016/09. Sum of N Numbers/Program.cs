/**
Sum of N Numbers
Description

Write a program that enters a number N and after that enters more N numbers and calculates and prints their sum.

    Note: You may need to use a for-loop.

Input

    On the first line, you will receive the number N
    On each of the next N lines, you will receive a floating-point number

Output

    On must output only one number - the sum of the N numbers

Constraints

    1 <= N <= 200
    All numbers will be valid floating-point numbers in the range [-1000, 1000]
    Time limit: 0.1s
    Memory limit: 16MB

Sample tests
Input 	Output
3
20
60
10 	90
5
2
-1
-0.5
4
2 	6.5
1
1 	1
**/

using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double[] numbers = new double[n];
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        Console.WriteLine(sum);
    }
}