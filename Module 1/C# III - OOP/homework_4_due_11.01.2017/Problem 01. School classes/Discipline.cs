////-----------------------------------------------------------------------
//// <copyright file="Discipline.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_01
{
    using System;
    using System.Text;

    /// <summary>
    /// Represents a field of study/discipline within a school model.
    /// </summary>
    public class Discipline : IComment
    {
        /// <summary>
        /// Holds the default name for the <see cref="Discipline"/> class.
        /// </summary>
        private const string DefaultName = "Default_Discipline";

        /// <summary>
        /// Holds the default number of lectures value for the <see cref="Discipline"/> class.
        /// </summary>
        private const int DefaultNumberOfLectures = 0;

        /// <summary>
        /// Holds the default number of exercises value for the <see cref="Discipline"/> class.
        /// </summary>
        private const int DefaultNumberOfExercises = 0;

        /// <summary>
        /// Holds the name of a discipline.
        /// </summary>
        private string name;

        /// <summary>
        /// Holds the number of lectures in a discipline.
        /// </summary>
        private int numberOfLectures;

        /// <summary>
        /// Holds the number of exercises in a discipline.
        /// </summary>
        private int numberOfExercises;

        /// <summary>
        /// Initializes a new instance of the <see cref="Discipline"/> class.
        /// </summary>
        /// <param name="name">Discipline name.</param>
        /// <param name="numberOfLectures">Number of lectures.</param>
        /// <param name="numberOfExercises">Number of exercises.</param>
        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Discipline"/> class.
        /// </summary>
        public Discipline()
            : this(Discipline.DefaultName, Discipline.DefaultNumberOfLectures, Discipline.DefaultNumberOfExercises)
        {
        }

        /// <summary>
        /// Gets the name of a discipline.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(string.Format("Cannot set {0} as discipline name - unexpected value!", value));
                }

                this.name = value;
            }
        }

        /// <summary>
        /// Gets the number of lectures in a discipline.
        /// </summary>
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Cannot set {0} as number of lectures - unexpected value!", value));
                }

                this.numberOfLectures = value;
            }
        }

        /// <summary>
        /// Gets the number of exercises in a discipline.
        /// </summary>
        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(string.Format("Cannot set {0} as number of exercises - unexpected value!", value));
                }

                this.numberOfExercises = value;
            }
        }

        /// <summary>
        /// Gets all comments as a single <see cref="string"/>.
        /// </summary>
        public string Comments
        {
            get;
            private set;
        }

        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A <see cref="string"/> value.</returns>
        public override string ToString()
        {
            return new StringBuilder().Append(string.Format(
                                                "Type: {0},  Name: {1},  Number of lectures: {2},  Number of exercises: {3}",
                                                 base.ToString().Split('.')[1],
                                                 this.Name,
                                                 this.NumberOfLectures,
                                                 this.NumberOfExercises))
                                      .ToString();
        }

        /// <summary>
        /// Clears all comments.
        /// </summary>
        public void ClearComments()
        {
            this.Comments = null;
        }

        /// <summary>
        /// Adds a new comment.
        /// </summary>
        /// <param name="comment">A <see cref="string"/>.</param>
        public void AddComment(string comment)
        {
            if (this.Comments == null)
            {
                this.Comments = string.Empty;
            }

            this.Comments += string.Format("\n\n-[new {0} comment @{1}]---\n{2}\n-----", this.GetType().ToString().Split('.')[1], DateTime.Now, comment);
        }
    }
}
