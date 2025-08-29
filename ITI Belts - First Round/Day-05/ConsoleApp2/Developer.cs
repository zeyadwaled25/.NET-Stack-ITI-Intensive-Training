using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Developer : Employee
    {
        public Developer(string name, double salary) : base(name, salary) { }
        public override double CalculateBonus()
        {
            double bonus = Salary * 0.10;
            return bonus;
        }
    }
}
