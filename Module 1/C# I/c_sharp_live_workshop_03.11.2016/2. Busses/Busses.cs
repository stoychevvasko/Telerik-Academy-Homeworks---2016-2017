/**
Description

You know buses and their drivers - they all seem to have different opinion about the speed they move with. That leads to a lot of groups of buses that are grouped together. Since Stamat is a very smart and curious guy, he wants to be able to count the number of groups that are formed from a sequence of buses.

Given the sequence of the speeds of the buses, print on the console the number of groups that are formed.

Additional notes

buses cannot outrun buses in front of them
If bus A is moving faster and reaches a bus B that is moving slower, then A must lower its speed to match that of B
buses with equal speeds does not form a group
Their form different groups
Example:

busses example

Input

All input data is read from the standard input (the console)

On the first line will be the number C
The number of buses
On the next C lines there will a single integer number S
The speed of the bus
Output

The output data is printed on the standard output (the console)

On the single line on the output print the number of groups that the buses form
Constraints

C will always be between 1 and 1000
Each S will always be between 1 and 1500
The input data will always be correct and there is no need to check it explicitly
**/

using System;

class Busses
{
    static void Main()
    {
        int c = int.Parse(Console.ReadLine());
        int[] speeds = new int[c];
        for (int i = 0; i < c; i++)
        {
            speeds[i] = int.Parse(Console.ReadLine());
        }

        if (c == 1)
        {
            Console.WriteLine(1);
        }
        else
        {
            int result = 1;
            for (int i = 0; i < speeds.Length - 1; i++)
            {
                if (speeds[i] >= speeds[i + 1])
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}