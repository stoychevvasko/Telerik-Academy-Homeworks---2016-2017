/*
Integer calculations

Description

Write methods to calculate minimum, maximum, average, sum and product of given set 
of integer numbers. Use variable number of arguments. 
Write a program that reads 5 elements and prints their minimum, maximum, average, sum and product.

Input
On the first line you will receive 5 numbers separated by spaces

Output
Print their minimum, maximum, average, sum and product 
Each on a new line
The average value should be printed with two digits of precision

Constraints
Each of the five numbers will be in the interval [ -1000, 1000 ]
Time limit: 0.1s
Memory limit: 16MB

Sample tests
 
Input
3 7 9 18 0

Output
0
18
7.40
37
0
*/

using System;

class IntegerCalculations
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[input.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        Console.WriteLine(MyMinimum(numbers));
        Console.WriteLine(MyMaximum(numbers));
        Console.WriteLine("{0:F2}", MyAverage(numbers));
        Console.WriteLine(MySum(numbers));
        Console.WriteLine(MyProduct(numbers));
    }

    static public int MyMinimum(params int[] nums)
    {
        int min = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            if (min > nums[i])
            {
                min = nums[i];
            }
        }

        return min;
    }

    static public int MyMaximum(params int[] nums)
    {
        int max = nums[0];

        for (int i = 0; i < nums.Length; i++)
        {
            if (max < nums[i])
            {
                max = nums[i];
            }
        }

        return max;
    }

    static public double MyAverage(params int[] nums)
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        double result = (double)sum / nums.Length;

        return result;
    }

    static public int MySum(params int[] nums)
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
        }

        return sum;
    }

    static public long MyProduct(params int[] nums)
    {
        long product = 1L;

        for (int i = 0; i < nums.Length; i++)
        {
            product *= nums[i];
        }

        return product;
    }
}