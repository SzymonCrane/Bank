using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class SavingsAccount : Account
    {

    public int Id { get; set; }
    public long AccountNumber { get; set; }
    public long Pesel { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
        public static SetInterest()
        {
            return Interest;
        }
    }
}
