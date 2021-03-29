namespace BankingApplicationLogicEngine
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class user builder that builds a user, given a name.
    /// </summary>
    public class UserBuilder
    {
        private string userName;

        public UserBuilder SetUserName(string userName) { this.userName = userName;     return this; }

        public User Build()
        {
            User newUser = new User(this.userName);

            return newUser;
        }
    }
}
