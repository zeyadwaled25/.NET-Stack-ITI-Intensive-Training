using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Manager : Employee
    {
        public Manager(string name, double salary) : base(name, salary) {}
        public override double CalculateBonus()
        {
            double bonus = Salary * 0.15;
            return bonus;
        }
    }
}
