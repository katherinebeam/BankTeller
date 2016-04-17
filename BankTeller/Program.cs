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