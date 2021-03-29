namespace BankingApplicationLogicEngine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class that represents the whole of the banking application.
    /// contains dictionary of users in the system.
    /// </summary>
    public class BankingApplication
    {
        /// <summary>
        /// dictionary of users with username as key.
        /// </summary>
        private Dictionary<string, User> bankUsers;

        /// <summary>
        /// constructor for class that creates 3 users with usernames:
        /// user1, user2, user3.
        /// creates accounts for all users.
        /// </summary>
        public BankingApplication()
        {
            this.bankUsers = new Dictionary<string, User>();

            // adding user 1, with 1 checking account and 1 loan account.//
            this.bankUsers.Add("user1", new UserBuilder().SetUserName("user1").Build());

            this.bankUsers["user1"] = InitializeUser.InitializeUserWithCheckingAccount(this.bankUsers["user1"]);
            this.bankUsers["user1"] = InitializeUser.InitializeUserWithLoanAccount(this.bankUsers["user1"]);

            // adding user 2, with 1 savings account and 1 checking account.//
            this.bankUsers.Add("user2", new UserBuilder().SetUserName("user2").Build());

            this.bankUsers["user2"] = InitializeUser.InitializeUserWithCheckingAccount(this.bankUsers["user2"]);
            this.bankUsers["user2"] = InitializeUser.InitializeUserWithSavingsAccount(this.bankUsers["user2"]);

            // adding user 3, with 1 savings, loan and checking account.//
            this.bankUsers.Add("user3", new UserBuilder().SetUserName("user3").Build());

            this.bankUsers["user3"] = InitializeUser.InitializeUserWithCheckingAccount(this.bankUsers["user3"]);
            this.bankUsers["user3"] = InitializeUser.InitializeUserWithSavingsAccount(this.bankUsers["user3"]);
            this.bankUsers["user3"] = InitializeUser.InitializeUserWithLoanAccount(this.bankUsers["user3"]);

        }

        /// <summary>
        /// returns a user from the dictionary
        /// based on username.
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public User GetUser(string userName)
        {
            return this.bankUsers[userName];
        }

        /// <summary>
        /// function to transfer funds from one account to another.
        /// </summary>
        /// <param name="fromUser"> sender.</param>
        /// <param name="toUser"> receiver</param>
        /// <param name="fromType"> sender account type</param>
        /// <param name="toType"> receiver account type</param>
        /// <param name="amount"> transfer amount</param>
        public void TransferFundsBetweenAccounts(string fromUser, string toUser, string fromType, string toType, double amount)
        {
            TransferFunds transferFunds = new TransferFunds(ref this.bankUsers)
                .SetFromAccountType(fromType)
                .SetToAccountType(toType)
                .SetFromUser(fromUser)
                .SetToUser(toUser)
                .SetTransferAmount(amount);

            transferFunds.TransferAmount();
        }
    }
}
