using System;
using System.Text;

namespace Academy.Models
{
    public abstract class User : IUser
    {
        protected string username;

        public User(string username)
        {
            this.Username = username;
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException();
                }

                if (value.Length < 3 || value.Length > 16)
                {
                    throw new ArgumentOutOfRangeException("User's username should be between 3 and 16 symbols long!");
                }

                this.username = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder()
                                    .AppendFormat(" - Username: {0}", this.Username);

            return builder.ToString();
        }
    }
}
