////-----------------------------------------------------------------------
//// <copyright file="MortgageAccount.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_02
{
    /// <summary>
    /// Represents a mortgage account.
    /// </summary>
    public class MortgageAccount : Account, IDepositable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MortgageAccount"/> class.
        /// </summary>
        /// <param name="holder">Account holder.</param>
        /// <param name="balance">Starting balance.</param>
        /// <param name="interestRate">Interest rate percentage.</param>
        public MortgageAccount(Customer holder, decimal balance, decimal interestRate)
            : base(holder, balance, interestRate)
        {
        }

        /// <summary>
        /// Deposits a specific amount to of this bank account.
        /// </summary>
        /// <param name="amount">The amount to deposit.</param>
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new System.ArgumentException("Cannot deposit non-positive amounts!");
            }

            this.Balance += amount;
        }

        /// <summary>
        /// Projects interest increments into the future assuming monthly capitalization, interest rate is given as yearly percentage.
        /// </summary>
        /// <param name="months">The number of months.</param>
        /// <returns>Amount after interest at the end of the chosen period.</returns>
        public override decimal AccrueInterest(uint months)
        {
            decimal result = this.Balance;

            string fullType = this.AccountHolder.GetType().ToString();
            string type = fullType.Substring(fullType.LastIndexOf('.') + 1);

            if (type.CompareTo("Individual") == 0)
            {
                for (int i = 6; i < months; i++)
                {
                    result *= 1 + (this.InterestRate / 100M / 12M);
                }

                return result;
            }
            else if (type.CompareTo("Company") == 0)
            {
                if (months <= 12)
                {
                    for (int i = 0; i < months; i++)
                    {
                        result *= 1 + (this.InterestRate / 2M / 100M / 12M);
                    }

                    return result;
                }
                else
                {
                    for (int i = 0; i < 12; i++)
                    {
                        result *= 1 + (this.InterestRate / 2M / 100M / 12M);
                    }

                    for (int j = 12; j < months; j++)
                    {
                        result *= 1 + (this.InterestRate / 100M / 12M);
                    }

                    return result;
                }
            }
            else
            {
                return result;
            }
        }
    }
}