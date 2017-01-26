/*
English digit
Description
Write a method that returns the last digit of given integer as an English word. 
Write a program that reads a number and prints the result of the method.

Input
On the first line you will receive a number

Output
Print the last digit of the number as an English word

Constraints
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
42

Output
two
*/

using System;

class EnglishDigit
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        PrintLastDigit(num);
    }

    private static void PrintLastDigit(int num)
    {
        int lastDigit = num % 10;
        switch (lastDigit)
        {
            case 1:
                {
                    Console.WriteLine("one");
                    break;
                }
            case 2:
                {
                    Console.WriteLine("two");
                    break;
                }
            case 3:
                {
                    Console.WriteLine("three");
                    break;
                }
            case 4:
                {
                    Console.WriteLine("four");
                    break;
                }
            case 5:
                {
                    Console.WriteLine("five");
                    break;
                }
            case 6:
                {
                    Console.WriteLine("six");
                    break;
                }
            case 7:
                {
                    Console.WriteLine("seven");
                    break;
                }
            case 8:
                {
                    Console.WriteLine("eight");
                    break;
                }
            case 9:
                {
                    Console.WriteLine("nine");
                    break;
                }
            case 0:
                {
                    Console.WriteLine("zero");
                    break;
                }
            default:
                throw new Exception(String.Format("Invalid digit {0}!", lastDigit));
        }
    }
}