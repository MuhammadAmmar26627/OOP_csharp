using Assesment_02v2;
using System;
using System.Collections.Generic;

namespace Assessment_02v2
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount a0 = new CheckingAccount("03152512525", "abc", 600);
            SavingsAccount a1 = new SavingsAccount("03152512525", "abc", 60, 98);
            a1.DisplayAccountInfo();
            a0.Withdraw(123);
            a0.Transaction_History();
            a0.DisplayAccountInfo();
            Console.WriteLine(a0.TransactionTypes);
        }
    }
}
