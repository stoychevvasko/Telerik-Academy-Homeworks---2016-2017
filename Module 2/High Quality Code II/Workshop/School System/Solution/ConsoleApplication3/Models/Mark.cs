using SchoolSystem.Models.Enumerations;

namespace SchoolSystem.Models
{
    public class Mark
    {
        private float value;

        private Subject subject;

        public Mark(Subject subject, float value)
        {
            this.subject = subject;
            this.value = value;
        }        

        public float Value
        {
            get
            {
                return this.value;
            }

            set
            {
                this.value = value;
            }
        }

        public Subject Subject
        {
            get
            {
                return this.subject;
            }

            set
            {
                this.subject = value;
            }
        }
    }
}
