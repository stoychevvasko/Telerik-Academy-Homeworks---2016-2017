/**
Four digits

Description

Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:

Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4) and prints it on the console.
Prints on the console the number in reversed order: dcba (in our example 1102) and prints the reversed number.
Puts the last digit in the first position: dabc (in our example 1201) and prints the result.
Exchanges the second and the third digits: acbd (in our example 2101) and prints the result.
Input

The input will consist of a single four-digit integer number on a single line.
Output

Output the result of each action on a separate line, in the same order as they are explained above:
meaning the sum comes on the first line, the reversed number on the second, and so on.
Constraints

The number will always be a valid positive four-digit integer.
The number will always start with a digit other than 0.
Time limit: 0.1s
Memory limit: 16MB
Sample tests

Input	Output
2011	4
1102
1201
2101
3333	12
3333
3333
3333
9876	30
6789
6987
9786
1230	6
0321
0123
1320
**/

using System;

class FourDigits
{
    static void Main()
    {
        string sourceNum = Console.ReadLine();
        int digitOne = int.Parse(sourceNum.Substring(0, 1));
        int digitTwo = int.Parse(sourceNum.Substring(1, 1));
        int digitThree = int.Parse(sourceNum.Substring(2, 1));
        int digitFour = int.Parse(sourceNum.Substring(3, 1));

        int sum = digitOne + digitTwo + digitThree + digitFour;
        Console.WriteLine(sum);

        string reversed = string.Format("{0}{1}{2}{3}", digitFour, digitThree, digitTwo, digitOne);
        Console.WriteLine(reversed);

        string lastFirst = string.Format("{0}{1}{2}{3}", digitFour, digitOne, digitTwo, digitThree);
        Console.WriteLine(lastFirst);

        string twoThreeSwapped = string.Format("{0}{1}{2}{3}", digitOne, digitThree, digitTwo, digitFour);
        Console.WriteLine(twoThreeSwapped);
    }
}