using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Employee : Person
    {
        public double Salary { get; set; }
        public Employee(string name, double salary) : base(name)
        {
            Salary = salary;
        }
    }
}
