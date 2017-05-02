namespace SchoolSystem.Models
{
    using System;
    using Enumerations;

    /// <summary>Represents a student's mark in a certain <see cref="Subject"/>.</summary>
    public class Mark
    {
        private const float MinimumMarkValue = 2f;
        private const float MaximumMarkValue = 6f;

        private float value;
        private Subject subject;

        /// <summary>Initializes a new instance of the <see cref="Mark"/> class.</summary>
        /// <param name="subject">School subject in which a student got the mark.</param>
        /// <param name="value">Value of the student's mark.</param>
        public Mark(Subject subject, float value)
        {
            if (Enum.IsDefined(typeof(Subject), subject))
            {
                this.subject = subject;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"cannot create mark with subject (Subject){value}");
            }

            if (Mark.MinimumMarkValue > value || value > Mark.MaximumMarkValue)
            {
                throw new ArgumentOutOfRangeException($"cannot create mark with value {value}");
            }

            this.value = value;
        }

        /// <summary>Gets or sets the value of a student's mark.</summary>
        public float Value
        {
            get
            {
                return this.value;
            }

            set
            {
                if (Mark.MinimumMarkValue > value || value > Mark.MaximumMarkValue)
                {
                    throw new ArgumentOutOfRangeException($"cannot set mark value {value}");
                }

                this.value = value;
            }
        }

        /// <summary>School subject in which a student got the mark.</summary>
        public Subject Subject
        {
            get
            {
                return this.subject;
            }

            set
            {
                if (Enum.IsDefined(typeof(Subject), value))
                {
                    this.subject = (Subject)value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"cannot set mark subject (Subject){value}");
                }
            }
        }
    }
}