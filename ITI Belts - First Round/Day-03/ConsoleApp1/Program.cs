namespace ConsoleApp1
{
    internal class Program
    {
        enum Pizaa
        {
            small = 1,
            medium,
            large
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Select Pizza Size:");
            Console.WriteLine("1) small");
            Console.WriteLine("2) medium");
            Console.WriteLine("2) large");
            int choice = int.Parse(Console.ReadLine());
            Pizaa choicePizza = (Pizaa)choice;

            if (choicePizza == Pizaa.small)
            {
                Console.WriteLine("You selected: Small Pizza.");
                Console.WriteLine("Price: $6.");
            }
            else if (choicePizza == Pizaa.medium)
            {
                Console.WriteLine("You selected: Medium Pizza.");
                Console.WriteLine("Price: $12.");
            }
            else if (choicePizza == Pizaa.large)
            {
                Console.WriteLine("You selected: Large Pizza.");
                Console.WriteLine("Price: $20.");
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
    }
    }
}
