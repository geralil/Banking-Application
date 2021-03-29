namespace NUnit.LogicEngineTests
{
    // NUnit 3 tests
    // See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
    using System.Collections;
    using System.Collections.Generic;
    using NUnit.Framework;
    using BankingApplicationLogicEngine;
    using BankingApplicationLogicEngine.BankingEntities;

    /// <summary>
    /// class to test the implementation of account builder.
    /// </summary>
    [TestFixture]
    public class AccountBuilderTester
    {
        /// <summary>
        /// test methods checks to see if account builder passes successfully
        /// given the correct parameters.
        /// </summary>
        [Test]
        public void TestMethodToCheckIfAccountBuilderPasses()
        {
            AccountBuilder accountBuilder = new AccountBuilder()
                .SetAccountNumber(111111234)
                .SetCurrentBalance(10000)
                .SetTotalBalance(2000000)
                .SetInterestRate(15)
                .SetType("LoanAccount");
            Assert.IsTrue(accountBuilder.Build() is ILoanEntity);

            accountBuilder = new AccountBuilder()
                .SetType("SavingsAccount")
                .SetCurrentBalance(10000)
                .SetInterestRate(14);
            Assert.IsTrue(accountBuilder.Build() is IInterestEntity);
        }
    }
}
