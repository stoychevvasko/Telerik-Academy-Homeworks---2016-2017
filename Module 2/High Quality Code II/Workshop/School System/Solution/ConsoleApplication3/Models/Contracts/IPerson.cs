namespace SchoolSystem.Models.Contracts
{
    /// <summary>Provides person-related functionality.</summary>
    public interface IPerson
    {
        /// <summary>Gets or sets person's first name.</summary>
        string FirstName
        {
            get;
            set;
        }

        /// <summary>Gets or sets person's last name.</summary>
        string LastName
        {
            get;
            set;
        }
    }
}
