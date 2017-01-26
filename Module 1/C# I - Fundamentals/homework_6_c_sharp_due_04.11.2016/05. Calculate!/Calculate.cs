/**
Calculate!

Description

Write a program that, for a given two numbers N and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + N!/xN.

Use only one loop. Print the result with 5 digits after the decimal point.
Input

On the first line you will receive one number - N.
On the second line you will receive another number - x.
Output

Output only one number - the sum of the sequence for the given N and x.
Constraints

N will always be a valid integer between 2 and 10, inclusive.
X will always be a valid floating-point number between 0.5 and 100
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
3
2	2.75000
4
3	2.07407
5
-4	0.75781
**/

using System;

class Calculate
{
    static void Main()
    {
        ulong n = ulong.Parse(Console.ReadLine());
        decimal x = decimal.Parse(Console.ReadLine());
        decimal result = CalculateValues(n, x);
        Console.WriteLine("{0:F5}", result);
    }

    private static decimal CalculateValues(ulong intValue, decimal decimalValue)
    {
        decimal result = 1;
        for (ulong i = 1; i <= intValue; i++)
        {
            result += Factorial(i) / DecimalPower(decimalValue, i);
        }
        return result;
    }

    private static decimal DecimalPower(decimal decimalValue, ulong pow)
    {
        decimal result = 1;
        if (pow > 0)
        {
            for (ulong i = 0; i < pow; i++)
            {
                result *= decimalValue;
            }
        }
        
        return result;
    }

    private static ulong Factorial(ulong value)
    {
        if (value == 0 || value == 1) return 1;
        else return Factorial(value - 1) * value;
    }    
}