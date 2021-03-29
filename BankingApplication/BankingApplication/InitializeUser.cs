namespace BankingApplicationLogicEngine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class that initializes a user with accounts.
    /// account numbers, current balances and interest rates are generated
    /// randomnly.
    /// </summary>
    public static class InitializeUser
    {
        /// <summary>
        /// function to initialize checking account.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static User InitializeUserWithCheckingAccount(User user)
        {
            var rand = new Random();
            AccountBuilder accountBuilder = new AccountBuilder()
    .SetAccountNumber(rand.Next(1242434))
    .SetCurrentBalance(rand.NextDouble() * 400000)
    .SetType("CheckingAccount");

            user.AddNewAccount(accountBuilder);
            return user;
        }

        /// <summary>
        /// function to initialize loan account.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static User InitializeUserWithLoanAccount(User user)
        {
            var rand = new Random();
            double loanAmount = rand.NextDouble() * 400000;
            AccountBuilder accountBuilder = new AccountBuilder()
    .SetType("LoanAccount")
    .SetAccountNumber(rand.Next(112324312))
    .SetTotalBalance(loanAmount)
    .SetInterestRate(rand.Next(15))
    .SetCurrentBalance(rand.NextDouble() * 30000);
                        
            user.AddNewAccount(accountBuilder);
            return user;
        }

        /// <summary>
        /// function to initialize savings account.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static User InitializeUserWithSavingsAccount(User user)
        {
            var rand = new Random();
            AccountBuilder accountBuilder = new AccountBuilder()
    .SetType("SavingsAccount")
    .SetAccountNumber(rand.Next(12334232))
    .SetInterestRate(rand.Next(15))
    .SetCurrentBalance(rand.NextDouble() * 30000);

            user.AddNewAccount(accountBuilder);
            return user;
        }
    }
}
