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
            return ClientFirstName + ClientLastName ;
        }
        public static long GetBalance(long oldBalance,long changeBalance)
        {
            return oldBalance + changeBalance;
        }
        public static long GenerateAccountNumber(int Id)
        {
            var accountNumber = Id;
            return accountNumber;
        }
    }
}
