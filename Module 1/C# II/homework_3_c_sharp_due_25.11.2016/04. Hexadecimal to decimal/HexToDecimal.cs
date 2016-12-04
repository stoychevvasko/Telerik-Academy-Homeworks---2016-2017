/*
Hexadecimal to decimal

Description
Write a program that converts a hexadecimal number N to its decimal representation.

Input
On the only line you will receive a hexadecimal number - N 
There will not be leading zeros
Letters will be uppercase

Output
Print the decimal representation of N on a single line 
There should not be leading zeros

Constraints
1 <= N <= 1018 = DE0B6B3A7640000(16)
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
13

Output
19
*/

using System;
using System.Text;

class HexToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(ConvertHexToDec(input));
    }

    static public long SimplePow(long num, long pow)
    {
        long result = 1;

        for (long i = 0; i < pow; i++)
        {
            result *= num;
        }

        return result;
    }

    static public long ConvertHexToDec(string str)
    {
        string hexDigits = "0123456789ABCDEF";
        StringBuilder num = new StringBuilder(str);
        long result = 0;
        long pow = 0;

        while (num.Length != 0)
        {
            result += ((long)hexDigits.IndexOf(num[num.Length - 1])) * SimplePow(16, pow);

            num = num.Remove(num.Length - 1, 1);
            pow++;
        }

        return result;
    }
}