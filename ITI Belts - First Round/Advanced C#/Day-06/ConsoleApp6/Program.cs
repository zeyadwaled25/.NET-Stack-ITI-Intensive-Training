namespace ConsoleApp6
{
    internal class Program
    {
        static async Task ReadFileAsync()
        {
            await Task.Delay(2000);
            Console.WriteLine("File read complete");
        }

        static async Task AnalyzeFileAsync()
        {
            await Task.Delay(1000);
            Console.WriteLine("File analysis complete");
        }

        static void Main()
        {
            var readTask = ReadFileAsync();
            var analyzeTask = AnalyzeFileAsync();
            readTask.Wait();
            analyzeTask.Wait();
        }
    }
}
