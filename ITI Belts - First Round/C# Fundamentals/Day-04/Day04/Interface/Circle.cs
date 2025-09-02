using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04.Interface
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public void Draw()
        {
            Console.WriteLine("Drawing Circle...");
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
