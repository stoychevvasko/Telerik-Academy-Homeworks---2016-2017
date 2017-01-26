////-----------------------------------------------------------------------
//// <copyright file="Company.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_02
{
    /// <summary>
    /// Represents a company/organization.
    /// </summary>
    public class Company : Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        /// <param name="companyName">Company name string.</param>
        public Company(string companyName)
            : base(companyName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Company"/> class.
        /// </summary>
        public Company()
            : this("Unknown company")
        {
        }
    }
}
