using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BankTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            Account clientAccount = new Account();
            Bank.BankMenu(client, clientAccount);
        }
   }
}

