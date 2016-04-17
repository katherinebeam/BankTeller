using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTeller
{
    class Account
    {
        //Fields
        private decimal balance;
        private List<string> allTransactions = new List<string>();

        //Properties
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public List<string> AllTransactions
        {
            get { return allTransactions; }
            set { allTransactions = value; }
        }

        //Methods
        public decimal DepositFunds()
        {
            Console.WriteLine("Enter amount to deposit:");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            this.Balance += depositAmount;
            Console.WriteLine("Your current balance now = $" + this.Balance);
            string time = Convert.ToString(DateTime.Now);
            this.AllTransactions.Add(time + "\t +\t$" + depositAmount + "\t$" + this.Balance);
            return this.Balance;
        }

        public decimal WithdrawFunds()
        {
            if (this.Balance <= 0)
            {
                Console.WriteLine("You cannot make a withdrawal because your balance is $0.");
            }
            else
            {
                Console.WriteLine("Enter amount to withdraw:");
                decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                if (this.Balance >= withdrawAmount)
                {
                    this.Balance -= withdrawAmount;
                    Console.WriteLine("Your current balance now = $" + this.Balance);
                    string time = Convert.ToString(DateTime.Now);
                    this.AllTransactions.Add(time + "\t -\t$" + withdrawAmount + "\t$" + this.Balance);
                }
                else
                {
                    Console.WriteLine("Your balance is not high enough for you to withdraw that amount.");
                }
            }
            return this.Balance;
        }

        public void ViewAccountBalance()
        {
            Console.WriteLine("Your current balance: $" + this.Balance);
        }

        //Constructor
        public Account()
        {
            this.Balance = 0.00M;
        }
    }
}
