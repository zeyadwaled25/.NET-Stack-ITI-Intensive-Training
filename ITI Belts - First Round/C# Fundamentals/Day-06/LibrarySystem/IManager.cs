using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal interface IManager
    {
        void AddBook(Book book);
        void RemoveBook(Book book);
      
    }
}
