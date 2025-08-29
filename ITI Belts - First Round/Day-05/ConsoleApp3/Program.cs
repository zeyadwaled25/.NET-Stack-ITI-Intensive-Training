namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            Console.WriteLine($"Sum of 2 integers: {calc.Add(5, 10)}");
            Console.WriteLine($"Sum of 2 doubles: {calc.Add(3.5, 6.5)}");
            Console.WriteLine($"Sum of 3 integers: {calc.Add(1, 2, 3)}");
        }
    }
}
