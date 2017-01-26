/**
Catalan Numbers

Description

In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula

Write a program to calculate the Nth Catalan number by given N
Input

On the only line, you will receive the number N
Output

Output a single number - the Nth Catalan number
Constraints

N will always be a valid integer number in the range [0, 100]
Hint: overflow is possible.
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
0	1
5	42
10	16796
15	9694845
**/

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger result = Factorial(n + n) / (Factorial(n + 1) * Factorial(n));
        Console.WriteLine(result);
    }

    private static BigInteger Factorial(BigInteger value)
    {
        if (value == 0 || value == 1) return 1;
        else return Factorial(value - 1) * value;
    }
}