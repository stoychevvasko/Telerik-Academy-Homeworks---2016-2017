/*
Decimal to binary

Description
Write a program that converts a decimal number N to its binary representation.

Input
On the only line you will receive a decimal number - N 
There will not be leading zeros

Output
Print the binary representation of N on a single line 
There should not be leading zeros

Constraints
1 <= N <= 1018
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
19

Output
10011
*/

using System;
using System.Text;

class DecimalToBinary
{
    static void Main()
    {
        string n = Console.ReadLine();
        Console.WriteLine(ConvertDecToBin(n));
    }

    static public string ConvertDecToBin(string str)
    {
        StringBuilder sb = new StringBuilder();
        long remainder = 0;
        long num = long.Parse(str);
        while (num > 0)
        {
            remainder = num % 2L;
            sb.Insert(0, remainder);
            num /= 2L;
        }

        return sb.ToString();
    }
}