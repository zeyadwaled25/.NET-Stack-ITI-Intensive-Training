namespace ConsoleApp5
{
    internal class Program
    {
        static async Task BrewCoffeeAsync()
        {
            await Task.Delay(3000);
            Console.WriteLine("Coffee is ready!");
        }

        static async Task Main()
        {
            await BrewCoffeeAsync();
        }
    }
}
