/**
Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).

Input

On the first line you will receive the first char array as a string
On the second line you will receive the second char array as a string
Output

Print < if the first array is lexicographically smaller
Print > if the second array is lexicographically smaller
Print = if the arrays are equal
Constraints

1 <= size of arrays <= 128
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
hello
halo	>
food
food	=
**/

using System;

class CompareCharArrays
{
    static void Main()
    {
        char[] first = Console.ReadLine().ToCharArray();
        char[] second = Console.ReadLine().ToCharArray();
        bool areEqual = true;
        bool? isFirstSmaller = null;
        for (int i = 0; i < (first.Length < second.Length ? first.Length : second.Length); i++)
        {
            areEqual = (first[i] == second[i]);
            if (!areEqual)
            {
                isFirstSmaller = first[i] < second[i] ? true : false;
                break;
            }
        }
        if (areEqual && first.Length != second.Length)
        {
            areEqual = false;
            isFirstSmaller = first.Length < second.Length ? true : false;
        }
        Console.WriteLine(areEqual == true ? "=" : ((bool)isFirstSmaller ? "<" : ">"));
    }
}