using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public class Employee
    {
        public int Id;
        public string Name;


        public Employee(int id , string name)
        {
            Id = id;
            Name = name;

        }

        public static bool operator ==(Employee e1 , Employee e2)
        {
            return e1.Id == e2.Id && e1.Name == e2.Name;
        }


        public static bool operator !=(Employee e1, Employee e2)
        {
            return e1.Id != e2.Id || e1.Name != e2.Name;
        }


        public void Display()
        {
            Console.WriteLine($"Id : {Id} , Name : {Name}");
        }


    }
}
