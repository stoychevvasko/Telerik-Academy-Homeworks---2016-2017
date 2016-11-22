﻿/*
Appearance count
Description
Write a method that counts how many times given number appears in a given array. 
Write a test program to check if the method is working correctly.

Input
On the first line you will receive a number N - the size of the array
On the second line you will receive N numbers separated by spaces - the numbers in the array
On the third line you will receive a number X

Output
Print how many times the number X appears in the array

Constraints
1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
8
28 6 21 6 -7856 73 73 -56
73

Output
2
*/

using System;

class AppearanceCount
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] input = Console.ReadLine().Split(' ');
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(input[i]);
        }

        int x = int.Parse(Console.ReadLine());

        Console.WriteLine(Count(n, array, x));
    }

    private static int Count(int n, int[] array, int x)
    {
        int result = 0;
        foreach (var item in array)
        {
            if (item == x) result++;
        }

        return result;
    }
}