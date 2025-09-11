namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var logger = new FileLogger("log.txt"))
            {
                logger.LogMessage("First message");
                logger.LogMessage("Second message");
                logger.LogMessage("Third message");
            }
        }
    }
}
