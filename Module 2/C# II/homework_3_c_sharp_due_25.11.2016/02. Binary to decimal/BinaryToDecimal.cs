/*
Binary to decimal

Description
Write a program that converts a binary number N to its decimal representation.

Input
On the only line you will receive a binary number - N 
There will not be leading zeros

Output
Print the decimal representation of N on a single line 
There should not be leading zeros

Constraints
1 <= N <= 1018 = 110111100000101101101011001110100111011001000000000000000000(2)
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
10011

Output
19
*/

using System;

class BinaryToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(ConvertBinToDec(input));
    }

    static public long ConvertBinToDec(string str)
    {
        long result = 0;
        int inputBase = 2;
        foreach (char digit in str)
        {
            result = result * inputBase + (digit - '0');
        }

        return result;
    }
}
