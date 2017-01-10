using System;
using System.Text;

namespace Problem_01
{
    /// <summary>
    /// Represents a field of study/discipline within a school model.
    /// </summary>
    public class Discipline
    {
        /// <summary>
        /// Holds the default name for the <see cref="Discipline"/> class.
        /// </summary>
        private const string DEFAULT_NAME = "Default_Discipline";

        /// <summary>
        /// Holds the default number of lectures value for the <see cref="Discipline"/> class.
        /// </summary>
        private const int DEFAULT_NUMBER_OF_LECTURES = 0;

        /// <summary>
        /// Holds the default number of exercises value for the <see cref="Discipline"/> class.
        /// </summary>
        private const int DEFAULT_NUMBER_OF_EXERCISES = 0;


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
        /// Initiates a new instance of the <see cref="Discipline"/> class.
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
        /// Initiates a new instance of the <see cref="Discipline"/> class.
        /// </summary>
        public Discipline()
            : this(Discipline.DEFAULT_NAME, Discipline.DEFAULT_NUMBER_OF_LECTURES, Discipline.DEFAULT_NUMBER_OF_EXERCISES)
        {
        }

        /// <summary>
        /// Represents the name of a discipline.
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
        /// Represents the number of lectures in a discipline.
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
        /// Represents the number of exercises in a discipline.
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
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>A <see cref="string"/> value.</returns>
        public override string ToString()
        {
            return new StringBuilder()
                       .Append(string.Format("Type: {0},  Name: {1},  Number of lectures: {2},  Number of exercises: {3}",
                                            base.ToString().Split('.')[1],
                                            this.Name,
                                            this.NumberOfLectures,
                                            this.NumberOfExercises))
                       .ToString();
        }
    }
}
