namespace Academy.Models
{
    using System;
    using System.Collections.Generic;
    using Academy.Models.Contracts;
    using Academy.Models.Common;
    using System.Text;
    using System.Globalization;

    public class Course : ICourse
    {
        private string name;
        private int lecturesPerWeek;
        private DateTime startingDate;
        private DateTime endingDate;
        private IList<IStudent> onsiteStudents;
        private IList<IStudent> onlineStudents;
        private IList<ILecture> lectures;

        public Course(string name, string lecturesPerWeek, string startingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = int.Parse(lecturesPerWeek);
            this.StartingDate = DateTime.ParseExact(startingDate, Constants.DefaultDateTimeFormat, CultureInfo.CurrentCulture);
            this.onsiteStudents = new List<IStudent>();
            this.onlineStudents = new List<IStudent>();
            this.lectures = new List<ILecture>();
        }

        public DateTime EndingDate
        {
            get
            {
                return this.startingDate.AddDays(30);
            }

            set
            {
                this.endingDate = value;
            }
        }

        public IList<ILecture> Lectures
        {
            get
            {
                return this.lectures;
            }
        }

        public int LecturesPerWeek
        {
            get
            {
                return this.lecturesPerWeek;
            }

            set
            {
                if (value < 1 || value > 7)
                {
                    throw new ArgumentOutOfRangeException("The number of lectures per week must be between 1 and 7!");
                }

                this.lecturesPerWeek = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException();
                }

                if (value.Length < 3 || value.Length > 45)
                {
                    throw new ArgumentOutOfRangeException("The name of the course must be between 3 and 45 symbols!");
                }

                this.name = value;
            }
        }

        public IList<IStudent> OnlineStudents
        {
            get
            {
                return this.onsiteStudents;
            }
        }

        public IList<IStudent> OnsiteStudents
        {
            get
            {
                return this.onlineStudents;
            }
        }

        public DateTime StartingDate
        {
            get
            {
                return this.startingDate;
            }

            set
            {
                this.startingDate = value;
            }
        }

        public override string ToString()
        {
            StringBuilder lecturesBuilder = new StringBuilder();
            foreach (var item in this.Lectures)
            {
                lecturesBuilder.AppendLine((item as Lecture).ToString());
            }

            string lecturesText = lecturesBuilder.ToString();
            if (lecturesText.Length == 0)
            {
                lecturesText = " * There are no lectures in this course!";
            }

            StringBuilder builder = new StringBuilder()
                                    .AppendLine("* Course:")
                                    .AppendFormat(" - Name: {0}\n", this.Name)
                                    .AppendFormat(" - Lectures per week: {0}\n", this.LecturesPerWeek)
                                    .AppendFormat(" - Starting date: {0}\n", this.StartingDate.ToString(Constants.DefaultDateTimeFormatForPrinting))
                                    .AppendFormat(" - Ending date: {0}\n", this.EndingDate.ToString(Constants.DefaultDateTimeFormatForPrinting))
                                    .AppendFormat(" - Onsite students: {0}\n", this.onsiteStudents.Count)
                                    .AppendFormat(" - Online students: {0}\n", this.onlineStudents.Count)
                                    .AppendFormat(" - Lectures:\n {0}", lecturesText);

            return builder.ToString();
        }
    }
}
