/**
Index of letters

Description

Write a program that creates an array containing all letters from the alphabet (a-z). Read a word from the console and print the index of each of its letters in the array.

Input

On the first line you will receive the word
Output

Print the index of each of the word's letters in the array
Each index should be on a new line
Constraints

1 <= word length <= 128
Word is consisted of lowercase english letters
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
telerikacademy	19
4
11
4
17
8
10
0
2
0
3
4
12
24
**/

using System;

class IndexOfLetters
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        char[] letters = new char[]{ 'a', 'b', 'c', 'd', 'e', 'f',
            'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
            'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
            'y', 'z'};
        bool found;

        for (int i = 0; i < input.Length; i++)
        {
            found = false;

            for (int j = 0; j < 26; j++)
            {
                if (input[i] == letters[j])
                {
                    Console.WriteLine(j);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("error!");
            }
        }
    }
}