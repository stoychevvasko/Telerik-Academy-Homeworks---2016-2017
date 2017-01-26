/*
Correct brackets

Description
Write a program to check if in a given expression the ( and ) brackets are put correctly.

Input
On the only line you will receive an expression

Output
Print Correct if the brackets are correct 
Incorrect otherwise

Constraints
1 <= length of expression <= 10000
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
((a+b)/5-d)
)(a+b))

Output
Correct
Incorrect
*/

using System;

class CorrectBrackets
{
    static void Main()
    {
        string expression = Console.ReadLine();
        Console.WriteLine(CheckBrackets(expression) ? "Correct" : "Incorrect");
    }

    private static bool CheckBrackets(string str)
    {
        return str.Split('(').Length == str.Split(')').Length;
    }
}