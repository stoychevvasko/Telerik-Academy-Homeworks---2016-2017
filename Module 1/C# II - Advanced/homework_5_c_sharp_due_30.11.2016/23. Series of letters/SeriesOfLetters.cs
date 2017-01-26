/*
Series of letters

Description
Write a program that reads a string from the console and replaces all series of consecutive identical letters 
with a single one.

Input
On the only input line you will receive a string

Output
Print the string without consecutive identical letters

Constraints
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
aaaaabbbbbcdddeeeedssaa

Output
abcdedsa
*/

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(RemoveRepeats(input));
    }

    private static string RemoveRepeats(string input)
    {
        StringBuilder sb = new StringBuilder(input[0].ToString());
        char previous = input[0];
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != previous)
            {
                sb.Append(input[i]);
            }
            previous = input[i];
        }
        return sb.ToString();
    }
}