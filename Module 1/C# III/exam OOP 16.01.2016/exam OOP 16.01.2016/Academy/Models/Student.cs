namespace Academy.Models
{
    using System;
    using System.Collections.Generic;
    using Academy.Models.Contracts;
    using Utils.Contracts;
    using Enums;
    using System.Text;

    public class Student : User, IStudent
    {
        private IList<ICourseResult> courseResults;
        private Track track;

        public Student(string username, string track)
            : base(username)
        {
            this.Track = (Track)Enum.Parse(typeof(Track), track);
        }

        public IList<ICourseResult> CourseResults
        {
            get
            {
                return this.courseResults;
            }

            set
            {
                this.courseResults = value;
            }
        }

        public Track Track
        {
            get
            {
                return this.track;
            }

            set
            {
                if (!Track.IsDefined(typeof(Track), value))
                {
                    throw new ArgumentOutOfRangeException("The provided track is not valid!");
                }

                this.track = value;
            }
        }

        public override string ToString()
        {
            StringBuilder courseResultsBuilder = new StringBuilder();

            if (this.CourseResults != null)
            {
                foreach (var item in this.CourseResults)
                {
                    courseResultsBuilder.AppendLine((item as CourseResult).ToString());
                }
            }



            string userCourseResultsText = courseResultsBuilder.ToString();
            if (userCourseResultsText.Length == 0)
            {
                userCourseResultsText = " * User has no course results!";
            }


            StringBuilder builder = new StringBuilder()
                                    .AppendLine("* Student:")
                                    .AppendLine(base.ToString())
                                    .AppendFormat(" - Track: {0}\n", this.Track)
                                    .AppendFormat(" - Course results:\n {0}", userCourseResultsText);

            return builder.ToString();
        }
    }
}
