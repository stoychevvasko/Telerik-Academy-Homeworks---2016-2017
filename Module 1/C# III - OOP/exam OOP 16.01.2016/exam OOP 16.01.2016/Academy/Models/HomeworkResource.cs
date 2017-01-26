namespace Academy.Models
{
    using Common;
    using Contracts;
    using Core.Providers;
    using Enums;
    using System;
    using System.Text;

    public class HomeworkResource : LectureResource, ILectureResouce
    {
        public HomeworkResource(string name, string url) : base(name, url)
        {
            this.ResourceType = ResourceType.Homework;
            this.DueDate = DateTimeProvider.Now.AddDays(7);
        }

        public ResourceType ResourceType
        {
            get;
            set;
        }

        public DateTime DueDate
        {
            get;
            set;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder()
                                    .AppendLine("    * Resource:")
                                    .AppendFormat("     - Name: {0}\n", this.Name)
                                    .AppendFormat("     - Url: {0}\n", this.Url)
                                    .AppendLine("     - Type: Homework")
                                    .AppendFormat("     - Due date: {0}", this.DueDate.ToString(Constants.DefaultDateTimeFormatForPrinting));

            return builder.ToString();
        }
    }
}
