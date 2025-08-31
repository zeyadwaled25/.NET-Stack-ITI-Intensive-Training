using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        private bool isAvailable = true;

        public bool IsAvailable
        {
            get { return isAvailable; }
            private set { isAvailable = value; }
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void Borrow()
        {
            if (!IsAvailable)
            {
                Console.WriteLine($"Sorry {Title} is already borrowed");
            }
            else
            {
                IsAvailable = false;
                Console.WriteLine($"You have borrowed {Title}");
            }
        }

        public void Return()
        {
            if (IsAvailable)
            {
                Console.WriteLine($"{Title} was not borrowed");
            }
            else
            {
                IsAvailable = true;
                Console.WriteLine($"You have returned {Title}");
            }
        }

        public static bool operator ==(Book b1, Book b2)
        {
            return b1.Title == b2.Title && b1.Author == b2.Author ;
        }

        public static bool operator !=(Book b1, Book b2)
        {
            return !(b1 == b2);
        }
    }
}
