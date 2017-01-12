////-----------------------------------------------------------------------
//// <copyright file="DepositAccount.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_02
{
    /// <summary>
    /// Represents a deposit bank account.
    /// </summary>
    public class DepositAccount : Account, IDepositable, IWithdrawable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositAccount"/> class.
        /// </summary>
        /// <param name="holder">Account holder.</param>
        /// <param name="balance">Starting balance.</param>
        /// <param name="interestRate">Interest rate percentage.</param>
        public DepositAccount(Customer holder, decimal balance, decimal interestRate)
            : base(holder, balance, interestRate)
        {
        }

        /// <summary>
        /// Deposits a specific amount out of this bank account.
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
        /// Withdraws a specific amount out of this bank account.
        /// </summary>
        /// <param name="amount">The amount to withdraw.</param>
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new System.ArgumentException("Cannot withdraw non-positive amounts!");
            }

            this.Balance -= amount;
        }

        /// <summary>
        /// Projects interest increments into the future assuming monthly capitalization, interest rate is given as yearly percentage.
        /// </summary>
        /// <param name="months">The number of months.</param>
        /// <returns>Amount after interest at the end of the chosen period.</returns>
        public override decimal AccrueInterest(uint months)
        {
            decimal result = this.Balance;

            //// Deposit accounts have no interest if their balance is  
            //// positive and less than 1000. 

            if (this.Balance > 0M && this.Balance <= 1000M)
            {
                return this.Balance;
            }

            for (int i = 0; i < months; i++)
            {
                result *= 1 + (this.InterestRate / 100M / 12M);
            }

            return result;
        }
    }
}
