using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Program
    {
        static void ManageLibraryItems(List<LibraryItem> items)
        {
            foreach (var item in items)
            {
                item.GetItemDetails();

                if (item is IReservable reservableItem)
                {
                    Console.WriteLine($"Available for reservation: {reservableItem.CheckAvailability()}");
                    reservableItem.ReserveItem("Alice");
                }

                Console.WriteLine();
            }
        }

        static void Main()
        {
            List<LibraryItem> libraryItems = new List<LibraryItem>
        {
            new Book("B001", "The Great Gatsby", "F. Scott Fitzgerald"),
            new Magazine("M002", "National Geographic", "John Doe"),
            new DVD("D003", "Inception", "Christopher Nolan")
        };

            ManageLibraryItems(libraryItems);

            libraryItems[0].BorrowItem("John"); // Borrow a book
            libraryItems[0].ReturnItem();       // Return a book
        }
    }
}
