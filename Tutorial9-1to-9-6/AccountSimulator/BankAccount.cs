using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountSimulator
{
    class BankAccount
    {
        //Field
        private decimal _balance;

        //Constractor
        public BankAccount(decimal startingBalance)
        {
            _balance = startingBalance;
        }
        //Balance property (read-only)
        public decimal balance
        {
            get { return _balance; }
        }
        //Deposit method
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }
        //Withdraw method
        public void Withdraw(decimal amount)
        {
            _balance -= amount;
        }
    }
}

