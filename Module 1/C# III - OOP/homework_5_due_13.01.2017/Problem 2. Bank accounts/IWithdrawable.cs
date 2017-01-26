////-----------------------------------------------------------------------
//// <copyright file="IWithdrawable.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_02
{
    /// <summary>
    /// Exposes the Withdraw(decimal value) method related to financial services.
    /// </summary>
    public interface IWithdrawable
    {
        /// <summary>
        /// Withdraws an amount from an account/other financial instrument.
        /// </summary>
        /// <param name="amount">The amount value.</param>
        void Withdraw(decimal amount);
    }
}
