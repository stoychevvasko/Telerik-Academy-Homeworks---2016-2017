﻿/*
Say Hello
Description
Write a method that asks the user for his name and prints Hello, <name>!. Write a program to test this method.

Input
On the first line you will receive a name

Output
Print Hello, <name>!

Constraints
Time limit: 0.1s
Memory limit: 16MB

Sample tests:
Input
Peter

Output
Hello, Peter!
*/

using System;

class SayHello
{
    static void Main()
    {
        string input = Console.ReadLine();
        PrintHello(input);
    }

    private static void PrintHello(string input)
    {
        Console.WriteLine("Hello, {0}!", input);
    }
}