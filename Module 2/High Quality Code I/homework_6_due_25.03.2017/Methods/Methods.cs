//// <copyright file="Methods.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Methods
{
    using System;

    public class Methods
    {
        /// <summary>Calculates the surface area of a 2-dimensional triangle shape.</summary><param name="a">A triangle side.</param><param name="b">A triangle side.</param><param name="c">A triangle side.</param><returns>The surface area calculated.</returns>
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                Console.Error.WriteLine("Sides should be positive.");
                throw new ArgumentOutOfRangeException("Cannot have negative values for triangle sides!");
            }

            double semiPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
            return area;
        }

        /// <summary>Converts an integer number into its string name.</summary><param name="number">Original number as integer.</param><returns>The string value that matches.</returns>
        static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentOutOfRangeException("Invalid number!");
            }
        }

        /// <summary>Finds the maximum element among an array of integers.</summary><param name="elements">Original array of integers.</param><returns>Maximum element found.</returns>
        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentOutOfRangeException("Invalid array!");
            }

            int max = elements[0];

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        static void PrintAsNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }


        static double CalcDistance(double x1, double y1, double x2, double y2,
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (y1 == y2);
            isVertical = (x1 == x2);

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToDigit(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
