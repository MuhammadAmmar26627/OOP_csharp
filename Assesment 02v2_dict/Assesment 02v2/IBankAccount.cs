using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment_02v2
{
    // Declaring an interface IBankAccount. This is an example of Polymorphism.
    // Polymorphism allows objects of different classes to be treated as objects of a common superclass or interface.
    // Here, any class that implements IBankAccount can be used wherever IBankAccount is expected.
    public interface IBankAccount
    {
        void Deposit(float amount);
        void Withdraw(float amount);
    }
}
