using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.Interface
{
    public class Square : IShape
    {
        public double Side { get; set; }

        public Square(double side)
        {
            Side = side;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing Square...");
        }

        public double GetArea()
        {
            return Side * Side;
        }

        public double GetPerimeter()
        {
            return 4 * Side;
        }
    }
}
