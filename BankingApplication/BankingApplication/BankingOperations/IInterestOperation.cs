using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplicationLogicEngine.BankingOperations
{
    public interface IInterestOperation : IOperation
    {
        void SetInterestValue(double interestValue);
    }
}
