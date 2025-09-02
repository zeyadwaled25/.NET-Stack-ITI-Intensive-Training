using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class BankAccount
    {
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Balance cannot be negative.");
                }
                balance = value;
            }
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
            Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            Balance -= amount;
        }
    }
}
