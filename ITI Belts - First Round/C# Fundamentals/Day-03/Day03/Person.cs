using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    public class Person
    {
        private string name;
        private int age;

        // Setter and Getter Methods
        public void SetName(string name)
        {
            if(!string.IsNullOrWhiteSpace(name))
            {
                this.name = name;
            }
            else
            {
                Console.WriteLine("Invalid name. Name cannot be empty.");
            }
        }

        public void SetAge(int age)
        {
            if (age >= 0 && age <= 50)
            {
                this.age = age;
            }
            else
            {
                Console.WriteLine("Invalid age. Age must be between 0 and 50.");
            }
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }


    }
}
