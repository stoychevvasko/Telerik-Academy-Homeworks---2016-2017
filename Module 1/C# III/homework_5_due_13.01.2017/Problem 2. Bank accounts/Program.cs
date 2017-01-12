////-----------------------------------------------------------------------
//// <copyright file="Program.cs" company="independent developer">
////     Copyright (c) Vassil Stoychev 2017. All rights reserved.
//// </copyright>
////-----------------------------------------------------------------------
//// 
//// Problem 2. Bank accounts
//// 
//// * A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
//// Customers could be individuals or companies.
//// 
//// * All accounts have customer, balance and interest rate (monthly based).
////     * Deposit accounts are allowed to deposit and with draw money.
////     * Loan and mortgage accounts can only deposit money.
//// 
//// * All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated 
//// as follows: number_of_months* interest_rate.
//// 
//// * Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held 
//// by a company.
//// 
//// * Deposit accounts have no interest if their balance is positive and less than 1000.
//// 
//// * Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//// 
//// * Your task is to write a program to model the bank system by classes and interfaces.
//// 
//// * You should identify the classes, interfaces, base classes and abstract actions and implement the calculation 
//// of the interest functionality through overridden methods.
//// 
namespace Problem_02
{
    using System;

    /// <summary>
    /// Program execution starts here.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main exe.
        /// </summary>
        public static void Main()
        {
            Individual ind1 = new Individual("Ivan Ivanov");
            Individual ind2 = new Individual("Petar Petrov");
            Company comp1 = new Company("Company Ltd.");
            Company comp2 = new Company("Corporation Inc.");

            Account[] arrayOfAccounts = new Account[]
            {
                new MortgageAccount(ind1, 2000M, 10M),
                new MortgageAccount(comp1, 2000M, 10M),

                new LoanAccount(ind1, 3000M, 5M),
                new LoanAccount(comp1, 3000M, 5M),

                new DepositAccount(ind2, 750M, 7M),
                new DepositAccount(comp2, 5000M, 7M),
                new DepositAccount(comp1, -15000M, 7M),
            };

            foreach (var acc in arrayOfAccounts)
            {
                Account.PrintAccount(acc, 13);
            }

            Console.WriteLine();
        }
    }
}
