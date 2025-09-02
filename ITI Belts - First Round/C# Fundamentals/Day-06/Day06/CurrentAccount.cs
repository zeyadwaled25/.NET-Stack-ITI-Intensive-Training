using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class CurrentAccount : BankAccount
    {
        public CurrentAccount(string accountNumber, decimal initialBalance) : base(accountNumber, initialBalance)
        {
        }

        public override void Withdraw(decimal amount)
        {
            if(Balance - amount >= 0)
            {
                Balance -= amount;
                Console.WriteLine($"Withdraw amount {amount}, New Balance{Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
    }
}
