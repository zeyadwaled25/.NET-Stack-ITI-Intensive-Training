using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    public class Product
    {
        private string productName;
        private double price;

        //Full Property
        public string ProductName
        {
            get { return productName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    productName = value;
                }
                else
                {
                    Console.WriteLine("Invalid product name. It cannot be empty.");
                }
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    Console.WriteLine("Invalid price. Price cannot be negative.");
                }
            }
        }
    }
}
