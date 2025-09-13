namespace ConsoleApp1
{
    public delegate void WelcomeMessage(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage welcome = (string name) => Console.WriteLine($"Welcome, {name}!");
            welcome("Mohamed");
        }
    }
}
