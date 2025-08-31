using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class Librarian : Person, IManager
    {
        List<Book> books = new List<Book>();
        public Librarian(string name, int age) : base(name, age)
        {
        }

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Book {book.Title} added to the library.");
        }


        public void RemoveBook(Book book)
        {
            books.Remove(book);
            Console.WriteLine($"Book {book.Title} removed from the library.");
        }

        public void AddBook(string title, string author)
        {
            Book book = new Book(title, author);
            books.Add(book);
            Console.WriteLine($"Book {book.Title} added to the library.");
        }


        public override void DisplayInfo()
        {
            Console.WriteLine($"Librarian Name: {Name}, Age: {Age}");
        }
    }
}
