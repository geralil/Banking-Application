namespace BankingApplicationLogicEngine
{
    using System;
    using BankingApplicationLogicEngine.BankingEntities;
    using System.Collections.Generic;

    /// <summary>
    /// class user that encapsulates the different accounts that a user holds
    /// and the different methods to manipulate those.
    /// </summary>
    public class User
    {
        /// <summary>
        /// dictionary of user accounts.
        /// </summary>
        private Dictionary<long, IEntity> userAccounts;

        /// <summary>
        /// username of user.
        /// </summary>
        private string userName;

        public User(string name)
        {
            this.userName = name;
            this.userAccounts = new Dictionary<long, IEntity>();
        }

        /// <summary>
        /// function to add new account to user.
        /// </summary>
        /// <param name="accountBuilder"></param>
        public void AddNewAccount(AccountBuilder accountBuilder)
        {
            IEntity newEntity = accountBuilder.Build();

            OperationGenerator.GenerateOperations(newEntity);
            this.userAccounts.Add(newEntity.GetEntityNumber(), newEntity);
        }

        /// <summary>
        /// function check status that returns the account object
        /// of the account that has been queried.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public IEntity CheckStatus(string type)
        {
            foreach (var entity in this.userAccounts)
            {
                if (entity.Value.GetType() == type)
                {
                    return entity.Value;
                }
                else
                {
                    continue;
                }
            }
            return null;
        }

        /// <summary>
        /// function to check if given account type exists for user.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public bool CheckAccountTypeExists(string type)
        {
            foreach (var entity in this.userAccounts)
            {
                if (entity.Value.GetType() == type)
                {
                    return true;
                }
                else
                {
                    continue;
                }
            }
            return false;
        }
    }
}
