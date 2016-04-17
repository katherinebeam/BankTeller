using System;
using System.Collections.Generic;

namespace BankTeller
{
    class Account
    {
        //Fields
        private decimal balance;
        private List<string> allTransactions = new List<string>();

        //Properties
        public decimal Balance { get { return balance; } set { balance = value; } }
        public List<string> AllTransactions { get { return allTransactions; } set { allTransactions = value; } }

        //Methods
        public void DepositFunds()
        {
            Console.WriteLine("Enter amount to deposit:");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            Balance += depositAmount;
            Console.WriteLine("Your current balance now = $" + Balance);
            string time = Convert.ToString(DateTime.Now);
            AllTransactions.Add(time + "\t +\t$" + depositAmount + "\t$" + Balance);
        }

        public void WithdrawFunds()
        {
            if (Balance <= 0)
            {
                Console.WriteLine("You cannot make a withdrawal because your balance is $0.");
            }
            else
            {
                Console.WriteLine("Enter amount to withdraw:");
                decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                if (Balance >= withdrawAmount)
                {
                    Balance -= withdrawAmount;
                    Console.WriteLine("Your current balance now = $" + Balance);
                    string time = Convert.ToString(DateTime.Now);
                    AllTransactions.Add(time + "\t -\t$" + withdrawAmount + "\t$" + Balance);
                }
                else
                {
                    Console.WriteLine("Your balance is not high enough for you to withdraw that amount.");
                }
            }
        }

        public void ViewAccountBalance()
        {
            Console.WriteLine("Your current balance: $" + Balance);
        }

        //Constructor
        public Account()
        {
            Balance = 0.00M;
        }
    }
}