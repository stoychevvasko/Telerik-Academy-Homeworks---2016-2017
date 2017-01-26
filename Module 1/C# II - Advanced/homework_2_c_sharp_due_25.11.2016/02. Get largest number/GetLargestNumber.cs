/*
Get largest number

Description
Write a method GetMax() with two parameters that returns the larger of two integers. 
Write a program that reads 3 integers from the console and prints the largest of them 
using the method GetMax().

Input
On the first line you will receive 3 integers separated by spaces

Output
Print the largest of them

Constraints
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
8 3 6
7 19 19

Output
8
19
*/

using System;

class GetLargestNumber
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int first = int.Parse(input[0]);
        int second = int.Parse(input[1]);
        int third = int.Parse(input[2]);
        Console.WriteLine(GetMax(first, GetMax(second, third)));
    }

    private static int GetMax(int first, int second)
    {
        if (first > second) return first;
        else return second;
    }
}