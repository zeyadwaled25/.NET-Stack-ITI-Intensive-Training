using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    public class Animal
    {
       
        public virtual void Speak()
        {
            Console.WriteLine($"Animal Speaking");
        }
    }

    public class Dog : Animal
    {
        
        public override void Speak()
        {
            Console.WriteLine("Dog Barking");
        }
    }

    public class Bird : Animal
    {

        public override void Speak()
        {
            Console.WriteLine("Bird Chirping");
        }
    }
}
