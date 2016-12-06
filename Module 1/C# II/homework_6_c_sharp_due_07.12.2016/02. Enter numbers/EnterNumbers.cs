/*
Enter numbers

Description
Write a method ReadNumber(int start, int end) that enters an integer number in a given range ( start, end ).
If an invalid number or non-number text is entered, the method should throw an exception. 
Using this method write a program that enters 10 numbers: a1, a2, ..., a10, such that 1 < a1 < ... < a10 < 100

Input
You will receive 10 lines of input, each consisted of an integer number 
a1
a2
...
a10

Output
Print 1 < a1 < ... < a10 < 100 
Or Exception if the above inequality is not true

Constraints
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
5
7
15
29
46
47
60
70
89
98

87
10
29
28
43
58
95
41
2
46

5
11
20
27
49
41
52
81
89
99

Output
1 < 5 < 7 < 15 < 29 < 46 < 47 < 60 < 70 < 89 < 98 < 100

Exception

Exception
*/

using System;
using System.Linq;

class EnterNumbers
{
    private const int LEN = 10;

    public static void Main()
    {
        double[] numbers = ReadNumber(1, 100);
        bool isIncreasing = false;

        try
        {
            for (int i = 0; i < LEN - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    isIncreasing = true;
                }
                else
                {
                    isIncreasing = false;
                    break;
                }
            }

            if (!isIncreasing || numbers.Any(x => x < 0) || numbers.Any(x => x > 100))
            {
                Console.WriteLine("Exception");
            }
            else
            {
                Console.WriteLine("1 < {0} < 100", string.Join(" < ", numbers));
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Exception");
        }
    }

    private static double[] ReadNumber(int start, int end)
    {
        double[] numbers = new double[LEN];
        for (int i = 0; i < LEN; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }

        return numbers;
    }
}