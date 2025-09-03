using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01Advanced
{
    internal class Employee
    {
        public string name { get; set; }
        public int? age { get; set; }
        public DateTime? hiringDate { get; set; }

        public Employee(string name , int? age = null , DateTime? hiringDate = null)
        {
            this.name = name;
            this.age = age;
            this.hiringDate = hiringDate;
        }
    }
}
