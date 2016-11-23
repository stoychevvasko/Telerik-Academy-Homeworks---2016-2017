/*
Reverse number

Description
Write a method that reverses the digits of a given decimal number.

Input
On the first line you will receive a number

Output
Print the given number with reversed digits

Constraints
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
256
123.45

Output
652
54.321
*/

using System;
using System.Text;

class ReverseNumber
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(Reverse(input));
    }

    private static decimal Reverse(string input)
    {
        StringBuilder b = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            b.Insert(0, input[i]);
        }
        return decimal.Parse(b.ToString());
    }
}