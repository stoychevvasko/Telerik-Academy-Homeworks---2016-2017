namespace ProjectManager.Framework.Core.Common.Exceptions
{
    using System;

    public class UserValidationException : Exception
    {
        public UserValidationException(string message)
            : base(message)
        {
        }
    }
}
