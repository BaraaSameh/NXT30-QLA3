using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NXT_OOP1
{
    internal class Bank
    {

        private const String _Bannk_Code = "BNK001";

        private readonly DateTime date=DateTime.Now ;

        private int _accountNumber;

        string _fullName;
        string _nationalId;
        string _phoneNumber;    
        string _address;
        public double _Balance;



        //--------------------------------

        void  setfullName(string fullName)
        { 
            if (string.IsNullOrEmpty(fullName))
            {
                throw new ArgumentException("Full name cannot be null or empty.");
            }
            _fullName = fullName;
        }
        void setnationalId(string nationalId)
        {
            //if (nationalId =null && nationalId.Length=14)
            //{
            //    throw new ArgumentException("National ID must be a positive number.");
            //}
            _nationalId = nationalId;
        }
        //void phoneNumber(int phoneNumber)
        //{
        //    if (phoneNumber <= 0 && phoneNumber > 11)
        //    {
        //        throw new ArgumentException("Phone number must be a positive number.");
        //    }
        //    _phoneNumber = phoneNumber;
        //}

        public  void SetPhoneNumber(string phoneNumber)
        {
            if (phoneNumber == null || phoneNumber.Length != 11 || !phoneNumber.StartsWith("01"))
            {
                throw new ArgumentException("Phone number must be 11 digits and start with '01'.");
            }

            _phoneNumber = phoneNumber;
            //Console.WriteLine(phoneNumber);
        }

        void setaddress(string address)
        {
            if (string.IsNullOrEmpty(address))
            {
                throw new ArgumentException("Address cannot be null or empty.");
            }
            _address = address;
        }

     public  void setbalance(double Balance)
        {
            if (Balance < 0)
            {
                throw new ArgumentException("Balance cannot be negative.");
            }
            _Balance = Balance;
        }

        /// ------------------------------------------------

        public Bank()
        {
            Console.WriteLine("Default constructor");
        }
        public Bank(int accountNumber, string fullName, string nationalId, string phoneNumber, string address, double balance): this(accountNumber,fullName,nationalId,phoneNumber,address)
        {
            //Console.WriteLine("parametized const");
            //_accountNumber = accountNumber;
            //setfullName(fullName);
            //setnationalId(nationalId);
            //SetPhoneNumber(phoneNumber);
            //setaddress(address);
            _Balance = balance;
            
        }

        public Bank(int accountNumber, string fullName, string nationalId, string phoneNumber, string address) 
        {
            Console.WriteLine(" oveloaded const");
            _accountNumber = accountNumber;
            setfullName(fullName);
            setnationalId(nationalId);
            SetPhoneNumber(phoneNumber);
            setaddress(address);
            //_balance = 0.0;


            Console.WriteLine($"{accountNumber},{fullName},{nationalId},{phoneNumber},{address},{_Balance}");



            //-----------------------------------

           
        }

        public void show_account_info()
        {
            Console.WriteLine($"Account Number: {_accountNumber}");
            Console.WriteLine($"Full Name: {_fullName}");
            Console.WriteLine($"National ID: {_nationalId}");
            Console.WriteLine($"Phone Number: {_phoneNumber}");
            Console.WriteLine($"Address: {_address}");
            Console.WriteLine($"Balance: {_Balance}");
            Console.WriteLine($"Bank Code: {_Bannk_Code}");
            Console.WriteLine($"Date: {date.ToShortDateString()}");
        }
        //-------------------------------------------
        public bool nationalId_is_valid(string nationalId)
        {
            return !string.IsNullOrEmpty(nationalId) &&
                   nationalId.Length == 14 &&
                   nationalId.All(char.IsDigit);
        }

        //-------------------------------------------

        public bool IsValidPhoneNumber(int phone)
        {
            return _phoneNumber != null &&
                   _phoneNumber.StartsWith("01") &&
                   _phoneNumber.Length == 11;
            //Console.WriteLine(phone.ToString());
                   
        }

    }
}
