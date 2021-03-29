using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplicationLogicEngine.BankingOperations
{
    class TransactionalOperation : IPurchaseOperation
    {
        private string payee;
        private double transactionAmount;
        
        public string GetOperationLog()
        {
            return "Purchase at " + this.payee;
        }

        public double GetOperationValue()
        {
            return this.transactionAmount;
        }

        public void SetAmount(double amount)
        {
            this.transactionAmount = amount;
        }

        public void SetPayee(string payee)
        {
            this.payee = payee;
        }
    }
}
