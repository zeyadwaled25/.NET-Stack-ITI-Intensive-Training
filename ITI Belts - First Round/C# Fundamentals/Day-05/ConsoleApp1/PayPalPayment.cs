using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PayPalPayment : Payment
    {
        public string Email { get; set; }
        public PayPalPayment(double amount, string currency, string email) : base(amount, currency)
        {
            Email = email;
        }
        public override void ProcessPayment()
        {
            Console.WriteLine($"Processing PayPal payment of {Amount} in currency {Currency} using email {Email}");
        }
    }
}
