/*
Reverse string

Description
Write a program that reads a string, reverses it and prints the result on the console.

Input
On the only line you will receive a string

Output
Print the string in reverse on a single line

Constraints
1 <= size of string <= 10000
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
sample
somestring

Output
elpmas
gnirtsemos
*/

using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(Reverse(input));
    }

    private static string Reverse(string input)
    {
        StringBuilder sb = new StringBuilder();
        foreach (char c in input)
        {
            sb.Insert(0, c);
        }

        return sb.ToString();
    }
}