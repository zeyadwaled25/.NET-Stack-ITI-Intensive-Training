namespace ConsoleApp1
{
    internal class Program
    {
        public record Product(int Id, string Name, double Price);

        static void Main(string[] args)
        {
            //Task 1 Sum of Natural Numbers (Recursion)
            int SumNumbers(int n)
            {
                if (n <= 1) return n;
                return n + SumNumbers(n - 1);
            }

            Console.WriteLine($"Sum of numbers from 1 to 10 = {SumNumbers(10)}");

            //Task 2 Product of Natural Numbers (Recursion)
            int ProductNumbers(int n)
            {
                if (n <= 1) return 1;
                return n * ProductNumbers(n - 1);
            }

            Console.WriteLine($"Product of numbers from 1 to 5 = {ProductNumbers(5)}");

            //Task 3 Optional & Named Parameters – Product Order
            void ProductOrder(string productName, int quantity = 1, string customer = "Guest", bool expressDelivery = false)
            {
                Console.WriteLine($"Product: {productName} | Quantity: {quantity} | Customer: {customer} | Express Delivery: {expressDelivery}");
            }

            ProductOrder("Laptop");
            ProductOrder("Keyboard", 5);
            ProductOrder(productName: "Monitor", customer: "Alice", expressDelivery: true, quantity: 2);

            //Task 4 Discounted Order
            void DiscountedOrder(string productName, int quantity = 1, string customer = "Guest", bool expressDelivery = false, double discount = 0)
            {
                double pricePerProduct = 100;
                double total = quantity * pricePerProduct;
                if (discount > 0)
                {
                    double discountedTotal = total * (1 - discount);
                    Console.WriteLine($"Product: {productName} | Quantity: {quantity} | Customer: {customer} | Express Delivery: {expressDelivery} | Discount: {discount * 100}% | Total Price: {discountedTotal:C}");
                }
                else
                {
                    Console.WriteLine($"Product: {productName} | Quantity: {quantity} | Customer: {customer} | Express Delivery: {expressDelivery}");
                }
            }

            DiscountedOrder("Tablet", 2, "Bob", true, 0.1);

            //Task 5 Extension Method – Reverse String
            string message = "hello";
            Console.WriteLine(message.ReverseText());

            //Task 6 Extension Method – Character Count
            string message1 = "Hello";
            Console.WriteLine(message1.CountCharacters());

            //Task 7 Extension Method – IsEven
            int x = 8;
            Console.WriteLine(x.IsEven());

            //Task 8 Extension Method – IsPrime
            int y = 7;
            Console.WriteLine(y.IsPrime());

            //Task 9 Records
            Product p1 = new Product(1, "Laptop", 1500);
            Product p2 = new Product(1, "Laptop", 1500);
            Console.WriteLine(p1 == p2);

            //Task 10 Record with Deconstruction
            var p3 = new Product(1, "Laptop", 1500);
            var (id, name, price) = p3;
            Console.WriteLine($"Id: {id}, Name: {name}, Price: {price}");
        }
    }
}
