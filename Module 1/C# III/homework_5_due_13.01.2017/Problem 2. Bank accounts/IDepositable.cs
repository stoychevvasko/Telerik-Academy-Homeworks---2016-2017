////-----------------------------------------------------------------------
//// <copyright file="IDepositable.cs" company="indepentent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
namespace Problem_02
{
    /// <summary>
    /// Exposes the Deposit(decimal value) method related to financial services.
    /// </summary>
    public interface IDepositable
    {
        /// <summary>
        /// Deposits an amount into an account/other financial instrument.
        /// </summary>
        /// <param name="amount">The amount value.</param>
        void Deposit(decimal amount);
    }
}
