using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment_02v2
{
    public class CheckingAccount : BankAccount, ITransaction
    {

        public CheckingAccount(string account_number, string name, float balance) : base(account_number, name, balance)

        { }
        public void ExecuteTransaction(decimal amount) { Console.WriteLine("This is ExecuteTransaction function"); }

        public void PrintTransaction() { Console.WriteLine("This is PrintTransaction function"); }
        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"{Name} with account number  {Account_Number} has {Balance} balance.");
        }

        public override double CalculateInterest()
        {
            Console.WriteLine($"Interset is { Balance * InterestRate}");
            return Balance * InterestRate;
        }
        public override void Withdraw(float amount)
        {
            if (Balance < amount)
            {
                Console.WriteLine("Error your Balance is low");
            }
            else
            {
                if (TransactionTypes.ContainsKey("Withdraw"))
                {

                    Transaction transfer = new Transaction($"Amount {amount} Withdraw");
                    Transections.Add(transfer);
                    TransactionTypes["Withdraw"].Add(transfer);
                    Console.WriteLine($"Amount {amount} Withdraw");
                    Balance -= amount;
                }
                else
                {
                     
                    Transaction transfer = new Transaction($"Amount {amount} Withdraw");
                    Transections.Add(transfer);
                    TransactionTypes["Withdraw"].Add(transfer);
                    Console.WriteLine($"Amount {amount} Withdraw");
                    Balance -= amount;
                }

            }
        }
    }
}
