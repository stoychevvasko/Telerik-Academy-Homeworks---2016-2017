﻿/**
Telerik Academy Season 2016-2017 / C# Fundamentals Exam - 25 April 2016

Task 3(Morning): Sum of Even Divisors

Description

Even divisors sum is called the sum of all even divisors of a given integer.

For example: 6 has 4 divisors (1, 2, 3 and 6) but only 2 and 6 of them are even, so the sum of all even divisors of 6 is 8.

You are given 2 numbers: A and B. For each number in the interval A, B sum the sum of their even divisors.

Input
•On the first input line, there will be the number A.
•On the second input line, there will be the number B.
•The input data will always be valid and in the format described. There is no need to check it explicitly.

Output
•On the only output line, write the sum of all sums.

Constraints
• 1 < A < 1000 
• 1 < B < 1000 
•Allowed working time for your program: 0.1s
•Allowed memory: 16MB

Sample tests


Input

Output


1
4 8 
5
10 34 
11
100 4118 
900
1000 80260 

**/

using System;

class SumOfEvenDivisors
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int sumOfEvenDivisors = 0;
        if (b < a)
        {
            int store = a;
            a = b;
            b = store;
        }
        for (int i = a; i <= b; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0 && j % 2 == 0)
                {
                    sumOfEvenDivisors += j;
                }
            }
        }
        Console.WriteLine(sumOfEvenDivisors);
    }
}