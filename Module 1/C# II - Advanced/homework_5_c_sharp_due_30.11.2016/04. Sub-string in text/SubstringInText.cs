/*
Sub-string in text

Description
Write a program that finds how many times a sub-string is contained in 
a given text (perform case insensitive search).

Input
On the first line you will receive a string - the pattern
On the second line you will receive a string - the text

Output
Print a number on a single line 
The number of occurrences

Constraints
The length of the two strings will be <= 4096
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
in
We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

Output
9
*/

using System;

class SubstringInText
{
    static void Main()
    {
        string pattern = Console.ReadLine();
        string text = Console.ReadLine();
        Console.WriteLine(CountOccurences(pattern.ToLower(), text.ToLower()));
    }

    private static int CountOccurences(string pattern, string text)
    {
        return (text.Length - text.Replace(pattern, String.Empty).Length) / pattern.Length;
    }
}