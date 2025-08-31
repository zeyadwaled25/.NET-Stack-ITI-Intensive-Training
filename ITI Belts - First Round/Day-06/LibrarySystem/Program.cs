namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Librarian librarian = new Librarian("Alice", 30);
            User user = new User("Bob", 25);

            Book book1 = new Book("1984", "George Orwell");
            Book book2 = new Book("1984", "George Orwell");

            librarian.AddBook(book1);
            Console.WriteLine("-------------------------");
            librarian.AddBook(book2);
            Console.WriteLine("-------------------------");

            librarian.DisplayInfo();
            Console.WriteLine("-------------------------");

            user.DisplayInfo();
            Console.WriteLine("-------------------------");
            user.BorrowBook(book1);
            Console.WriteLine("-------------------------");
            user.BorrowBook(book1); // Trying to borrow again
            Console.WriteLine("-------------------------");
            book1.Return();
            Console.WriteLine("-------------------------");
            book1.Return(); // Trying to return again
            Console.WriteLine("-------------------------");
            librarian.RemoveBook(book2);

            Console.WriteLine(book1 == book2);

        }
    }
}
