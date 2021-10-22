using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class SavingsAccount : Account
    {
    public SavingsAccount(int id, long pesel, string firstname, string lastname) : base (id, firstname, lastname, pesel)
        {
        }
        

        public void SetInterest(decimal interest)
        {
            Balance += Balance * interest;
        }
        public abstract string TypeName()
        {
            return "Oszczędnościowe";
        }
    }
}
