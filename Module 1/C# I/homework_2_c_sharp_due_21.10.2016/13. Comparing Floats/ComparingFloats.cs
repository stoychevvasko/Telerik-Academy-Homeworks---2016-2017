using System;

class ComparingFloats
{
    static void Main()
    {
        double a = Double.Parse(Console.ReadLine());
        double b = Double.Parse(Console.ReadLine());
        double eps = 0.000001;

        Console.WriteLine((Math.Abs(a - b) < eps).ToString().ToLower());
    }
}