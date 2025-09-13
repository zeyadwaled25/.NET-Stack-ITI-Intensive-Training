namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string, int> printMultiple = (msg, count) =>
            {
                for (int i = 0; i < count; i++)
                    Console.WriteLine(msg);
            };

            printMultiple("Hello", 3);
        }
    }
}
