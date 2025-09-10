namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter second number: ");
            string input2 = Console.ReadLine();

            try
            {
                double num1 = double.Parse(input1);
                double num2 = double.Parse(input2);
                double result = num1 / num2;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input.");
            }
            finally
            {
                Console.WriteLine("Program finished.");
            }

        }
    }
}
