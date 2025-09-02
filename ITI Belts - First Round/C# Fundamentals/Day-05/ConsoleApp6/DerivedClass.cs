using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class DerivedClass : MiddleClass
    {
        //public override void ShowMessage() // cannot override because MiddleClass sealed it
        //{
        //    Console.WriteLine("Hello from DerivedClass");
        //}
    }
}
