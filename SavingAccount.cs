using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NXT_OOP2
{
    internal class SavingAccount : BankAccount
    {
       public decimal interestRate;
        public override decimal calculateInterest()
        {

            return _Balance * interestRate / 100;

        }
        
        public SavingAccount()
        {

        }
        public SavingAccount(decimal initialBalance, decimal interestRate)
        {
            _Balance = initialBalance;
            this.interestRate = interestRate;

        }
        public override void showAccountDetails()
        {
            Console.WriteLine("saving account class");
        }
        public override string ToString()
        {
            return $"Saving Account - Balance: {_Balance}, Interest Rate: {interestRate}%";
        }
    }
}
