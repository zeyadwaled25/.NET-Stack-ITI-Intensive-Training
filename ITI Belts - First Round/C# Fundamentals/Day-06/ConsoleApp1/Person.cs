using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Person
    {
        // Fields (Encapsulation)
        private int id;
        private string fullName;
        private int age;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string FullName { get; set; } // Auto-property
        public int Age
        {
            get { return age; }
            set 
            { 
                if (value < 0)
                    throw new ArgumentException("Age cannot be negative.");
                age = value; 
            }
        }

        public abstract void DisplayInfo();
    }
}
