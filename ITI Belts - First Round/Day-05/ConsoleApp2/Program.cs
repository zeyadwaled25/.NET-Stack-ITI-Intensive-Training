namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Manager("Ahmed", 10000);
            Employee emp2 = new Developer("Sara", 8000);

            Console.WriteLine($"{emp1.Name} bonus: {emp1.CalculateBonus()}");
            Console.WriteLine($"{emp2.Name} bonus: {emp2.CalculateBonus()}");
        }
    }
}
