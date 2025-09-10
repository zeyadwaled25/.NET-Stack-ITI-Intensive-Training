namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
        {
            new Employee { Name = "Zeyad", Salary = 70000, HiringDate = new DateTime(2024, 3, 15) },
            new Employee { Name = "Waled", Salary = 80000, HiringDate = new DateTime(2023, 8, 1) },
            new Employee { Name = "Ebrahim", Salary = 60000, HiringDate = new DateTime(2025, 1, 30) }
        };

            employees.Sort();

            foreach (var e in employees)
            {
                Console.WriteLine($"{e.Name}: {e.Salary}, {e.HiringDate.ToShortDateString()}");
            }
        }
    }
}
