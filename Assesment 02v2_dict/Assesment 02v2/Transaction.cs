using System;
using System.Collections.Generic;
using System.Text;

namespace Assesment_02v2
{
    public class Transaction
    {
        public String Transection_;
        public Transaction(string transection)
        {
            Transection_ = transection;
        }
        public void view()
        {
            Console.WriteLine(Transection_);
        }
    }
}
