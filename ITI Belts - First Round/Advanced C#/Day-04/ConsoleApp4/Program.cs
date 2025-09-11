namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee { Id = 1, Name = "Alice", Role = "Manager", Salary = 100000 };
            IEmployeeRepository repo = new EmployeeRepository();
            repo.Save(emp);

            IBonusCalculator bonusCalc = new ManagerBonusCalculator();
            Console.WriteLine($"Bonus: {bonusCalc.CalculateBonus(emp)}");

            var printer = new PayslipPrinter();
            printer.Print(emp);

            INotificationService notifier = new EmailNotificationService();
            notifier.SendEmail(emp, "Welcome aboard!");
        }
    }
}
