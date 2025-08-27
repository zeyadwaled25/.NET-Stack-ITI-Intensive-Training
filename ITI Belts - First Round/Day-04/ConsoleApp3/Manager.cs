using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Manager : Employee
    {
        public Manager(string name, double salary) : base(name, salary)
        {
        }

        public void ManageTeam()
        {
            Console.WriteLine($"{Name} is managing with a salary of {Salary}");
        }
    }
}
