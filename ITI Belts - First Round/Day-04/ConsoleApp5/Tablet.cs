using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Tablet : Device
    {
        public Tablet(string serial) : base(serial) { }

        public void Browse()
        {
            Console.WriteLine("Tablet is browsing the internet.");
        }
    }
}
