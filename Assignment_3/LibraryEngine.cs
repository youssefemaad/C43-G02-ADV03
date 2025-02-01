using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class LibraryEngine
    {
        public delegate string BookFunctionDelegate(Book B);
        public static void ProcessBooks(List<Book> books, BookFunctionDelegate fPtr)
        {
            foreach (Book book in books)
            {
                Console.WriteLine(fPtr(book));
            }
        }
    }
}
