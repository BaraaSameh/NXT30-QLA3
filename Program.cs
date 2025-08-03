using System.Threading.Channels;

namespace NXT_OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example usage of the Bank class
            Bank bank = new Bank();
            bank.SetPhoneNumber("01234567890");
            Bank bank2 = new Bank(1,"baraa","303052142112","01007198527","banha");

            Bank bank3 = new Bank(2, "ahmed", "303052142112", "01007198528", "ban");
          

            Console.WriteLine("-------------------------------------------------------------------");
            bank2.show_account_info();
            Console.WriteLine("-----------------------------------------------------");

            //bank.nationalId_is_valid("30305211402954");

            bank2 .IsValidPhoneNumber(01007198527);
        }
    }
}
