﻿/*
Sum integers

Description
You are given a sequence of positive integer values written into a string, separated by spaces. 
Write a function that reads these values from given string and calculates their sum. 
Write a program that reads a string of positive integers separated by spaces and prints their sum.

Input
On the only line you will receive a string consisted of positive integers

Output
Print the sum of the integers

Constraints
Each number will be in the interval [ 1, 1000 ]
There will not be more than 1000 numbers
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
43 68 9 23 318

Output
461
*/

using System;

class SumIntegers
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        int result = MySum(numbers);
        Console.WriteLine(result);
    }

    private static int MySum(int[] numbers)
    {
        int result = 0;
        foreach (var item in numbers)
        {
            result += item;
        }

        return result;
    }
}