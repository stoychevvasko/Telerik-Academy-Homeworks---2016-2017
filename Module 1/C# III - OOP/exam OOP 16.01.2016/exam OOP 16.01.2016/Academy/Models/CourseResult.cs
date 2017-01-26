namespace Academy.Models
{
    using System;
    using Academy.Models.Contracts;
    using Academy.Models.Enums;
    using Academy.Models.Utils.Contracts;
    using System.Text;

    public class CourseResult : ICourseResult
    {
        private ICourse course;
        private float coursePoints;
        private float examPoints;

        public CourseResult(ICourse course, string examPoints, string coursePoints)
        {
            this.Course = course;
            this.ExamPoints = float.Parse(examPoints);
            this.CoursePoints = float.Parse(coursePoints);
        }

        public ICourse Course
        {
            get
            {
                return this.course;
            }

            private set
            {
                this.course = value;
            }
        }

        public float CoursePoints
        {
            get
            {
                return this.coursePoints;
            }

            private set
            {
                if (value < 0 || value > 125)
                {
                    throw new ArgumentOutOfRangeException("Course result's course points should be between 0 and 125!");
                }

                this.coursePoints = value;
            }
        }

        public float ExamPoints
        {
            get
            {
                return this.examPoints;
            }

            private set
            {
                if (value < 0 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException("Course result's exam points should be between 0 and 1000!");
                }

                this.examPoints = value;
            }
        }

        public Grade Grade
        {
            get
            {
                if (this.ExamPoints >= 65 && this.CoursePoints >= 75)
                {
                    return Grade.Excellent;
                }
                else if ((this.ExamPoints < 60 && this.ExamPoints >= 30) || (this.CoursePoints < 75 && this.CoursePoints >= 45))
                {
                    return Grade.Passed;
                }
                else
                {
                    return Grade.Failed;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder()
                                    .AppendFormat(
                                        "* {0}: Points - {1}, Grade - {2}",
                                        this.Course.Name,
                                        this.CoursePoints,
                                        this.Grade);

            return builder.ToString();
        }
    }
}
