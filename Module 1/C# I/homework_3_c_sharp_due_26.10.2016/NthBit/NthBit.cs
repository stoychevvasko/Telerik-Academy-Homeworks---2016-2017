/**
N-th Bit

Description

Write a program that reads from the console two integer numbers P and N and prints on the console the value of P's N-th bit.

Input

On the first line you will receive the number P. On the second line you will receive the number N.
Output

Output a single value - the value of the N-th bit in P.
Constraints

N will be a positive integer and always smaller than 55.
0 <= P <= 255
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Binary representation	Output
5
2	00000000 00000000 00000101	1
0
9	00000000 00000000 00000000	0
15
1	00000000 00000000 00001111	1
5343
7	00000000 00010100 11011111	1
62241
11	00000000 11110011 00100001	0
985276
49	00001111 00001000 10111100	0
**/

using System;

class NthBit
{
    static void Main()
    {
        ulong p = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        ulong mask = (1UL << n);
        ulong result = ((p & mask) >> n);
        Console.WriteLine(result);
    }
}