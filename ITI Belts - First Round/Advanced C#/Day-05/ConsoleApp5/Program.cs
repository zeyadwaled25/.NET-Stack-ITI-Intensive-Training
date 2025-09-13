namespace ConsoleApp5
{
    public delegate bool NumberCheck(int number);
    internal class Program
    {
        static void Main(string[] args)
        {
            NumberCheck isPositive = n => n > 0;

            int[] testNumbers = { -1, 0, 1 };
            foreach (var num in testNumbers)
            {
                Console.WriteLine($"{num} is Positive? {isPositive(num)}");
            }
        }
    }
}
