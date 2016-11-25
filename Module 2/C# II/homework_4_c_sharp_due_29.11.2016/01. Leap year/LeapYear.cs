/*
Leap year

Description
Write a program that reads a year from the console and checks whether it is a leap one.
Hint: Use System.DateTime.

Input
On the only line you will receive a number - the year

Output
Print "Leap" or "Common" on a single line depending on the year

Constraints
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
2016
1996
1900
2000
681
3400

Output
Leap
Leap
Common
Leap
Common
Common
*/

using System;

class LeapYear
{
    static void Main()
    {
        DateTime inputYear = new DateTime(int.Parse(Console.ReadLine()), 1, 1);
        Console.WriteLine("{0}", IsLeapYear(inputYear) ? "Leap" : "Common");
    }

    static bool IsLeapYear(DateTime d)
    {
        DateTime lastDayOfFebruary = (new DateTime(d.Year, 3, 1)).AddDays(-1);
        if (lastDayOfFebruary.Day == 29) return true;
        else return false;
    }
}