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
        }
    }
}
