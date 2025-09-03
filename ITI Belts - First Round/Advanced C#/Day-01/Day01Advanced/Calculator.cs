using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01Advanced
{
    internal class Calculator
    {
        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}

        //public double Add(double a, double b)
        //{
        //    return a + b;
        //}

        //public string Add(string a, string b)
        //{
        //    return a + b;
        //}


        public T Add<T>(T a, T b)
        {
            dynamic x = a;
            dynamic y = b;
            return  x + y;
        }

        //public T Add<T>(T a, T b, T c)
        //{
        //    dynamic x = a;
        //    dynamic y = b;
        //    dynamic z = c;
        //    return x + y + z;
        //}

    }
}
