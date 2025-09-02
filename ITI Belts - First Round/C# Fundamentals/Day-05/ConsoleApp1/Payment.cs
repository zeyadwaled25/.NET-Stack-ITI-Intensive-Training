using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Payment
    {
        public double Amount { get; set; }
        public string Currency { get; set; }

        public Payment(double amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        public virtual void ProcessPayment()
        {
            Console.WriteLine($"Processing payment of {Amount} in currency {Currency}");
        }
    }
}
