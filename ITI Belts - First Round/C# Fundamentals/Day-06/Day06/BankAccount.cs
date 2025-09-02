using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal abstract class BankAccount
    {
        public string AccountNumber;
        public decimal Balance;
        public BankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public abstract void Withdraw(decimal amount);

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposit amount {amount} ,New Balance {Balance}");
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Balance : {Balance}");
        }
    }
}
