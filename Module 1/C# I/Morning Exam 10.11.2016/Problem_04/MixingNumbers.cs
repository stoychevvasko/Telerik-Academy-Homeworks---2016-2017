﻿/**
Task 4: Mixing numbers
Description

We have the following operations defined for two-digit numbers:

Mixing: mixing ab and cd produces b * c
42 mixed with 17 produces 2 * 1 = 2
17 mixed with 42 produces 7 * 4 = 28
Subtracting: I believe you know how to subtract numbers :)
42 - 17 = 25
39 - 57 = 18 (lets ignore the sign)
You have a sequence of N two-digit numbers. Your task is to mix and subtract each pair of adjacent numbers.

Input

All input data is read from the standard input (the console)

On the first line you will receive an integer N
On the next N lines you will receive N two-digit numbers
One on each line
Output

The output data is printed on the standard output (the console)

On the first output line print the mixed numbers
There should be N - 1 of them
Separate them by spaces
On the second output line print the subtracted numbers

There should be N - 1 of them
Separate them by spaces
Hint: You can use Console.WriteLine(String.Join(" ", array));

Constraints

2 <= N <= 1000
Numbers will be consisted of two non-zero digits
The input data will always be correct and there is no need to check it explicitly
Sample Tests

Sample Input 1

4
12
23
34
45
Sample Output 1

4 9 16
11 11 11
Sample Input 2

5
11
22
11
22
11
Sample Output 2

2 2 2 2
11 11 11 11
Sample Input 3

11
44
69
46
63
83
13
62
14
31
68
87
Sample Output 3

24 36 36 24 3 18 2 12 6 64
25 23 17 20 70 49 48 17 37 19
**/

using System;

class MixingNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] numbers = new string[n];
        string[] mixes = new string[n - 1];
        string[] subtractions = new string[n - 1];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Console.ReadLine();
            if (i > 0)
            {
                mixes[i - 1] = Mix(numbers[i - 1], numbers[i]);
                subtractions[i - 1] = Subtract(numbers[i - 1], numbers[i]);
            }
        }
        Console.WriteLine(String.Join(" ", mixes));
        Console.WriteLine(String.Join(" ", subtractions));
    }

    static string Mix(string left, string right)
    {
        int firstValue = int.Parse(left[1].ToString());
        int secondValue = int.Parse(right[0].ToString());
        return (firstValue * secondValue).ToString();
    }

    static string Subtract(string left, string right)
    {
        int firstValue = int.Parse(left);
        int secondValue = int.Parse(right);
        int result = firstValue - secondValue;
        if (result < 0)
        {
            result *= -1;
        }
        return result.ToString();
    }
}