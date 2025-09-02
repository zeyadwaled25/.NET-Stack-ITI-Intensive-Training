using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Circle : Shape, IMovable, IResizables
    {
        public void Move(int x, int y)
        {
            Console.WriteLine($"Moving circle to ({x}, {y})");
        }
        public void Resize(double factor)
        {
            Console.WriteLine($"Resizing circle by a factor of {factor}");
        }
    }
}
