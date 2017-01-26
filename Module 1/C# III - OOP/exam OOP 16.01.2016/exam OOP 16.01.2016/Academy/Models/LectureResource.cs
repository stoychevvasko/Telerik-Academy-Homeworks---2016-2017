namespace Academy.Models
{
    using System;
    using Academy.Models.Contracts;

    public class LectureResource : ILectureResouce

    {
        protected string name;
        protected string url;

        public LectureResource(string name, string url)
        {
            this.Name = name;
            this.Url = url;
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

                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentOutOfRangeException("Resource name should be between 3 and 15 symbols long!");
                }

                this.name = value;
            }
        }

        public string Url
        {
            get
            {
                return this.url;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }

                if (value.Length < 5 || value.Length > 150)
                {
                    throw new ArgumentOutOfRangeException("Resource url should be between 5 and 150 symbols long!");
                }

                this.url = value;
            }
        }
    }
}
