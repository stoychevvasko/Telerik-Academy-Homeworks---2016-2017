/**
GCD

Description

Write a program that calculates the greatest common divisor (GCD) of given two integers A and B.

Use the Euclidean algorithm (find it in Internet).
Input

On the first and only line of the input you will receive the 2 integers A and B, separated by a whitespace.
Output

Output a single number - the GCD of the numbers A and B.
Constraints

The numbers A and B will always be valid integers in the range [2, 500].
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
3 2	1
60 40	20
5 15	5
**/

using System;
using System.Collections.Generic;

class GCD
{
    static void Main()
    {
        string input = Console.ReadLine();
        uint a = uint.Parse(input.Split(' ')[0]);
        uint b = uint.Parse(input.Split(' ')[1]);
        List<uint> divisors = new List<uint>();
        if (b > a)
        {
            uint store = a;
            a = b;
            b = store;
        }
        for (int i = 1; i <= b; i++)
        {
            if (a % i == 0 && b % i == 0) divisors.Add((uint)i);
        }
        Console.WriteLine(divisors[divisors.Count - 1]);
    }
}