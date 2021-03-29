using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplicationLogicEngine.BankingOperations
{
    public interface IPurchaseOperation : IOperation
    {
        void SetPayee(string payee);
    }
}
