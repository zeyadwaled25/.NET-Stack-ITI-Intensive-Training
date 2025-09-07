namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>
            {
                "Ali", "Sara", "Mona", "Abdullah", "Mohammed"
            };
            students.Add("Laila");
            students.Add("Omar");
            students.Add("Ali");

            students.Remove("Mona");

            Console.WriteLine("All Students:");
            foreach (var s in students)
                Console.Write(s + ", ");
            Console.WriteLine();

            Console.WriteLine("\nNames starting with 'A':");
            foreach (var s in students.Where(x => x.StartsWith("A")))
                Console.Write(s + ", ");
        }
    }
}
