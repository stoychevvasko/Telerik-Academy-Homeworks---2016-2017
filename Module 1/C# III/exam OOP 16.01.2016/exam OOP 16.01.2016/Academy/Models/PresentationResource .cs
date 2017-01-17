namespace Academy.Models
{
    using Contracts;
    using Enums;
    using System.Text;

    public class PresentationResource : LectureResource, ILectureResouce
    {
        public PresentationResource(string name, string url) : base(name, url)
        {
            this.ResourceType = ResourceType.Presentation;
        }

        public ResourceType ResourceType
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
                                    .AppendLine("     - Type: Presentation");

            return builder.ToString();
        }
    }
}
