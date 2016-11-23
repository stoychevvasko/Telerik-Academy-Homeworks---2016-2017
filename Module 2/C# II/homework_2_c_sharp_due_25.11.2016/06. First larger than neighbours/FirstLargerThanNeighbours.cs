/*
First larger than neighbours
Description
Write a method that returns the index of the first element in array that is larger
than its neighbours, or -1, if there is no such element.

Input
On the first line you will receive the number N - the size of the array
On the second line you will receive N numbers sepated by spaces - the array

Output
Print the index of the first element that is larger than its neighbours or -1 if none are

Constraints
1 <= N <= 1024
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input
6
-26 -25 -28 31 2 27

Output
1
*/

using System;

class FirstLargerThanNeighbours
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
        for (int i = 0; i < n; i++)
        {
            if (IsLargerThanNeighbours(array, i))
            {
                Console.WriteLine(i);
                break;
            }
            else if (i == n - 1)
            {
                Console.WriteLine(-1);
                break;
            }
        }
    }

    private static bool IsLargerThanNeighbours(int[] array, int position)
    {
        if (position <= 0 || position >= array.Length - 1)
        {
            return false;
        }
        else
        {
            if (array[position] > array[position + 1] && array[position] > array[position - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}