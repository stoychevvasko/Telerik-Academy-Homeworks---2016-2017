/*
String length

Description
Write a program that reads from the console a string of maximum 20 characters. 
If the length of the string is less than 20, the rest of the characters should be filled with *.

Input
On the only line you will receive a string

Output
Output a string with length 20

Constraints
The length of the given string will be <= 20
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
hello
-=StringOfLength20=-

Output
hello***************
-=StringOfLength20=-
*/

using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(ModifyString(input));
    }

    private static string ModifyString(string str)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 20; i++)
        {
            if (i < str.Length)
            {
                sb.Append(str[i]);
            }
            else
            {
                sb.Append('*');
            }
        }
        return sb.ToString();
    }
}