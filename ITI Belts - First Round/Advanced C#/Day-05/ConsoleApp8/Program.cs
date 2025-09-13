namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> startsWithA = s => s.StartsWith("A");

            string[] items = { "Apple", "Banana", "Avocado", "Mango" };
            foreach (string item in items)
            {
                if (startsWithA(item))
                    Console.WriteLine(item);
            }
        }
    }
}
