using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class SavingAccount : BankAccount
    {
        public SavingAccount(string accountNumber, decimal initialBalance) : base(accountNumber, initialBalance)
        {
        }

        public override void Withdraw(decimal amount)
        {
            if(Balance - amount >= 100)
            {

                Balance -= amount;
                Console.WriteLine($"Withdraw amount {amount}, New Balance{Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds. Minimum balance of 100 must be maintained.");
            }
        }
    }
}
