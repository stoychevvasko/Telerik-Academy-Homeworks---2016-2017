/*
Parse tags

Description
You are given a text. Write a program that changes the text in all regions surrounded by 
the tags <upcase> and </upcase> to upper-case.

Input
On the only line you will receive a string - the text

Output
Print the changed string on one line

Constraints
The tags will not be nested.
String length will be <= 10000
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

Output
We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
*/

using System;
using System.Text;

class ParseTags
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(ApplyUpperCase(input));
    }

    private static string ApplyUpperCase(string input)
    {
        StringBuilder sb = new StringBuilder();
        bool copyEnabled = true;
        bool upcaseEnabled = false;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i].CompareTo('<') == 0)
            {
                copyEnabled = false;
                if (i + 6 < input.Length && input.Substring(i + 1, 6).ToLower() == "upcase")
                {
                    upcaseEnabled = true;
                }
                if (i + 7 < input.Length && input.Substring(i + 1, 7).ToLower() == "/upcase")
                {
                    upcaseEnabled = false;
                }
            }
            else if (input[i].CompareTo('>') == 0)
            {
                copyEnabled = true;
            }
            else
            {
                if (copyEnabled)
                {
                    if (upcaseEnabled)
                    {
                        sb.Append(input[i].ToString().ToUpper());
                    }
                    else
                    {
                        sb.Append(input[i]);
                    }
                }
            }
        }

        return sb.ToString();
    }
}