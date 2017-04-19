// <copyright file="SimpleMathExam.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>*hidden*</author>

namespace ExceptionsHomeworkProject
{
    using System;

    /// <summary>Represents a Math exam.</summary>
    public class SimpleMathExam : Exam
    {
        /// <summary>Initializes a new instance of the <see cref="SimpleMathExam"/> class.</summary>
        /// <param name="problemsSolved">number of problems solved</param>
        public SimpleMathExam(int problemsSolved)
        {
            if (problemsSolved < 0)
            {
                problemsSolved = 0;
            }

            if (problemsSolved > 10)
            {
                problemsSolved = 10;
            }

            this.ProblemsSolved = problemsSolved;
        }

        /// <summary>Gets the number of problems solved.</summary>
        public int ProblemsSolved { get; private set; }

        /// <summary>Calculates exam results.</summary>
        /// <returns>ExamResults object</returns>
        public override ExamResult Check()
        {
            switch (this.ProblemsSolved)
            {
                case 0: return new ExamResult(2, 2, 6, "Bad result: nothing done.");
                case 1: return new ExamResult(4, 2, 6, "Average result: nothing done.");
                case 2: return new ExamResult(6, 2, 6, "Average result: nothing done.");
                default: throw new ArgumentOutOfRangeException("Invalid number of problems solved!");
            }
        }
    }
}