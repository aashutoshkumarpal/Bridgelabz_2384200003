using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsLevel1
{
    internal class Book
    {
        // Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        // Default Constructor
        public Book()
        {
            Title = "Unknown";
            Author = "Unknown";
            Price = 0.0;
        }

        // Parameterized Constructor
        public Book(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        // Method to Display Book Details
        public void DisplayBookDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Price: {Price:C}");
        }
    }
}

