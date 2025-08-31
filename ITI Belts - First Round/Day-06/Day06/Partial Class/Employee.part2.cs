using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06.Partial_Class
{
    internal partial class Employee
    {
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}
