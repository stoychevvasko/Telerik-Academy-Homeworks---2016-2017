////-----------------------------------------------------------------------
//// <copyright file="Account.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_02
{
    using System;

    /// <summary>
    /// Represents a generalized bank account.
    /// </summary>
    public abstract class Account
    {
        /// <summary>
        /// Holds the account holder of this bank account.
        /// </summary>
        private Customer accountHolder;

        /// <summary>
        /// Holds the current balance of this bank account.
        /// </summary>
        private decimal balance;

        /// <summary>
        /// Holds the interest rate currently applied to this bank account.
        /// </summary>
        private decimal interestRate;

        /// <summary>
        /// Initializes a new instance of the <see cref="Account"/> class.
        /// </summary>
        /// <param name="holder">Account holder.</param>
        /// <param name="balance">Starting balance.</param>
        /// <param name="interestRate">Interest rate percentage.</param>
        public Account(Customer holder, decimal balance, decimal interestRate)
        {
            this.accountHolder = holder;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        /// <summary>
        /// Gets or sets the current balance of the account.
        /// </summary>
        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }

        /// <summary>
        /// Gets or sets the current account holder.
        /// </summary>
        public Customer AccountHolder
        {
            get
            {
                return this.accountHolder;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Account holder cannot be null!");
                }

                this.accountHolder = value;
            }
        }

        /// <summary>
        /// Gets or sets the interest rate value of this account.
        /// </summary>
        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                if (value < 0)
                {
                    value = (-1) * value;
                    //// no negative interest rates
                }

                this.interestRate = value;
            }
        }

        /// <summary>
        /// Prints information about an account on the default console.
        /// </summary>
        /// <param name="acc">Account to display.</param>
        /// <param name="months">Number of months for interest calculations.</param>
        public static void PrintAccount(Account acc, uint months)
        {
            string type = acc.GetType().ToString();
            Console.WriteLine("Type of account         {0}", type.Substring(type.LastIndexOf('.') + 1));
            Console.WriteLine("Account holder          {0}", acc.AccountHolder.Name);
            Console.WriteLine("Annual interest rate    {0:F} %", acc.InterestRate);
            Console.WriteLine("Current balance         {0:N} BGN", acc.Balance);
            Console.WriteLine("Balance in {0,-2} months    {1:N} BGN", months, acc.AccrueInterest(24));
            Console.WriteLine();
        }

        /// <summary>
        /// Projects interest increments into the future assuming monthly capitalization, interest rate is given as yearly percentage.
        /// </summary>
        /// <param name="months">The number of months.</param>
        /// <returns>Amount after interest at the end of the chosen period.</returns>
        public abstract decimal AccrueInterest(uint months);
    }
}