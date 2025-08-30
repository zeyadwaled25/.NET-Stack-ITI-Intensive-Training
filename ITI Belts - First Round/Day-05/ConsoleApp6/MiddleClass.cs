using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class MiddleClass : BaseClass
    {
        public sealed override void ShowMessage()
        {
            Console.WriteLine("Hello from MiddleClass (sealed)");
        }
    }
}
