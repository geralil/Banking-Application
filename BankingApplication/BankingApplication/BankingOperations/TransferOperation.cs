using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplicationLogicEngine.BankingOperations
{
    class TransferOperation : IPurchaseOperation
    {
        private double transferAmount;
        private string payee;

        public string GetOperationLog()
        {
            return "Transferred money to " + this.payee;
        }

        public double GetOperationValue()
        {
            return this.transferAmount;
        }

        public void SetAmount(double amount)
        {
            this.transferAmount = amount;
        }

        public void SetPayee(string payee)
        {
            this.payee = payee;
        }
    }
}
