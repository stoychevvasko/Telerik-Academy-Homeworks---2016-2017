namespace Academy.Models
{
    using Common;
    using Contracts;
    using Core.Providers;
    using Enums;
    using System;
    using System.Text;

    public class VideoResource : LectureResource, ILectureResouce
    {
        public VideoResource(string name, string url) : base(name, url)
        {
            this.ResourceType = ResourceType.Video;
            this.UploadedOn = DateTimeProvider.Now;
        }

        public ResourceType ResourceType
        {
            get;
            set;
        }

        public DateTime UploadedOn
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
                                    .AppendLine("     - Type: Video")
                                    .AppendFormat("     - Uploaded on: {0}", this.UploadedOn.ToString(Constants.DefaultDateTimeFormatForPrinting));

            return builder.ToString();
        }
    }
}
