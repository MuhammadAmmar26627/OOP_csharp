using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment_02v2
{

    // The SavingsAccount class is a derived class from BankAccount. This is Inheritance.
    // Inheritance allows a class to have the properties and methods of another class.
    // SavingsAccount is also implementing the ITransaction interface, so it must provide an implementation for PrintTransaction,ExecuteTransaction.
    public class SavingsAccount : BankAccount, ITransaction
    {
        public float InterestRate { get; set; }
        // This is the constructor for the SavingsAccount class, which calls the base class constructor.
        // The "base" keyword is used to access members in the base class from within the derived class.
        public SavingsAccount(string account_number, string name, float balance, float interestRate) : base(account_number, name, balance)
        {
            InterestRate = interestRate;
        }
        public override double CalculateInterest()
        {
            Console.WriteLine($"Interset is { Balance * InterestRate}");
            return Balance * InterestRate;
        }
        // This method overrides the virtual method from the parent class.
        // This is another example of Polymorphism.
        public override void DisplayAccountInfo()
        {
            Console.WriteLine($"{Name} with account number  {Account_Number} has {Balance} balance.");
        }
        // ExecuteTransaction,PrintTransaction method provides the implementation for the ITransaction interface.
        // This is an example of Polymorphism. At runtime, the appropriate method will be called depending on the actual object type.
        public void ExecuteTransaction(decimal amount) { Console.WriteLine("This is ExecuteTransaction function"); }

        public void PrintTransaction() { Console.WriteLine("This is PrintTransaction function"); }


        public override void Deposit(float amount)
        {
            Transaction transfer = new Transaction($"Amount {amount} Deposit");
            Transections.Add(transfer);
            TransactionTypes["Deposit"].Add(transfer);
            Console.WriteLine($"Amount {amount} Deposited");
            Balance = Balance + (amount * (1 + InterestRate) / 100);
        }
    }
}
