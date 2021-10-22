using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BillingAccount : Account
    {
        public BillingAccount(int id, long pesel, string firstname, string lastname) : base (id, firstname, lastname, pesel)
        {
        }
        public void TakeCharge(decimal value)
        {
            Balance -= value;
        }
        public abstract string TypeName()
        {
            return "Rozliczeniowe";
        }
    }
}
