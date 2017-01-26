/**
Calculate Again

Description

Write a program that calculates N! / K! for given N and K.

Use only one loop.
Input

On the first line, there will be only one number - N
On the second line, there will be only one number - K
Output

Output a single line, consisting of the result from the calculation described above.
Constraints

1 < K < N < 100
Hint: overflow is possible
N and K will always be valid integer numbers
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
5
2	60
6
5	6
8
3	6720
**/

using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        Console.WriteLine((decimal)(Factorial(n)/Factorial(k)));
    }

    private static BigInteger Factorial(BigInteger value)
    {
        if (value == 0 || value == 1) return 1;
        else return Factorial(value - 1) * value;
    }
}