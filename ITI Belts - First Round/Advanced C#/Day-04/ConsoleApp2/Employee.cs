using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Employee : IComparable<Employee>
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime HiringDate { get; set; }

        //compereto using year then month then day
        public int CompareTo(Employee other)
        {
            int yearCompare = this.HiringDate.Year.CompareTo(other.HiringDate.Year);
            if (yearCompare != 0)
                return yearCompare;

            int monthCompare = this.HiringDate.Month.CompareTo(other.HiringDate.Month);
            if (monthCompare != 0)
                return monthCompare;

            return this.HiringDate.Day.CompareTo(other.HiringDate.Day);
        }
    }
}
