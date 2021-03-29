using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplicationLogicEngine.BankingOperations
{
    class LoanPaymentOperation : IInterestOperation
    {
        private double capitalPaymentAmount;
        private double interestAmount;
        
        public string GetOperationLog()
        {
            return "Paid interest payment of " + this.interestAmount + " and capital payment of";
        }

        public double GetOperationValue()
        {
            return this.capitalPaymentAmount;
        }

        public void SetAmount(double amount)
        {
            this.capitalPaymentAmount = amount;
        }

        public void SetInterestValue(double interestValue)
        {
            this.interestAmount = interestValue;
        }
    }
}
