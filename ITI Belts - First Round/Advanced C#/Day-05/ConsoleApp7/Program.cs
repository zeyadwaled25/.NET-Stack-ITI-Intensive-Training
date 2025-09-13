namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> add = (a, b) => a + b;
            Func<double, double, double> average = (a, b) => (a + b) / 2;

            double a = 4.5, b = 7.5;

            Console.WriteLine($"Add = {add(a, b)}");
            Console.WriteLine($"Average = {average(a, b)}");
        }
    }
}
