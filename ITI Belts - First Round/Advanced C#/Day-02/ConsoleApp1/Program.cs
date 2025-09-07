namespace ConsoleApp1
{
    internal class Program
    {
        static void CheckEmployeeRole(Employee emp)
        {
            if (emp is Manager)
                Console.WriteLine($"{emp.Name} (Manager): Approve Budget & Conduct Meetings");
            else if (emp is Admin)
                Console.WriteLine($"{emp.Name} (Admin): Manage Users & Handle Permissions");
            else if (emp is Staff)
                Console.WriteLine($"{emp.Name} (Staff): Perform Daily Tasks");
            else
                Console.WriteLine("Unknown Role");
        }
        static void Main(string[] args)
        {
            Employee[] employees = {
                new Manager("Zeyad", 10000),
                new Admin("Waled", 8000),
                new Staff("Ebrahim", 5000),
            };

            foreach (var emp in employees)
            {
                CheckEmployeeRole(emp);
            }
        }
    }
}
