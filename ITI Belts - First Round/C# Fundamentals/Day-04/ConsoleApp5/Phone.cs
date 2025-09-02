using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Phone : Device
    {
        public Phone(string serial) : base(serial) { }

        public void CallFeature()
        {
            Console.WriteLine("Phone basic calling feature.");
        }
    }
}
