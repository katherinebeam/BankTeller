using System;
using System.Text;

namespace BankTeller
{
    class Client
    {
        //Fields
        private string name = "Katherine Beam";
        private string accountNumber;

        //Properties
        public string AccountNumber { get { return accountNumber; } set { accountNumber = GenerateAccountNumber(); } }
        public string Name { get { return name; } set { name = value; } }

        //Methods
        public void ViewClientInfo()
        {
            Console.WriteLine("Name: " + Name + "\nAccount Number: " + AccountNumber);
        }

        private string GenerateAccountNumber()
        {
            Random random = new Random();
            StringBuilder account = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                account.Append(Convert.ToString(random.Next(10)));
            }
            string accountNumber = Convert.ToString(account);
            return accountNumber;
        }

        //Constructors
        public Client()
        {
            AccountNumber = GenerateAccountNumber();
        }

        public Client(string name)
        {
            Name = name;
            AccountNumber = GenerateAccountNumber();
        }
    }
}