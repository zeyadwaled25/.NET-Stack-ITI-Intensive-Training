namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> countries = new Dictionary<string, string>
            {
                { "EG", "Egypt" },
                { "US", "United States" },
                { "UK", "United Kingdom" }
            };

            Console.Write("Enter country code (EG, US, UK): ");
            string code = Console.ReadLine().ToUpper();

            if (countries.ContainsKey(code))
                Console.WriteLine($"Country: {countries[code]}");
            else
                Console.WriteLine("Code Not Found");
        }
    }
}
