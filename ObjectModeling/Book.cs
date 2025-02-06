using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModeling
{
    public class Book
    {
        public string Title { get; set; }   
        public string Author { get; set; }

        public Book( string title , string aithor)
        {
            Title = title;
            Author = aithor;
        }

        public void DisplayBook()
        {
            Console.WriteLine($" Title : {Title} , Author :{Author}");
        }
    }

    public class Library
    { 
        public string Name { get; set; }    
        private List<Book> books;

        public Library(String name)
        {
            Name = name;
            books = new List<Book>();   
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void DisplayBooks()
        {
            Console.WriteLine($"\n Library :{Name}");

            if (books.Count == 0)
            {
                Console.WriteLine("NO Books Available");
            }
            else
            {
                foreach (var book in books)
                { 
                book.DisplayBook();
                }
            }
        }
    }

    public class LibraryDemo
    {

        public void InputMethod()
        {

            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
            Book book3 = new Book("1984", "George Orwell");

            // Creating libraries
            Library library1 = new Library("City Library");
            Library library2 = new Library("University Library");

            // Adding books to libraries
            library1.AddBook(book1);
            library1.AddBook(book2);

            library2.AddBook(book3);
            library2.AddBook(book1); // Same book can exist in multiple libraries

            // Displaying books in libraries
            library1.DisplayBooks();
            library2.DisplayBooks();
        }
    }
}
