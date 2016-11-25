/*
Binary short

Description
Write a program that shows the binary representation of given 16-bit signed integer number N (the C# type short).

Input
On the only line you will receive a decimal number - N

Output
Print the its binary representation on a single line 
There should be exactly 16 digits of output

Constraints
-215 <= N < 215
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
11
-11

Output
0000000000001011
1111111111110101
*/

using System;
using System.Text;

class BinaryShort
{
    static void Main()
    {
        string n = Console.ReadLine();
        Console.WriteLine(ConvertToShort(n));
    }

    public static string ConvertToShort(string str)
    {
        StringBuilder binRepresentation = new StringBuilder();
        short num = short.Parse(str);
        for (int i = 0; i < 16; i++)
        {
            char bit = ((num & (1 << i)) != 0) ? '1' : '0';
            binRepresentation.Insert(0, bit);
        }

        return binRepresentation.ToString();
    }
}