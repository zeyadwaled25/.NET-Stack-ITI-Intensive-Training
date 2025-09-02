using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    internal class SmartPhone : Device
    {
        public sealed override void Work()
        {
            Console.WriteLine("SmartPhone Working");
        }
    }

}
