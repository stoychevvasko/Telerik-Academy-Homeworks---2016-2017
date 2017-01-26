/*
Unicode characters

Description
Write a program that converts a string to a sequence of C# Unicode character literals.

Input
On the only input line you will receive a string

Output
Print the string in C# Unicode character literals on a single line

Constraints
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
Hi!

Output
\u0048\u0069\u0021
*/

using System;
using System.Globalization;
using System.Text;
using System.Threading;

class UnicodeCharacters
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            sb.Append(String.Format("\\u{0:X4}", (int)input[i]));
        }

        Console.WriteLine(sb);
    }
}