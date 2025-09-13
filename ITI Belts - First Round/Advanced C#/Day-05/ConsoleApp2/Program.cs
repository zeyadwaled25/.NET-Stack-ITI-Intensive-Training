namespace ConsoleApp2
{
    public delegate int MathOperation(int a, int b);
    internal class Program
    {
        static int Add(int a, int b) => a + b;
        static int Subtract(int a, int b) => a - b;
        static int Multiply(int a, int b) => a * b;
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int y = int.Parse(Console.ReadLine());

            MathOperation add = Add;
            Console.WriteLine($"Add = {add(x, y)}");

            MathOperation subtract = Subtract;
            Console.WriteLine($"Subtract = {subtract(x, y)}");

            MathOperation multiply = Multiply;
            Console.WriteLine($"Multiply = {multiply(x, y)}");
        }
    }
}
