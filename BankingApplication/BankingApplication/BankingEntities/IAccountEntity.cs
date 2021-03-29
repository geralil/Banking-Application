using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplicationLogicEngine.BankingEntities
{
    public interface IAccountEntity : IEntity
    {
        double GetCurrentAmount();
        void SetCurrentAmount(double amount);
    }
}
