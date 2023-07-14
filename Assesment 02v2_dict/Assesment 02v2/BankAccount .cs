using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment_02v2
{
    // Declaring an abstract class BankAccount. This is a form of abstraction in OOP.
    // Abstraction allows complex real-world concepts to be represented in a simplified manner in a program.
    // BankAccount class represents general characteristics of all BankAccounts.
    // BankAccount is also implementing the IBankAccount interface, so it must provide an implementation for Deposit,Withdraw.
    public abstract class BankAccount : IBankAccount
    {
        // Properties are an example of encapsulation where you can have data validation inside getters and setters 
        // Here, however, we are using auto-implemented properties with default getters and setters.

        // The Guid data type is used to generate a unique identifier (ID) for each BankAccount object.
        public string Account_Number { get; set; }
        public string Name { get; set; }
        public float Balance { get; set; }
        public float InterestRate { get; set; }
        public List<Transaction> Transections ;
        public Dictionary<string, List<Transaction>> TransactionTypes { get; set; }
        // This is a constructor method for the BankAccount class, encapsulating the creation of an BankAccount.
        // Encapsulation protects the data from outside interference and misuse.
        public BankAccount(string account_number, string name, float balance)
        {
            Account_Number = account_number;
            Name = name;
            Balance = balance;
            float InterestRate = 0;
            Transections =new List<Transaction>();
            Transaction transfer = new Transaction($"Amount {balance} Added as initial balance");
            Transections.Add(transfer);
            TransactionTypes = new Dictionary<string, List<Transaction>>();
            
            TransactionTypes.Add("Deposit", Transections);
            //TransactionTypes["Deposit"].Add(transfer);
        }
        public virtual double CalculateInterest() {
            Console.WriteLine($"Interset is { Balance * InterestRate}");
            return Balance * InterestRate; }
        // This is a void method, use to print all the .
        public void Transaction_History()
        {
            foreach(Transaction i in Transections)
            {
                //Console.WriteLine(i);
                i.view();
            }
        }
        // This is a virtual method, allowing for the method to be overridden in subclasses.
        // This is another form of Polymorphism. The code will call the appropriate method depending on the actual object type at runtime.
        public virtual void Deposit(float amount)
        {
            Transaction transfer = new Transaction($"Amount {amount} Deposit");
            Transections.Add(transfer);
            TransactionTypes["Deposit"].Add(transfer);

            Balance += amount;
            Console.WriteLine($"Amount {amount} Deposited");
        }
        // This is a virtual method, allowing for the method to be overridden in subclasses.
        // This is another form of Polymorphism. The code will call the appropriate method depending on the actual object type at runtime.
        public virtual void Withdraw(float amount)
        {
            Transaction transfer = new Transaction($"Amount {amount} Withdraw");
            Transections.Add(transfer);
            TransactionTypes["Withdraw"].Add(transfer);
            Balance -= amount;
            Console.WriteLine($"Amount {amount} Withdraw");
        }
        // Declaring an abstract method DisplayAccountInfo in Abstract class. This is a form of abstraction in OOP.
        // Abstraction class should have atleast one Abstraction method
        // Abstraction allows complex real-world concepts to be represented in a simplified manner in a program.
        // This method should be implemented in child classes
        public abstract void DisplayAccountInfo();
    }
}
