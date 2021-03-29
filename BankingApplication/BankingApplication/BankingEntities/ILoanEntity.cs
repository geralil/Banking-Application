using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplicationLogicEngine.BankingEntities
{
    public interface ILoanEntity : IEntity
    {
        double GetLoanAmount();
        void SetLoanAmount(double totalAmount);
    }
}
