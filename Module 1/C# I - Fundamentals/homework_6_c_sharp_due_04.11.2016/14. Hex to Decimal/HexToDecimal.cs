/**
Hex to Decimal

Description

Using loops write a program that converts a hexadecimal integer number to its decimal form.

The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
Input

The input will consists of a single line containing a single hexadecimal number as string.
Output

The output should consist of a single line - the decimal representation of the number as string.
Constraints

All numbers will be valid 64-bit integers.
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
FE	254
1AE3	6883
4ED528CBB4	338583669684
**/

using System;

class HexToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        long result = 0L;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            switch (input[i])
            {
                case '0': result += 0 * Power(16, input.Length - 1 - i); break;
                case '1': result += 1 * Power(16, input.Length - 1 - i); break;
                case '2': result += 2 * Power(16, input.Length - 1 - i); break;
                case '3': result += 3 * Power(16, input.Length - 1 - i); break;
                case '4': result += 4 * Power(16, input.Length - 1 - i); break;
                case '5': result += 5 * Power(16, input.Length - 1 - i); break;
                case '6': result += 6 * Power(16, input.Length - 1 - i); break;
                case '7': result += 7 * Power(16, input.Length - 1 - i); break;
                case '8': result += 8 * Power(16, input.Length - 1 - i); break;
                case '9': result += 9 * Power(16, input.Length - 1 - i); break;
                case 'A': result += 10 * Power(16, input.Length - 1 - i); break;
                case 'B': result += 11 * Power(16, input.Length - 1 - i); break;
                case 'C': result += 12 * Power(16, input.Length - 1 - i); break;
                case 'D': result += 13 * Power(16, input.Length - 1 - i); break;
                case 'E': result += 14 * Power(16, input.Length - 1 - i); break;
                case 'F': result += 15 * Power(16, input.Length - 1 - i); break;
                default: break;
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