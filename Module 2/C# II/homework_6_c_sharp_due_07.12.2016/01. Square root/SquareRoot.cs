/*
Square root

Description
Write a program that reads a number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye. Use try-catch-finally block.

Input
On the only line you will receive a real number

Output
Print the square root of the number or Invalid number on the first line 
Use 3 digits of precision
Print Good bye on the second line

Constraints
Time limit: 0.1s
Memory limit: 16MB

Sample tests

Input
number

4

-3.14

17

Output
Invalid number
Good bye

2.000
Good bye

Invalid number
Good bye

4.123
Good bye
*/

using System;

class SquareRoot
{
    static void Main()
    {
        string input = Console.ReadLine();

        try
        {
            double number = double.Parse(input);
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid number");
            }
            double result = Math.Sqrt(number);
            Console.WriteLine(result.ToString("0.000"));

        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.ParamName);
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Invalid number");
        }
        catch (Exception)
        {
            throw;
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}