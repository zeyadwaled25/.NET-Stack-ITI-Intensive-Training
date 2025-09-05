namespace ConsoleApp2
{
    internal class Program
    {
        static void UpdatePrice(ref Product product, double newPrice)
        {
            product.Price = newPrice;
        }
        static void Main(string[] args)
        {
            var p1 = new Product { Name = "Laptop", Price = 1200 };
            var p2 = new Product { Name = "Phone", Price = 800 };
            var p3 = new Product { Name = "Tablet", Price = 500 };
            var boxes = new List<Box<Product>> // List of Box<Product>
            {
                new Box<Product>(p1),
                new Box<Product>(p2),
                new Box<Product>(p3)
            };

            foreach (var box in boxes)
                box.ShowInfo();

            Console.WriteLine($"\n* Update price of product 2 from {p2.Price} to 950\n");
            UpdatePrice(ref p2, 950);
            foreach (var box in boxes)
                box.ShowInfo();
        }
    }
}
