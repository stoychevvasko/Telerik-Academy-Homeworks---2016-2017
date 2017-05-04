namespace ProjectManager.Common.Exceptions
{
    using System;

    public class UserValidationException : Exception
    {
        public UserValidationException(string message)
            : base(" - Error: " + message)
        {
        }
    }
}
