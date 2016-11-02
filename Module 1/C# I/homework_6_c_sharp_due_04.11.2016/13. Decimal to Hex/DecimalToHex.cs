/**
Decimal to Hex

Description

Using loops write a program that converts an integer number to its hexadecimal representation.

The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
Input

On the first and only line you will receive an integer in the decimal numeral system.
Output

On the only output line write the hexadecimal representation of the read number.
Constraints

All numbers will always be valid 64-bit integers.
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
254	FE
6883	1AE3
338583669684	4ED528CBB4
**/

using System;
using System.Text;

class DecimalToHex
{
    static void Main()
    {
        long input = long.Parse(Console.ReadLine());
        StringBuilder builder = new StringBuilder();
        while (input > 0)
        {
            builder.Insert(0, GetHex(input % 16));
            input /= 16;
        }
        Console.WriteLine(builder);
    }

    private static string GetHex(long value)
    {
        switch (value)
        {
            case 0: return "0";
            case 1: return "1";
            case 2: return "2";
            case 3: return "3";
            case 4: return "4";
            case 5: return "5";
            case 6: return "6";
            case 7: return "7";
            case 8: return "8";
            case 9: return "9";
            case 10: return "A";
            case 11: return "B";
            case 12: return "C";
            case 13: return "D";
            case 14: return "E";
            case 15: return "F";
            default: return null;
        }
    }
}