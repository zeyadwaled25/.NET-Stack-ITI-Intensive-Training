using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class User : Person, IBorrower
    {
        public User(string name, int age) : base(name, age)
        {
        }

        public void BorrowBook(Book book)
        {
            book.Borrow();
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"User Name: {Name}, Age: {Age}");
        }
    }
}
