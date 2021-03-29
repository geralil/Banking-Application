using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplicationLogicEngine.BankingOperations
{
    public interface IOperation
    {
        string GetOperationLog();
        double GetOperationValue();
        void SetAmount(double amount);
    }
}
