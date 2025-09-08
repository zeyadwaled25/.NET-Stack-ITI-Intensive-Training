namespace ConsoleApp5
{
    internal class Program
    {
        static void ModifyArray(int[] arr)
        {
            arr[0] = 100;
            arr = new int[] { 9, 9, 9 };
        }

        static void Main()
        {
            int[] arr = { 1, 2, 3 };

            Console.WriteLine("Before:");
            Console.WriteLine(string.Join(", ", arr));

            ModifyArray(arr);

            Console.WriteLine("After:");
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
