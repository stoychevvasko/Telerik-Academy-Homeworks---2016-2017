// <copyright file="Student.cs" company="telerikacademy.com">for educational purposes only</copyright>
// <author>*hidden*</author>

namespace ExceptionsHomeworkProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>Represents a student.</summary>
    public class Student
    {
        /// <summary>Initializes a new instance of the <see cref="Student"/> class.</summary>
        /// <param name="firstName">student's first name</param>
        /// <param name="lastName">student's last name</param>
        /// <param name="exams">a list of exams taken by the student</param>
        public Student(string firstName, string lastName, IList<Exam> exams = null)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new ArgumentException("First name cannot be null or empty!");
            }

            this.FirstName = firstName;

            if (string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentException("Last name cannot be null or empty!");
            }

            this.LastName = lastName;

            if (exams == null)
            {
                throw new ArgumentNullException("Cannot set null as exams!");
            }

            this.Exams = exams;
        }

        /// <summary>Gets the first name of a student.</summary>
        public string FirstName { get; private set; }

        /// <summary>Gets the last name of a student.</summary>
        public string LastName { get; private set; }

        /// <summary>Gets a list of exams taken by the student.</summary>
        public IList<Exam> Exams { get; private set; }

        /// <summary>Validates exams</summary>
        /// <returns>a list of exams</returns>
        public IList<ExamResult> CheckExams()
        {
            if (this.Exams == null)
            {
                throw new ArgumentNullException("Exam null reference!");
            }

            if (this.Exams.Count == 0)
            {
                Console.WriteLine("The student has no exams!");
            }

            IList<ExamResult> results = new List<ExamResult>();
            for (int i = 0; i < this.Exams.Count; i++)
            {
                results.Add(this.Exams[i].Check());
            }

            return results;
        }

        /// <summary>Calculates the average exam result in percentages.</summary>
        /// <returns>double numeric value</returns>
        public double CalcAverageExamResultInPercents()
        {
            if (this.Exams == null)
            {
                // Cannot calculate average on missing exams
                throw new ArgumentNullException("Exam null reference!");
            }

            if (this.Exams.Count == 0)
            {
                throw new ArgumentException("Cannot average missing results!");
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.CheckExams();
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }
}