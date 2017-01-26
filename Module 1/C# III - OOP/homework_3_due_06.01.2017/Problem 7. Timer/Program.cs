/*
Problem 7. Timer

* Using delegates write a class Timer that can execute certain method at each t seconds.
*/

using System;

namespace Problem_07
{
    class Program
    {
        static void TestMethod()
        {
            Console.WriteLine("I did something using a timer on {0}.", DateTime.Now.ToString("d MMMM yyyy @ HH:mm:ss"));
            Console.WriteLine();
        }

        static void Main()
        {
            Timer timer = new Timer();
            timer.method = TestMethod;
            timer.Play(2, 10);
        }
    }
}
