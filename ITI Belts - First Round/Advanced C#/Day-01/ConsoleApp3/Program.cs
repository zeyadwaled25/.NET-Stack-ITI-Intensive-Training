    namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] mixedData = { 10, "20", "hello", 30, "40", "world", 50 };

            var numbers = new List<int>();
            var strings = new List<string>();

            foreach (dynamic item in mixedData)
            {
                if (item is string str && int.TryParse(str, out int number))
                {
                    numbers.Add(number);
                }
                else if (item is string)
                {
                    strings.Add(item);
                }
                else if (item is int)
                {
                    numbers.Add(item);
                }
            }

            int totalSum = numbers.Sum();

            Console.WriteLine("Original Data: " + string.Join(", ", mixedData));
            Console.WriteLine("All Strings: " + string.Join(", ", strings));
            Console.WriteLine("All Numbers: " + string.Join(", ", numbers));
            Console.WriteLine("Sum of Numbers: " + totalSum);
        }
    }
}
