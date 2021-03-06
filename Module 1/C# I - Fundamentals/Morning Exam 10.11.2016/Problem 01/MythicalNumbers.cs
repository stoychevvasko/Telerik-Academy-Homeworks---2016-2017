﻿/**
Task 1: Mythical numbers
Description

Pesho the mythical dragon has been trying to solve this task for years but with no luck. He was quite ashamed of the fact that he can't solve it and for that reason, he never asked you for any help... until now. He overcame his insecurity and he is now ready to become a master ninja ultra pro software engineer mythical programmer developer dragon. Quite the nice title, huh?

The magical number

You are given a number that is 3 digits long. Depending on the 3nd digit, you need to perform some calculations.

If the 3nd digit is zero, find the product of the first two digits.
If the 3nd digit is between 0 and 5 inclusive, find the product of the first two digits and divide the result by the 3rd digit.
If the 3nd digit is larger than 5, find the sum of the first two digits and multiply the result by the 3rd digit.
Input

On the only input line, you will receive a number that contains 3 digits.
Output

Your output should always be a single line. The content of the line should be the result of the calculations with a precision specifier of 2. (Fixed-point 2).
Constraints

The input will always contain a number that is 3 digits long.
The input will always be a positive number.
Sample tests

Input	Output
132	1.50
123	0.67
120	2.00
**/

using System;

class MythicalNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        int firstDigit = int.Parse(input[0].ToString());
        int secondDigit = int.Parse(input[1].ToString());
        int thirdDigit = int.Parse(input[2].ToString());
        double result = 0;
        if (thirdDigit > 5)
        {
            result = (firstDigit + secondDigit) * thirdDigit;
        }
        else if (thirdDigit > 0 && thirdDigit <= 5)
        {
            result = (firstDigit * secondDigit) / (double)thirdDigit;
        }
        else if (thirdDigit == 0)
        {
            result = firstDigit * secondDigit;
        }
        Console.WriteLine(result.ToString("0.00"));
    }
}