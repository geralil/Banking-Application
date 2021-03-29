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
    /// test class to check implementation of user builder class.
    /// </summary>
    [TestFixture]
    public class UserBuilderTester
    {
        /// <summary>
        /// test function to check if method passes successfully
        /// given right parameters.
        /// </summary>
        [Test]
        public void TestMethod()
        {
            UserBuilder userBuilder = new UserBuilder()
                .SetUserName("user1");
            Assert.IsInstanceOf(typeof(User), userBuilder.Build());
        }
    }
}
