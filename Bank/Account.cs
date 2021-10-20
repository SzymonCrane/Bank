using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class Account
    {
        public int Id { get; set; }
        public long AccountNumber { get; set; }
        public long Balance { get; set; }
        public long Pesel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Account(int id, long accountnumber, long balance, long pesel, string firstname, string lastname)
    {
            Id = id;
            AccountNumber = accountnumber;
            Balance = balance;
            Pesel = pesel;
            FirstName = firstname;
            LastName = lastname;

    }
        public void Printer()
        {
            
        }
    }
}
