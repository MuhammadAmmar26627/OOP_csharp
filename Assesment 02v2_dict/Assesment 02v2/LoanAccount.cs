using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment_02v2
{
    public class LoanAccount : BankAccount, ITransaction
    {
        public LoanAccount(string account_number, string name, float balance, float interestRate) : base(account_number, name, balance) { }
        public override double CalculateInterest()
        {
            Console.WriteLine($"Interset is { Balance * InterestRate}");
            return Balance * InterestRate;
        }
        public void ExecuteTransaction(decimal amount) { Console.WriteLine("This is ExecuteTransaction function"); }

        public void PrintTransaction() { Console.WriteLine("This is PrintTransaction function"); }
        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"{Name} with account number  {Account_Number} has {Balance} balance.");
        }
    }
}
