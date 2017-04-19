// <copyright file="StartUp.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>*hidden*</author>

namespace Exceptions_Homework
{
    using System;
    using System.Collections.Generic;
    using ExceptionsHomeworkProject;

    /// <summary>Main program.</summary>
    internal class StartUp
    {
        /// <summary>Contains the main program executable.</summary>
        public static void Main()
        {
            var substr = ExceptionsHomework.Subsequence("Hello!".ToCharArray(), 2, 3);
            Console.WriteLine(substr);

            var subarr = ExceptionsHomework.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
            Console.WriteLine(string.Join(" ", subarr));

            var allarr = ExceptionsHomework.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
            Console.WriteLine(string.Join(" ", allarr));

            var emptyarr = ExceptionsHomework.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
            Console.WriteLine(string.Join(" ", emptyarr));

            Console.WriteLine(ExceptionsHomework.ExtractEnding("I love C#", 2));
            Console.WriteLine(ExceptionsHomework.ExtractEnding("Nakov", 4));
            Console.WriteLine(ExceptionsHomework.ExtractEnding("beer", 4));
            Console.WriteLine(ExceptionsHomework.ExtractEnding("Hi", 100));

            Console.WriteLine(ExceptionsHomework.CheckPrime(23) ? "23 is prime" : "23 is not prime");
            Console.WriteLine(ExceptionsHomework.CheckPrime(33) ? "33 is prime" : "33 is not prime");
            ////Console.WriteLine(CheckPrime(-10) ? "-10 is prime" : "-10 is not prime");

            List<Exam> peterExams = new List<Exam>()
            {
                new SimpleMathExam(2),
                new CSharpExam(55),
                new CSharpExam(100),
                new SimpleMathExam(1),
                new CSharpExam(0),
            };

            Student peter = new Student("Peter", "Petrov", peterExams);
            double peterAverageResult = peter.CalcAverageExamResultInPercents();
            Console.WriteLine("Average results = {0:p0}", peterAverageResult);
        }
    }
}
