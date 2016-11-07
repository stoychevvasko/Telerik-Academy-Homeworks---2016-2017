/**
Your task is to count the total number of squirrel tails in the forest and send the results back to your boss, but since you don't like him, and you're about to quit because of what you saw that night - you will forge the results using some magic numbers. If the total tails count is an even number - you will multiply the result by 376439. If the total tails count is an odd number - you will divide the result by 7.

Input

The input data should be read from the console.
On the first console line you will receive a number T, that represents the number of trees in the forest. On the second console line you will receive a number B, that represents the number of branches on each tree.
On the third console line you will receive a number S, that represents the number of squirrels on each branch.
On the fourth and last console line you will receive a number N, that represents the average number of tails for each squirrel.
The input data will always be valid and in the format described. There is no need to check it explicitly.

Output

The output data should be printed on the console.
On the only output line, print the forged total tails count, with precision 3 digits after the decimal point.

Constraints

T will be a positive integer between 1 and 100000 inclusive.
B will be a positive integer between 3 and 5000 inclusive.
S will be a positive integer between 5 and 800 inclusive
N will be a positive integer between 1 and 100 inclusive.
Allowed memory: 16 MiB
Allowed working time for your program: 0.1 seconds
**/

using System;

class MutantSquirrels
{
    static void Main()
    {
        double t = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double s = double.Parse(Console.ReadLine());
        double n = double.Parse(Console.ReadLine());
        double result = t * b * s * n;
        if (result % 2 == 0) Console.WriteLine((376439 * result).ToString("0.000"));
        else Console.WriteLine((result / 7d).ToString("0.000"));
    }
}