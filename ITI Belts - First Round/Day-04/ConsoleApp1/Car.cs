using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        public static int TotalCars = 0;
        public readonly int ChassisNumber;

        public string Model { get; set; }
        public double Price { get; set; }

        public Car(string model, double price, int chassisNumber)
        {
            Model = model;
            Price = price;
            ChassisNumber = chassisNumber;
            TotalCars++;
        }

        public void DisplayCar()
        {
            Console.WriteLine($"Chassis: {ChassisNumber}, Model: {Model}, Price: {Price}");
        }
    }
}
