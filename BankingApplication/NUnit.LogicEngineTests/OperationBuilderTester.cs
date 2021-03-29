namespace NUnit.LogicEngineTests
{
    using NUnit.Framework;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using BankingApplicationLogicEngine;

    /// <summary>
    /// test class to test the operation builder class
    /// </summary>
    [TestFixture]
    public class OperationBuilderTester
    {
        /// <summary>
        /// test to check if function passes given the right
        /// parameters.
        /// </summary>
        [Test]
        public void TestMethodToCheckPassingOfOperationBuilder()
        {
            OperationBuilder operation = new OperationBuilder()
                .SetType("TransactionalOperation")
                .SetPayee("McDonalds")
                .SetAmount(45.513);

            Assert.AreEqual("Purchase at McDonalds", operation.Build().GetOperationLog());
        }
    }
}
