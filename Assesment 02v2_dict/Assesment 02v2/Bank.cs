using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment_02v2
{
    // The Bank class represents a collection of BankAccount objects, an example of Aggregation.
    // Aggregation is a type of Association where the aggregate (Zoo) can exist independently of the parts (Habitats).
    public class Bank
    {
        // The BankAccounts property is a List<BankAccount>, a collection of different BankAccounts present in the BankAccounts
        public List<BankAccount> BankAccounts { get; set; }
        // The Dict_BankAccounts property is a Dictionary<string,BankAccount>, a collection of different BankAccounts numbers and BankAccounts as key value pair present in the BankAccounts
        public Dictionary<string, BankAccount> Dict_BankAccounts { get; set; }

        public Bank()
        {
            BankAccounts = new List<BankAccount>();
            Dict_BankAccounts = new Dictionary<string, BankAccount>();
        }
        // A Method to add bank account in bank
        public void AddAccount(BankAccount accunt)
        {
            Dict_BankAccounts[accunt.Account_Number] = accunt;
            BankAccounts.Add(accunt);
            Console.WriteLine($"{accunt.Name} with {accunt.Account_Number} has been added to the zoo.");
        }
        // A methoid to deposit amount to all bankaccount
        public void DepositToAccount(int amount)
        {
            foreach (var accunt in BankAccounts)
            {
                accunt.Deposit(amount);
            }
        }
        // A methoid to Withdraw amount to all bankaccount
        public void WithdrawFromAccount(int amount)
        {
            foreach (var accunt in BankAccounts)
            {
                accunt.Deposit(amount);
            }
        }
    }
}
