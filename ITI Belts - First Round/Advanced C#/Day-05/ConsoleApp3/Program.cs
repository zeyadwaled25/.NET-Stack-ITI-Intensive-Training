namespace ConsoleApp3
{
    public delegate double DiscountCalculator(double price);
    internal class Program
    {
        static double TenPercentOff(double price) => price - (0.10 * price);
        static double FiftyOff(double price) => price - 50;

        static void ShowFinalPrice(double price, DiscountCalculator dc)
        {
            Console.WriteLine($"Original Price: {price}");
            double finalPrice = dc(price);
            Console.WriteLine($"Final Price: {finalPrice}");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            ShowFinalPrice(200, TenPercentOff);
            ShowFinalPrice(200, FiftyOff);
        }
    }
}
