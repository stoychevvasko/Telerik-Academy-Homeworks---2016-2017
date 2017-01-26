/**
Prime numbers

Description

Write a program that finds all prime numbers in the range [1 ... N]. Use the Sieve of Eratosthenes algorithm. The program should print the biggest prime number which is <= N.

Input

On the first line you will receive the number N
Output

Print the biggest prime number which is <= N
Constraints

2 <= N <= 10 000 000
Time limit: 0.3s
Memory limit: 64MB
Sample tests

Input	Output
13	13
126	113
26	23
**/

using System;

class PrimeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int biggestPrimeUnderN = 0;
        int[] allNumbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            allNumbers[i] = i + 1;
        }
        int sieve = 2;
        bool finished = false;
        while (!finished)
        {
            biggestPrimeUnderN = sieve;
            for (int i = 2 * sieve - 1; i < n; i += sieve)
            {
                allNumbers[i] = 0;
            }
            finished = true;
            for (int i = sieve; i < n; i++)
            {
                if (allNumbers[i] != 0)
                {
                    sieve = allNumbers[i];
                    finished = false;
                    break;
                }
            }
        }
        Console.WriteLine(biggestPrimeUnderN);
    }
}