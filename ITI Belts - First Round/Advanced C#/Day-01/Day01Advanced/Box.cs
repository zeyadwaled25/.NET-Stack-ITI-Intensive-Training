using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01Advanced
{
    internal class Box<T>
    {
        public T Value;

        public Box(T value)
        {
            Value = value;
        }

        public void Show()
        {
            Console.WriteLine($"Box contains : {Value}");
        }
    }
}
