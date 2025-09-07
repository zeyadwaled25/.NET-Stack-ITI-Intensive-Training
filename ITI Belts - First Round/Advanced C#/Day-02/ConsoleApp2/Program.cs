namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 15, 20 };

            void Calculate()
            {
                int GetSum()
                {
                    int sum = 0;
                    foreach (var num in numbers)
                        sum += num;
                    return sum;
                }
                int sum = GetSum();
                double avg = (double)sum / numbers.Length;

                Console.WriteLine($"Sum = {sum}");
                Console.WriteLine($"Average = {avg}");
            }
            Calculate();
        }
    }
}
