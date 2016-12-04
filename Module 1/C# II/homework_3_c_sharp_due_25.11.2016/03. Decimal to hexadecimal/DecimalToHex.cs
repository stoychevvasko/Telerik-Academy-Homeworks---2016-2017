/*
Decimal to hexadecimal

Description
Write a program that converts a decimal number N to its hexadecimal representation.

Input
On the only line you will receive a decimal number - N 
There will not be leading zeros

Output
Print the hexadecimal representation of N on a single line 
There should not be leading zeros
Use uppercase letters

Constraints
1 <= N <= 1018
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
19

Output
13
*/

using System;
using System.Text;

class DecimalToHex
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(ConvertDecToHex(input));
    }

    static public string ConvertDecToHex(string str)
    {
        string hexDigits = "0123456789ABCDEF";
        long num = long.Parse(str);
        StringBuilder result = new StringBuilder();

        while (num > 0)
        {
            int index = (int)(num % 16L);
            result.Insert(0, hexDigits[index]);
            num /= 16L;
        }

        return result.ToString();
    }
}