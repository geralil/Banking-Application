using System;
using System.Collections.Generic;
using System.Text;
using BankingApplicationLogicEngine.BankingOperations;

namespace BankingApplicationLogicEngine.BankingEntities
{
    public interface IEntity
    {
        string GetType();
        long GetEntityNumber();
        void SetEntityNumber(long number);
        Stack<IOperation> GetLastNOperations();
        void PushOperation(IOperation operation);
    }
}
