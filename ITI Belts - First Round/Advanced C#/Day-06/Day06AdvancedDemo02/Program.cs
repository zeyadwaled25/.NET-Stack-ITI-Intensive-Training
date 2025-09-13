namespace Day06AdvancedDemo02
{
    internal class Program
    {
        static  async Task SimpleDelayAsync()
        {
            Console.WriteLine("Start waiting ...");
            await Task.Delay(3000);
            Console.WriteLine("Finished waiting.");
        }

        static async Task<int> GetRandomNumber()
        {
            Console.WriteLine("Generating Numner...");
            await Task.Delay(2000);

            int num = new Random().Next(1,101);

            Console.WriteLine("Number generated");

            return num;
        }

        static async Task SequenceStepsAsync()
        {
            Console.WriteLine("Step 1 ");
            await Task.Delay(1000);

            Console.WriteLine("Step 1 Done");

            Console.WriteLine("Step 2 ");
            await Task.Delay(1000);
            Console.WriteLine("Step 2 Done"); 

            Console.WriteLine("Step 3 ");
            await Task.Delay(1000);
            Console.WriteLine("Step 3 Done");

        }

        static async Task<int> MultiplyNumbersAsync(int a , int b)
        {
            await Task.Delay(4000);

            return a * b;
        }
        
        static void Main(string[] args)
        {
            //SimpleDelayAsync().Wait();

            //int result = GetRandomNumber().Result;

            //Console.WriteLine($"Result number {result}");

            //SequenceStepsAsync().Wait();

            int mul = MultiplyNumbersAsync(5,5).Result;

            Console.WriteLine(mul);

        }
    }
}
