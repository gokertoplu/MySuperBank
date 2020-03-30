using System;
using BankLibrary;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Goker", 40000);
            
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
            account.MakeWithdrawal(30000,DateTime.Now, "Kira Odemesi ");
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} Kira Odemesi.");

            Console.WriteLine(account.GetAccountHistory());
        }
    }
}
