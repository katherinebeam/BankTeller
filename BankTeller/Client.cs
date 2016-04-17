using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTeller
{
    class Client
    {
        //Fields
        private string accountNumber;
        private string name = "Katherine Beam";

        //Properties
        public string AccountNumber {
            get { return accountNumber; }
            set { accountNumber = GenerateAccountNumber(); }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Methods
        public void ViewClientInfo()
        {
            Console.WriteLine("Name: " + this.Name + "\nAccount Number: " + this.AccountNumber);
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
            this.AccountNumber = GenerateAccountNumber();
        }

        public Client(string name)
        {
            this.Name = name;
            this.AccountNumber = GenerateAccountNumber();
        }
    }
}
