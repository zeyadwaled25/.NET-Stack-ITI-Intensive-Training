using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{


    //2 + 3i
    //5 + 2i

    public class Complex
    {
        public int Real;
        public int Imag;

        public Complex(int real , int imag) 
        { 
            Real = real;
            Imag = imag;
        }

        public static Complex operator +(Complex c1, Complex c2)
        { 
            return new Complex(c1.Real + c2.Real, c1.Imag + c2.Imag);
        }

        public static Complex operator -(Complex c1, Complex c2)
        { 
            return new Complex(c1.Real - c2.Real, c1.Imag - c2.Imag);
        }

        public void Display()
        {
            Console.WriteLine($"{Real} + {Imag}i");
        }

    }
}
