using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upcasting.Entities
{
    internal class Account
    {

        public int Number { get; set; }
        public string Holder { get; set; }

        public Double Balance { get; set; }

        public Account() { 
        
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void WithDraw(double amount)
        {
            Balance -= amount;
            Balance -= 5;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
