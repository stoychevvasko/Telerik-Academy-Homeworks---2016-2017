namespace Academy.Models
{
    using System;
    using System.Collections.Generic;
    using Academy.Models.Contracts;
    using Common;
    using System.Globalization;
    using System.Text;

    public class Lecture : ILecture
    {
        private string name;
        private DateTime date;
        private IList<ILectureResouce> resources;
        private ITrainer trainer;

        public Lecture(string name, string date, ITrainer trainer)
        {
            this.Name = name;
            this.Date = DateTime.ParseExact(date, Constants.DefaultDateTimeFormat, CultureInfo.CurrentCulture);
            this.Trainer = trainer;
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
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
                    throw new ArgumentNullException();
                }

                if (value.Length < 5 || value.Length > 30)
                {
                    throw new ArgumentOutOfRangeException("Lecture's name should be between 5 and 30 symbols long!");
                }

                this.name = value;
            }
        }

        public IList<ILectureResouce> Resouces
        {
            get
            {
                return this.resources;
            }

            private set
            {
                this.resources = value;
            }
        }

        public ITrainer Trainer
        {
            get
            {
                return this.trainer;
            }

            set
            {
                this.trainer = value;
            }
        }

        public override string ToString()
        {
            StringBuilder resourcesBuilder = new StringBuilder();

            foreach (var item in this.Resouces)
            {
                resourcesBuilder.AppendLine((item as LectureResource).ToString());
            }

            string resourcesText = resourcesBuilder.ToString();
            if (resourcesText.Length == 0)
            {
                resourcesText = " * There are no resources in this lecture.";
            }

            StringBuilder builder = new StringBuilder()
                                    .AppendLine("* Lecture:")
                                    .AppendFormat(" - Name: {0}", this.Name)
                                    .AppendFormat(" - Date: {0}", this.Date.ToString(Constants.DefaultDateTimeFormatForPrinting))
                                    .AppendFormat(" - Trainer username: {0}", ((Trainer)this.Trainer).Username)
                                    .AppendLine(" - Resources:")
                                    .AppendLine(resourcesText);

            return builder.ToString();
        }
    }
}
