using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }
        
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y);
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return v1.X == v2.X && v1.Y == v2.Y;
        }
        public static bool operator !=(Vector v1, Vector v2)
        {
            return v1.X != v2.X && v1.Y != v2.Y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
}
