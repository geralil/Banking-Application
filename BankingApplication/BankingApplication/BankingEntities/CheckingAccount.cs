using System;
using System.Collections.Generic;
using System.Text;
using BankingApplicationLogicEngine.BankingOperations;

namespace BankingApplicationLogicEngine.BankingEntities
{
    public class CheckingAccount : IAccountEntity
    {
        private double currentBalance;
        private long accountNumber;
        private Stack<IOperation> lastTenOperations;
        private readonly string type;

        public CheckingAccount()
        {
            this.type = "Checking Account";
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

        public Stack<IOperation> GetLastNOperations()
        {
            return this.lastTenOperations;
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

        string IEntity.GetType()
        {
            return this.type;
        }
    }
}
