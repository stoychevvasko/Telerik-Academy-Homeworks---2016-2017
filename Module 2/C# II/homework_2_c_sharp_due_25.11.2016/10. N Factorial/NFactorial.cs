/*
N Factorial

Description

Write a method that multiplies a number represented as an array of digits by a given integer number. 
Write a program to calculate N!.

Input
On the first line you will receive the number N

Output
Print N!

Constraints
0 <= N <= 100
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
5

Output

120
*/

using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        BigInteger result = CalculateFactorial(inputNum);
        Console.WriteLine(result);
    }

    static BigInteger CalculateFactorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        return number * CalculateFactorial(number - 1);
    }
}