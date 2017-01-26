/**
Description

In combinatorics, the number of ways to choose N different members out of a group of N different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards. Your task is to write a program that calculates N! / (K! * (N - K)!) for given N and K.

Try to use only two loops.
Input

On the first line, there will be only one number - N
On the second line, there will also be only one number - K
Output

On the only output line, write the result of the calculation for the provided N and K
Constraints

1 < K < N < 100
Hint: overflow is possible
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
3 
2	3
4 
2	6
10
6	210
52
5	2598960
**/

using System;
using System.Numerics;

class Calculate3
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger k = BigInteger.Parse(Console.ReadLine());

        decimal result = (decimal)((Factorial(n)) / (Factorial(k) * Factorial(n - k)));
        Console.WriteLine(result);
    }

    private static BigInteger Factorial(BigInteger value)
    {
        if (value == 0 || value == 1) return 1;
        else return Factorial(value - 1) * value;
    }
}