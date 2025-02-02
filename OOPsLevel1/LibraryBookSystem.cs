using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsLevel1
{
    internal class LibraryBookSystem
    {
        // Attributes
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }

        // Constructor to Initialize Book
        public LibraryBookSystem(string title, string author, double price)
        {
            Title = title;
            Author = author;
            Price = price;
            IsAvailable = true; // Book is available by default
        }

        // Method to Borrow a Book
        public void BorrowBook()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"The book \"{Title}\" has been borrowed.");
            }
            else
            {
                Console.WriteLine($"Sorry, \"{Title}\" is already borrowed.");
            }
        }

        // Method to Display Book Details
        public void DisplayBookDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Price: ${Price:F2}");
            Console.WriteLine($"Availability: {(IsAvailable ? "Available" : "Not Available")}");
        }
    }
}
