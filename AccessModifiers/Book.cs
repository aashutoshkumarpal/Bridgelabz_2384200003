using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    // Base Class: Book
    public class Book
    {
        // Public member: Accessible anywhere
        public string ISBN { get; set; }

        // Protected member: Accessible in derived classes
        protected string Title;

        // Private member: Accessible only within the class
        private string Author;

        // Constructor to initialize book details
        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
        }

        // Public Method to Set Author Name
        public void SetAuthor(string author)
        {
            Author = author;
        }

        // Public Method to Get Author Name
        public string GetAuthor()
        {
            return Author;
        }

        // Public Method to Display Book Details
        public void DisplayBookDetails()
        {
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine();
        }
    }

    // Derived Class: EBook
    public class EBook : Book
    {
        public double FileSize { get; set; } // In MB
        public string Format { get; set; }   // e.g., PDF, EPUB

        // Constructor using base class constructor
        public EBook(string isbn, string title, string author, double fileSize, string format)
            : base(isbn, title, author)
        {
            FileSize = fileSize;
            Format = format;
        }

        // Method to Display E-Book Details
        public void DisplayEBookDetails()
        {
            Console.WriteLine($"E-Book ISBN: {ISBN}"); // Accessible due to 'public' modifier
            Console.WriteLine($"E-Book Title: {Title}"); // Accessible due to 'protected' modifier
            Console.WriteLine($"E-Book Format: {Format}");
            Console.WriteLine($"File Size: {FileSize} MB");
            Console.WriteLine($"Author: {GetAuthor()}"); // Accessing private member using public method
            Console.WriteLine();
        }
    }
}
