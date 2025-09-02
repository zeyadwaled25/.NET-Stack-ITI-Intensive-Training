using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal abstract class Person
    {
        private string name;
        private int age;


        public string Name
        {
            get { return name; }
            set {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                name = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }

                age = value;
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void DisplayInfo();


    }
}
