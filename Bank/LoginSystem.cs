using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Bank
{
    public class LoginSystem 
    {
        public string UserName { get; set; }
        public string UserPassword { get; set; }

        public bool LoginIsCorrect(string username, string userpassword)
        {

            var usernames = new string[] { "admin", "hello" };
            var passwords = new string[] { "admin", "hello" };

            var userIndex = Array.IndexOf(usernames, username);
            var passwordIndex = Array.IndexOf(passwords, userpassword);

            if (usernames.Contains(username) && passwords.Contains(userpassword) && userIndex == passwordIndex)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
