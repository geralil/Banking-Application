namespace BankingApplicationLogicEngine
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BankingApplicationLogicEngine.BankingEntities;

    /// <summary>
    /// Class to build accounts.
    /// </summary>
    public class AccountBuilder
    {
        // fields that different accounts have.//
        private string type;
        private double currentBalance;
        private double totalAmount;
        private double interestRate;
        private long accountNumber;

        // setters for all the fields.//
        public AccountBuilder SetType(string type) { this.type = type;     return this; }
        public AccountBuilder SetCurrentBalance(double amount) { this.currentBalance = amount;     return this; }
        public AccountBuilder SetTotalBalance(double amount) { this.totalAmount = amount;     return this; }
        public AccountBuilder SetInterestRate(double rate) { this.interestRate = rate;     return this; }
        public AccountBuilder SetAccountNumber(long number) { this.accountNumber = number;     return this; }

        /// <summary>
        /// build function builds an account using the private fields of the class.
        /// passes an account entity back.
        /// </summary>
        /// <returns></returns>
        public IEntity Build()
        {
            Type accountType = Type.GetType("BankingApplicationLogicEngine.BankingEntities." + this.type);
            IEntity entity = (IEntity)Activator.CreateInstance(accountType);
            
            if (entity is CheckingAccount)
            {
                CheckingAccount checkingAccount = entity as CheckingAccount;
                checkingAccount.SetCurrentAmount(this.currentBalance);
                checkingAccount.SetEntityNumber(this.accountNumber);

                entity = checkingAccount;
                return entity;
            }
            else if (entity is SavingsAccount)
            {
                SavingsAccount savingsAccount = entity as SavingsAccount;
                savingsAccount.SetCurrentAmount(this.currentBalance);
                savingsAccount.SetEntityNumber(this.accountNumber);
                savingsAccount.SetInterestRate(this.interestRate);

                entity = savingsAccount;
                return entity;
            }
            else if (entity is LoanAccount)
            {
                LoanAccount loanAccount = entity as LoanAccount;
                loanAccount.SetCurrentAmount(this.currentBalance);
                loanAccount.SetEntityNumber(this.accountNumber);
                loanAccount.SetInterestRate(this.interestRate);
                loanAccount.SetLoanAmount(this.currentBalance);

                entity = loanAccount;
                return entity;
            }
            return null;
        }
    }
}
