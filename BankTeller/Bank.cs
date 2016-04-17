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
        public static void BankMenu(Client client, Account clientAccount)
        {
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
                        break;
                    case "C":
                        clientAccount.DepositFunds();
                        break;
                    case "D":
                        clientAccount.WithdrawFunds();
                        break;
                    case "E":
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        break;
                }

            } while (choice != "E");
            AccountHistory(clientAccount, client);
        }

        static void AccountHistory(Account clientAccount, Client client)
        {
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
