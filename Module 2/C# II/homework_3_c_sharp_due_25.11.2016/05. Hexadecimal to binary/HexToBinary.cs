/*
Hexadecimal to binary

Description
Write a program to convert hexadecimal numbers to binary numbers (directly).

Input
On the only line you will receive a decimal number - N 
There will not be leading zeros
Letters will be uppercase

Output
Print the its binary representation on a single line 
There should not be leading zeros

Constraints
1 <= N <= 1018 = DE0B6B3A7640000(16)
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
13

Output
10011
*/

using System;
using System.Text;

class HexToBinary
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(ConvertHexToBin(input));
    }

    static string ConvertHexToBin(string numBase16)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < numBase16.Length; i++)
        {
            sb.Append(Translate(numBase16[i]));
        }

        string result = sb.ToString().TrimStart('0');
        result = result.Length > 0 ? result : "0";
        return result;
    }

    static string Translate(char num)
    {
        switch (num)
        {
            case '0': return "0000";
            case '1': return "0001";
            case '2': return "0010";
            case '3': return "0011";
            case '4': return "0100";
            case '5': return "0101";
            case '6': return "0110";
            case '7': return "0111";
            case '8': return "1000";
            case '9': return "1001";
            case 'A': return "1010";
            case 'B': return "1011";
            case 'C': return "1100";
            case 'D': return "1101";
            case 'E': return "1110";
            case 'F': return "1111";
            default: return null;
        }
    }
}