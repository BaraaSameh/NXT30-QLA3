namespace NXT_OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.showAccountDetails();

            SavingAccount saving = new SavingAccount()
            {
                _Balance = 1000.0m,
                interestRate = 5.0m
            };
            saving.showAccountDetails();


            CurrentAccount current = new CurrentAccount()
            {
                _Balance = 500.0m,
                overdraftLimit = 200.0m
            };
            current.showAccountDetails();

            List<BankAccount> accounts = new List<BankAccount>
            {
                
                saving,
                current
            };
            foreach (var account in accounts)
            {
                Console.WriteLine(account.ToString());
                Console.WriteLine($"Interest: {account.calculateInterest()}");
                //account.showAccountDetails();
            }





        }
    }
}
