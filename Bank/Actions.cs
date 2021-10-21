using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public static class Actions
    {
        public static string GetFullName(string ClientFirstName, string ClientLastName)
        {
            var fullName = string.Format("{0} {1}", ClientFirstName, ClientLastName);
            return ;
        }
        public static long GetBalance()
        {
            var balance = string.Format("{0}PLN", Balance);
            return balance
        }
        public static long GenerateAccountNumber(int Id)
        {
            var accountNumber = Id;
            return accountNumber;
        }
    }
}
