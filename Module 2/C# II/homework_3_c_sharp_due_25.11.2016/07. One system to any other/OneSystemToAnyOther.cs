/*
One system to any other

Description
Write a program to convert the number N from any numeral system of given base s 
to any other numeral system of base d.

Input
On the first line you will receive the number s
On the second line you will receive a number in base s - N 
There will not be leading zeros
On the third line you will receive the number d

Output
Print N in base d 
There should not be leading zeros
Use uppercase letters

Constraints
2 <= s, d <= 16
1 <= N <= 1018
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
13
16
9

Output
21
*/

using System;
using System.Text;

class OneSystemToAnyOther
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        string n = Console.ReadLine();
        long d = long.Parse(Console.ReadLine());
        long numAsDecimal = ConvertSToDec(n, s);
        string finalResult = ConvertDecToD(numAsDecimal, d);
        Console.WriteLine(finalResult);
    }

    public const string allDigits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz#$";

    static public long SimplePow(long num, long pow)
    {
        long result = 1L;
        for (long i = 0L; i < pow; i++) result *= num;
        return result;
    }

    static public long ConvertSToDec(string sourceNum, long numeralSys)
    {
        long result = 0L;
        long pow = 0L;
        for (int i = sourceNum.Length - 1; i >= 0; i--)
        {
            result += allDigits.IndexOf(sourceNum[i]) * SimplePow(numeralSys, pow);
            pow++;
        }

        return result;
    }

    static public string ConvertDecToD(long sourceNum, long numeralSys)
    {
        StringBuilder resultString = new StringBuilder();
        while (sourceNum > 0L)
        {
            resultString.Insert(0, allDigits[(int)(sourceNum % numeralSys)]);
            sourceNum /= numeralSys;
        }

        return resultString.ToString();
    }
}