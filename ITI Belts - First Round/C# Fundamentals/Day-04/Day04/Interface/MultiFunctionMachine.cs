using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.Interface
{
    public class MultiFunctionMachine : IPrinter, IScanner
    {
        public void Print() { }

        public void Scan()
        {
            Console.WriteLine("document scan..");
        }
    }
}
