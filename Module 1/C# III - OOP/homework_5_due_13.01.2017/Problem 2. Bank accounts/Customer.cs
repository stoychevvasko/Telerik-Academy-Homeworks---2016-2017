////-----------------------------------------------------------------------
//// <copyright file="Customer.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_02
{
    /// <summary>
    /// Represents a generalized customer/client.
    /// </summary>
    public abstract class Customer
    {
        /// <summary>
        /// Holds the customer's name.
        /// </summary>
        private string name;

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="name">Customer's name.</param>
        public Customer(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer()
            : this("Unknown customer")
        {
        }

        /// <summary>
        /// Gets or sets the customer's name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == string.Empty || value == null)
                {
                    throw new System.ArgumentNullException("Customer's name cannot be empty or null!");
                }

                this.name = value;
            }
        }
    }
}
