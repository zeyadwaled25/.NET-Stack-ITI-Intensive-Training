using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class SmartPhone : Phone, ICall, ICamera
    {
        public SmartPhone(string serial) : base(serial) { }

        public void MakeCall(string number)
        {
            Console.WriteLine($"SmartPhone is calling {number}...");
        }

        public void TakePhoto()
        {
            Console.WriteLine("SmartPhone took a photo!");
        }
    }
}
