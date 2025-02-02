using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsLevel1
{
    internal class CallingAllClass
    {
        public void callingBook()
        {
            // Using Default Constructor
            Book book1 = new Book();
            Console.WriteLine("Default Constructor Book:");
            book1.DisplayBookDetails();
            Console.WriteLine();

            // Using Parameterized Constructor
            Book book2 = new Book("C# Programming", "John Doe", 29.99);
            Console.WriteLine("Parameterized Constructor Book:");
            book2.DisplayBookDetails();
            Console.ReadKey();
        }

        public void callingCircle()
        {
            // Using Default Constructor
            Circle circle1 = new Circle();
            Console.WriteLine("Default Constructor Circle:");
            circle1.DisplayCircleDetails();
            Console.WriteLine();

            // Using Parameterized Constructor
            Circle circle2 = new Circle(5.5);
            Console.WriteLine("Parameterized Constructor Circle:");
            circle2.DisplayCircleDetails();
            Console.ReadKey();
        }

        public void callingPerson()
        {
            // Using Parameterized Constructor
            Person person1 = new Person("Alice", 25);
            Console.WriteLine("Original Person:");
            person1.DisplayPersonDetails();
            Console.WriteLine();

            // Using Copy Constructor
            Person person2 = new Person(person1);
            Console.WriteLine("Copied Person:");
            person2.DisplayPersonDetails();
            Console.ReadKey();
        }

        public void callingHotelBooking()
        {
            // Using Default Constructor
            HotelBooking booking1 = new HotelBooking();
            Console.WriteLine("Default Booking:");
            booking1.DisplayBookingDetails();
            Console.WriteLine();

            // Using Parameterized Constructor
            HotelBooking booking2 = new HotelBooking("Alice Johnson", "Deluxe", 3);
            Console.WriteLine("Parameterized Booking:");
            booking2.DisplayBookingDetails();
            Console.WriteLine();

            // Using Copy Constructor
            HotelBooking booking3 = new HotelBooking(booking2);
            Console.WriteLine("Copied Booking:");
            booking3.DisplayBookingDetails();
            Console.ReadKey();
        }

        public void CallingLibaryBookSystem()
        {
            // Creating Books
            LibraryBookSystem book1 = new LibraryBookSystem("The Great Gatsby", "F. Scott Fitzgerald", 10.99);
            LibraryBookSystem book2 = new LibraryBookSystem("1984", "George Orwell", 8.99);

            // Display Book Details
            Console.WriteLine("Book Details Before Borrowing:");
            book1.DisplayBookDetails();
            Console.WriteLine();

            // Borrowing the Book
            book1.BorrowBook();
            Console.WriteLine();

            // Trying to Borrow Again
            book1.BorrowBook();
            Console.WriteLine();

            // Display Book Details After Borrowing
            Console.WriteLine("Book Details After Borrowing:");
            book1.DisplayBookDetails();
            Console.ReadKey();
        }

        public void CallingCarRental()
        {
            // Using Default Constructor
            CarRental rental1 = new CarRental();
            Console.WriteLine("Default Rental:");
            rental1.DisplayRentalDetails();
            Console.WriteLine();

            // Using Parameterized Constructor
            CarRental rental2 = new CarRental("John Doe", "SUV", 5);
            Console.WriteLine("Parameterized Rental:");
            rental2.DisplayRentalDetails();
            Console.WriteLine();

            // Using Copy Constructor
            CarRental rental3 = new CarRental(rental2);
            Console.WriteLine("Copied Rental:");
            rental3.DisplayRentalDetails();
            Console.ReadKey();
        }
    }
}
