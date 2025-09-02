using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Device
    {
        public readonly string SerialNumber;

        public Device(string serial)
        {
            SerialNumber = serial;
        }

        public void TurnOn()
        {
            Console.WriteLine($"Device {SerialNumber} is now ON.");
        }
    }
}
