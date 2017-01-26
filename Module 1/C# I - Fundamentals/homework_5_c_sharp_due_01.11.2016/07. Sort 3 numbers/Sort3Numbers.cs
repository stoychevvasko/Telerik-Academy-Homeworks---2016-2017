/**
Sort 3 Numbers

Description

Write a program that enters 3 real numbers and prints them sorted in descending order.

Use nested if statements.
Don’t use arrays and the built-in sorting functionality.
Input

On the first three lines, you will receive the three numbers, each on a separate line.
Output

Output a single line on the console - the sorted numbers, separated by a whitespace
Constraints

The three numbers will always be valid integer numbers in the range [-1000, 1000]
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
3
2
1	3 2 1
-5
3
-5	3 -5 -5
1
2
20	20 2 1
**/

using System;

class Sort3Numbers
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

        if (num1 >= num2)
        {
            if (num2 >= num3)
            {
                // num1 >= num2 >= num3
                Console.WriteLine("{0} {1} {2}", num1, num2, num3);
            }
            else
            {
                if (num1 >= num3)
                {
                    // num1 >= num3 >= num2

                    int tempNum = num3;
                    num3 = num2;
                    num2 = tempNum;
                    Console.WriteLine("{0} {1} {2}", num1, num2, num3);
                }
                else
                {
                    // num3 >= num1 >= num2
                    int tempNum = num3;
                    num3 = num1;
                    num1 = tempNum;

                    tempNum = num3;
                    num3 = num2;
                    num2 = tempNum;
                    Console.WriteLine("{0} {1} {2}", num1, num2, num3);
                }
            }
        }
        else
        {
            if (num3 >= num2)
            {
                // num3 >= num2 >= num1
                int tempNum = num3;
                num3 = num1;
                num1 = tempNum;
                Console.WriteLine("{0} {1} {2}", num1, num2, num3);
            }
            else
            {
                if (num1 >= num3)
                {
                    // num2 >= num1 >= num3
                    int tempNum = num2;
                    num2 = num1;
                    num1 = tempNum;
                    Console.WriteLine("{0} {1} {2}", num1, num2, num3);
                }
                else
                {
                    // num2 >= num3 >= num1
                    int tempNum = num3;
                    num3 = num1;
                    num1 = tempNum;

                    tempNum = num2;
                    num2 = num1;
                    num1 = tempNum;
                    Console.WriteLine("{0} {1} {2}", num1, num2, num3);
                }
            }
        }
    }
}