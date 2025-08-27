using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.Interface
{
    public interface IPrinter
    {
        public void Print()
        {
            Console.WriteLine("document print..");
        }
    }
}
