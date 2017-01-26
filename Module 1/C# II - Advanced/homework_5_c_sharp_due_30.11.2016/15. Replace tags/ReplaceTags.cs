﻿/*
Replace tags

Description
Write a program that replaces in a HTML document given as string all the tags <a href="URL">TEXT</a> 
with corresponding markdown notation [TEXT](URL).

Input
On the only input line you will receive a string

Output
Print the string with replaced tags

Constraints
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>

Output
<p>Please visit [our site](http://academy.telerik.com) to choose a training course. Also visit [our forum](www.devbg.org) to discuss the courses.</p>
*/

using System;
using System.Text.RegularExpressions;

class ReplaceTags
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        string result = Regex.Replace(inputStr, @"<a.href=""([^>]*)"">([^<]*(?:(?!</a)<[^<]*)*)</a>", "[$2]($1)");
        Console.WriteLine(result);
    }
}