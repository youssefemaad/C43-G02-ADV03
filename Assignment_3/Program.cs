using System;
using Assignment_3;

namespace AdvancedCSharp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Assignment 03 - Advanced C#");

            #region Question 1 - Implement fPtr
            /*
            Considering the Code Below, Write Down the Body of all Listed Methods and Properties,
            you need to Define fPtr as the following cases:
            
            a. User Defined Delegate Datatype
            b. BCL Delegates
            c. Anonymous Method (GetISBN)
            d. Lambda Expression (GetPublicationDate)
            */
            List<Book> books = new List<Book>{
                new Book("978-0-7356-6745-7", "C# 5.0 in a Nutshell", new string[] { "Joseph Albahari", "Ben Albahari" }, new DateTime(2012, 10, 10), 33.6),
                new Book("978-0-13-235088-4", "Clean Code: A Handbook of Agile Software Craftsmanship", new string[] { "Robert C. Martin" }, new DateTime(2008, 08, 11), 29.47),
                new Book("978-0-321-87758-1", "The C# Programming Language", new string[] { "Anders Hejlsberg", "Mads Torgersen" }, new DateTime(2008, 10, 22), 34.0),
                new Book("978-0-321-80202-9", "CLR via C#", new string[] { "Jeffrey Richter" }, new DateTime(2010, 12, 01), 44.99),
                new Book("978-0-672-33788-4", "C# 5.0 Unleashed", new string[] { "Bart De Smet" }, new DateTime(2013, 08, 22), 35.92)
            };

            // a. User Defined Delegate Datatype
            LibraryEngine.BookFunctionDelegate fPtr = BookFunctions.GetTitle;
            LibraryEngine.ProcessBooks(books, fPtr);

            // b. BCL Delegates
            fPtr = BookFunctions.GetAuthors;
            LibraryEngine.ProcessBooks(books, fPtr);

            // c. Anonymous Method (GetISBN)
            fPtr = delegate (Book B) { return B.ISBN; };
            LibraryEngine.ProcessBooks(books, fPtr);

            // d. Lambda Expression (GetPublicationDate)
            fPtr = B => B.PublicationDate.ToString();
            LibraryEngine.ProcessBooks(books, fPtr);
            

            #endregion

            #region Book Class
            // Define the Book class here
            #endregion

            #region BookFunctions Class
            // Define the BookFunctions class here
            #endregion

            #region LibraryEngine Class
            // Define the LibraryEngine class here
            #endregion
        }
    }
}
