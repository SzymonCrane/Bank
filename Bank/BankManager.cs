using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankManager
    {
        public static string Run(int decision)
        {
            switch(decision)
            {
                case 1:
                    Console.WriteLine("There's list of your accounts: ");
                    break;

                case 2:
                    Console.WriteLine("I'm going to your billing account...");
                    break;
                
                case 3:
                    Console.WriteLine("I'm going to your saving account...");
                    break;

                case 4:
                    Console.WriteLine("Money has been added to your account!");
                    break;

                case 5:
                    Console.WriteLine("Money taken, you are left with: ");
                    break;

                case 6:
                    return "List of all clients: ";
                    break;

                case 7:
                    return "List of all accounts: ";
                    break;

                case 8:
                    Console.WriteLine("I'm closing the month...");

                    break;

                case 9:
                    Console.WriteLine("Thank you for using my app!");
                    break;
            }
        }
    }
}
