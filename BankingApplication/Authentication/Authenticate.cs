using System;
using System.Collections.Generic;

namespace Authentication
{
    public class Authenticate
    {
        private Dictionary<string, string> userNamePasswordPairs;

        public Authenticate()
        {
            this.userNamePasswordPairs = new Dictionary<string, string>();
            this.userNamePasswordPairs.Add("user1", "password");
            this.userNamePasswordPairs.Add("user2", "password");
            this.userNamePasswordPairs.Add("user3", "password");
        }

        public void AddUserNameAndPassword(string userName, string passWord)
        {
            if (this.userNamePasswordPairs.ContainsKey(userName))
            {
                return;
            }
            else
            {
                this.userNamePasswordPairs.Add(userName, passWord);
            }
        }

        public bool AuthenticateLogin(string userName, string passWord)
        {
            if (this.userNamePasswordPairs.ContainsKey(userName))
            {
                if (this.userNamePasswordPairs[userName] == passWord)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
