using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    public class MyClass
    {
        public static int counter;

        public readonly int Number;

        public MyClass(int number)
        {
            counter++;
            Number = number;
        }
    }
}
