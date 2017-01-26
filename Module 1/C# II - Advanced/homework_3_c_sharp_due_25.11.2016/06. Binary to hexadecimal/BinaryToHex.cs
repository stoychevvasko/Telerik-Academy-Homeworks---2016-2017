/*
Binary to hexadecimal

Description
Write a program to convert binary numbers to hexadecimal numbers (directly).

Input
On the only line you will receive a decimal number - N 
There will not be leading zeros

Output
Print the its binary representation on a single line 
There should not be leading zeros
Use uppercase letters

Constraints
1 <= N <= 1018 = 110111100000101101101011001110100111011001000000000000000000(2)
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
10011

Output
13
*/

using System;
using System.Text;

class BinaryToHex
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(ConvertBinToHex(input));
    }

    static public string ConvertBinToHex(string str)
    {
        string hexDigits = "0123456789ABCDEF";
        StringBuilder sourceString = new StringBuilder(str);
        StringBuilder resultString = new StringBuilder();

        while (sourceString.Length % 4 != 0)
        {
            sourceString.Insert(0, "0");
        }

        while (sourceString.Length > 0)
        {
            string halfByteStr = sourceString.ToString().Substring(0, 4);
            sourceString.Remove(0, 4);

            int halfByte = Convert.ToInt32(halfByteStr, 2);
            resultString.Append(hexDigits[halfByte]);
        }

        return resultString.ToString();
    }
}