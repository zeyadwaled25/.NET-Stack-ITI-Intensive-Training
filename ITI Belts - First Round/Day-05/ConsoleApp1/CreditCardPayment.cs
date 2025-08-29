using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CreditCardPayment : Payment
    {
        public string CardNumber { get; set; }

        public CreditCardPayment(double amount, string currency, string cardNumber) : base(amount, currency)
        {
            CardNumber = cardNumber;
        }

        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing credit card payment of {Amount} in currency {Currency} using card number {CardNumber}");
        }
    }
}
