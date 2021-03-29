using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplicationLogicEngine.BankingEntities
{
    public interface IInterestEntity : IEntity
    {
        double GetInterestRate();
        void SetInterestRate(double interestRate);
        double GetInterestValue();
    }
}
