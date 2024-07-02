using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Final
{
    public class BankAccount
    {
        private decimal _balance;

        public BankAccount()
        {
            _balance = 0;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive");
            }
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount > _balance || amount <= 0)
            {
                throw new ArgumentException("Insufficient funds");
            }
            Console.WriteLine("Done");
            _balance -= amount;
        }

        public decimal GetBalance()
        {
            return _balance;
        }
    }
}
