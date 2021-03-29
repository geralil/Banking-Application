﻿using System;
using System.Collections.Generic;
using System.Text;
using BankingApplicationLogicEngine.BankingOperations;
using InterestValueCalculation;

namespace BankingApplicationLogicEngine.BankingEntities
{
    public class LoanAccount : IAccountEntity, IInterestEntity, ILoanEntity
    {
        private long accountNumber;
        private double interestRate;
        private double currentBalance;
        private double totalAmount;
        private Stack<IOperation> lastTenOperations;
        private readonly string type;
        private double interestValue;

        public LoanAccount()
        {
            this.type = "Loan Account";
            this.lastTenOperations = new Stack<IOperation>(10);
        }
        
        public double GetCurrentAmount()
        {
            return this.currentBalance;
        }

        public long GetEntityNumber()
        {
            return this.accountNumber;
        }

        public double GetInterestRate()
        {
            return this.interestRate;
        }

        public Stack<IOperation> GetLastNOperations()
        {
            return this.lastTenOperations;
        }

        public double GetLoanAmount()
        {
            return this.totalAmount;
        }

        public void PushOperation(IOperation operation)
        {
            this.lastTenOperations.Push(operation);
        }

        public void SetCurrentAmount(double amount)
        {
            this.currentBalance = amount;
        }

        public void SetEntityNumber(long number)
        {
            this.accountNumber = number;
        }

        public void SetInterestRate(double interestRate)
        {
            this.interestRate = interestRate;
            this.interestValue = InterestCalculator.CalculateInterestValue(this.interestRate, this.currentBalance);
        }

        public void SetLoanAmount(double totalAmount)
        {
            this.totalAmount = totalAmount;
        }

        string IEntity.GetType()
        {
            return this.type;
        }

        public double GetInterestValue()
        {
            return this.interestValue;
        }
    }
}
