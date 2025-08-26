using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    public struct Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double DistanceTo(Point other)
        {
            int dx = x - other.x;
            int dy = y - other.y;

            return Math.Sqrt(dx * dx + dy * dy);


        }
    }
}
