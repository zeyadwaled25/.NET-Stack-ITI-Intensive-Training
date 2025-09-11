using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Employee // SRP
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public double Salary { get; set; }
    }
}
