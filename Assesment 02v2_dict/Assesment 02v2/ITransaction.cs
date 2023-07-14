using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment_02v2
{
    public interface ITransaction
    {
        // Declaring an interface ITransaction. This is an example of Polymorphism.
        // Polymorphism allows objects of different classes to be treated as objects of a common superclass or interface.
        // Here, any class that implements ITransaction can be used wherever ITransaction is expected.
        void ExecuteTransaction(decimal amount);
        void PrintTransaction();
    }
}
