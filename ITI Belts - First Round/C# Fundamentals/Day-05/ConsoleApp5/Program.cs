namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(3, 4);
            Vector v2 = new Vector(1, 2);

            Console.WriteLine($"v1: {v1}");
            Console.WriteLine($"v2: {v2}");
            Console.WriteLine($"v1 + v2: {v1 + v2}");
            Console.WriteLine($"v1 - v2: {v1 - v2}");
            Console.WriteLine($"v1 == v2: {v1 == v2}");
            Console.WriteLine($"v1 != v2: {v1 != v2}");
        }
    }
}
