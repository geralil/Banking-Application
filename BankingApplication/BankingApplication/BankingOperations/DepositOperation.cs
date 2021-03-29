using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplicationLogicEngine.BankingOperations
{
    class DepositOperation : IPurchaseOperation
    {
        private double transferAmount;
        private string payor;

        public string GetOperationLog()
        {
            return "Deposited money from " + this.payor;
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
            this.payor = payee;
        }
    }
}
