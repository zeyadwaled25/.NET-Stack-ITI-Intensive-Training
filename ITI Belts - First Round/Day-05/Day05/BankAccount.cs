using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public class BankAccount
    {
        public string Owner;
        public decimal Balance;

        public BankAccount(string owner, decimal balance)
        {
            Owner = owner;
            Balance = balance;
        }

        public static BankAccount operator --(BankAccount acc)
        {
            acc.Balance -= 100;  // Balance = Balance - 100
            return acc;
        }
        public static BankAccount operator ++(BankAccount acc)
        {
            acc.Balance += 500;   // Balance = Balance + 500
            return acc;
        }

        public void Display()
        {
            Console.WriteLine($"Owner : {Owner} , Balance : {Balance}");
        }
    }
}
