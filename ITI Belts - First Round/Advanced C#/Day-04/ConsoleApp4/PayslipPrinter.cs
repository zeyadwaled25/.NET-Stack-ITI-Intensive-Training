using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class PayslipPrinter // SRP
    {
        public void Print(Employee emp)
        {
            Console.WriteLine($"Employee: {emp.Name}, Role: {emp.Role}, Salary: {emp.Salary}");
        }
    }
}
