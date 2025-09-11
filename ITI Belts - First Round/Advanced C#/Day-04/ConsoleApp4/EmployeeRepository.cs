using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class EmployeeRepository : IEmployeeRepository // DIP
    {
        private List<Employee> _employees = new List<Employee>();
        public void Save(Employee emp)
        {
            _employees.Add(emp);
            Console.WriteLine("Employee saved.");
        }
    }
}
