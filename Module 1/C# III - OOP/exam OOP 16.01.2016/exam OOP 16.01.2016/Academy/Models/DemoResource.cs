namespace Academy.Models
{
    using Contracts;
    using Core.Providers;
    using Enums;
    using System;
    using System.Text;

    public class DemoResource : LectureResource, ILectureResouce
    {
        public DemoResource(string name, string url) 
            : base(name, url)
        {
            this.ResourceType = ResourceType.Demo;            
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
                                    .AppendLine("     - Type: Demo")                                    ;

            return builder.ToString();
        }
    }
}
