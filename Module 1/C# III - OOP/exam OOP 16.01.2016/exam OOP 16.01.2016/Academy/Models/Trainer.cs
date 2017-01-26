namespace Academy.Models
{
    using System.Collections.Generic;
    using Academy.Models.Contracts;
    using System.Text;

    public class Trainer : User, ITrainer
    {
        private IList<string> technologies;

        public Trainer(string username, string technologies)
            : base(username)
        {
            this.technologies = new List<string>();
            this.technologies.Add(technologies);

        }

        public IList<string> Technologies
        {
            get
            {
                return this.technologies;
            }

            set
            {
                this.technologies = value;
            }
        }

        public override string ToString()
        {


            StringBuilder builder = new StringBuilder()
                                    .AppendLine("* Trainer:")
                                    .AppendLine(base.ToString())
                                    .AppendFormat(" - Technologies: {0}", string.Join("; ", this.technologies[0].Split(',')));

            return builder.ToString();
        }
    }
}
