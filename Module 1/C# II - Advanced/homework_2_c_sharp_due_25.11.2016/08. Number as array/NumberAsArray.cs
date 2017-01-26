/*
Number as array

Description
Write a method that adds two positive integer numbers represented as arrays of digits 
(each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
Write a program that reads two arrays representing positive integers and outputs their sum.

Input
On the first line you will receive two numbers separated by spaces - the size of each array
On the second line you will receive the first array
On the third line you will receive the second array

Output
Print the sum as an array of digits (as described) 
Digits should be separated by spaces

Constraints
Each of the numbers that will be added could have up to 10 000 digits.
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
3 4
8 3 3
6 2 4 2

5 5
0 3 9 3 2
5 9 5 1 7

Output
4 6 7 2

5 2 5 5 9
*/

using System;
using System.Linq;
using System.Text;

class NumberAsArray
{
    static void Main()
    {
        string[] inputLengths = Console.ReadLine().Split(' ');

        int sizeArrFirst = int.Parse(inputLengths[0]);

        int sizeArrSecond = int.Parse(inputLengths[1]);

        int[] arrayFirst = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int[] arraySecond = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        string result = ArraySum(arrayFirst, arraySecond);
        Console.WriteLine(result);
    }

    static string ArraySum(int[] arr1, int[] arr2)
    {
        int longerArrLength = (arr1.Count() > arr2.Count()) ? arr1.Count() : arr2.Count();

        int shorterArrLength = (arr1.Count() < arr2.Count()) ? arr1.Count() : arr2.Count();

        int[] longerArr = new int[longerArrLength];

        int[] shorterArr = new int[shorterArrLength];

        if (arr1.Length > arr2.Length)
        {
            arr1.CopyTo(longerArr, 0);
            arr2.CopyTo(shorterArr, 0);
        }
        else
        {
            arr1.CopyTo(shorterArr, 0);
            arr2.CopyTo(longerArr, 0);
        }

        StringBuilder result = new StringBuilder();

        int carryOver = 0;
        for (int i = 0; i < longerArrLength; i++)
        {
            if (i < shorterArrLength)
            {
                int sum = longerArr[i] + shorterArr[i] + carryOver;
                if (sum >= 10)
                {
                    result.Append(sum % 10).Append(' ');
                    carryOver = (int)sum / 10;
                }
                else
                {
                    result.Append(sum).Append(' ');
                    carryOver = 0;
                }
            }
            else
            {
                int sum = longerArr[i] + carryOver;
                if (sum >= 10)
                {
                    result.Append(sum % 10).Append(' ');
                    carryOver = (int)sum / 10;
                }
                else
                {
                    result.Append(sum).Append(' ');
                    carryOver = 0;
                }
            }
        }
        return result.ToString();
    }
}