//// <copyright file="Student.cs" company="indepentent developer">Copyright (c) Vassil Stoychev 2017. All rights reserved.</copyright>
namespace Methods
{
    using System;

    /// <summary>Represents a model student.</summary>
    internal class Student
    {
        /// <summary>Gets or sets the first name of a student.</summary>
        public string FirstName { get; set; }

        /// <summary>Gets or sets the surname of a student.</summary>
        public string LastName { get; set; }

        /// <summary>Gets or sets additional information pertaining to individual student.</summary>
        public string OtherInfo { get; set; }

        /// <summary>Evaluates whether the method-caller instance of <see cref="Student"/> is older than another <see cref="Student"/> passed as parameter.</summary><param name="other">Student for comparison with <c>this</c>.</param><returns>True if <c>this</c> student is older than <c>other student</c>, false otherwise.</returns>
        public bool IsOlderThan(Student other)
        {
            DateTime thisDateOfBirth = DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            DateTime otherDateOfBirth = DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length - 10));
            return thisDateOfBirth < otherDateOfBirth;
        }
    }
}
