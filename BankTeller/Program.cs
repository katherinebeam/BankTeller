using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankTeller
{
    class Bank
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Account clientAccount = new Account();
            string choice = "";
            do
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("BANK OF CORAL GABLES");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Which would you like to do?\n\t(a) View Client Information\n\t(b) View Account Balance\n\t(c) Deposit Funds\n\t(d) Withdraw Funds\n\t(e) Exit");
                Console.WriteLine("------------------------------------");
                choice = Console.ReadLine().ToUpper();
                switch (choice)
                {
                    case "A":
                        client.ViewClientInfo();
                        break;
                    case "B":
                        clientAccount.ViewAccountBalance();
                        Console.WriteLine(clientAccount.Balance);
                        break;
                    case "C":
                        Console.WriteLine("Enter amount to deposit:");
                        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                        clientAccount.DepositFunds(depositAmount);
                        break;
                    case "D":
                        if (clientAccount.Balance <= 0)
                        {
                            Console.WriteLine("You cannot make a withdrawal because your balance is $0.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Enter amount to withdraw:");
                            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                            if (clientAccount.Balance >= withdrawAmount)
                            {
                                clientAccount.WithdrawFunds(withdrawAmount);
                            }
                            else
                            {
                                Console.WriteLine("Your balance is not high enough for you to withdraw that amount.");
                            }
                            break;
                        }
                    case "E":
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        break;
                }

            } while (choice != "E");
            string fileName = "AccountSummary.txt";
            StreamWriter writer = new StreamWriter(fileName);
            using (writer)
            {
                writer.WriteLine("------------------------------------");
                writer.WriteLine("BANK OF CORAL GABLES");
                writer.WriteLine("------------------------------------");
                writer.WriteLine("NAME: " + client.Name);
                writer.WriteLine("ACCOUNT NUMBER: " + client.AccountNumber);
                writer.WriteLine("-----------------------------------------------");
                writer.WriteLine("DATE/TIME\t\t+/-\tAMOUNT\tBALANCE");
                writer.WriteLine("-----------------------------------------------");
                foreach (string transaction in clientAccount.AllTransactions)
                {
                    writer.WriteLine(transaction);
                }
            }
        }
   }
}

