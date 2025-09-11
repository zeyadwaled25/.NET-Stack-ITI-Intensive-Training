using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05Advanced
{
    internal class Calculator
    {
        public static void Perform(Operation op, int a, int b)
        {
           int result = op(a, b);
            Console.WriteLine($"Result = {result}");
        }
    }
}
