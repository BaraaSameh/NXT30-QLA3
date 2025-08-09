using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXT_OOP2
{
    internal class CurrentAccount:BankAccount
    {
       public decimal overdraftLimit;

        public override decimal calculateInterest()
        {

            return 0;

        }
        public override void showAccountDetails()
        {
            Console.WriteLine("current account class");
        }
    }
}
