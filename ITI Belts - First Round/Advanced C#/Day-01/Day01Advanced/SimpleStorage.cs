using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01Advanced
{
    internal class SimpleStorage<T>
    {
        private T[] data;
        private int index = 0;


        public SimpleStorage(int size)
        {
            data = new T[size];
        }

        public void Add(T item)
        {
            if (index < data.Length)
            {
                data[index] = item;
                index++;
            }
 
        }

        public void PrintAll ()
        {
            for(int i = 0; i < index; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}
