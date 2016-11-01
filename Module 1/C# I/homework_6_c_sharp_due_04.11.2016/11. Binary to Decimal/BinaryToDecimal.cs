/**
Binary to Decimal

Description

Using loops write a program that converts a binary integer number to its decimal form.

The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
Input

You will receive exactly one line containing an integer number representation in binary
Output

On the only output line write the decimal representation of the number
Constraints

All input numbers will be valid 32-bit integers
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
0	0
11	3
1010101010101011	43691
1110000110000101100101000000	236476736
**/

using System;

class BinaryToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        long result = 0L;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            if (input[i] == '1')
            {
                result += Power(2, input.Length - 1 - i);
            }
        }
        Console.WriteLine(result);
    }

    private static long Power(int baseNum, int power)
    {
        if (baseNum == 0)
        {
            return 0;
        }
        else if (power == 0)
        {
            return 1;
        }
        else
        {
            long result = 1L;
            for (int i = 1; i <= power; i++)
            {
                result *= baseNum;
            }
            return result;
        }
    }
}