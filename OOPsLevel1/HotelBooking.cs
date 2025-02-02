using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsLevel1
{
    internal class HotelBooking
    {
        // Properties
        public string GuestName { get; set; }
        public string RoomType { get; set; }
        public int Nights { get; set; }

        // Default Constructor
        public HotelBooking()
        {
            GuestName = "Unknown";
            RoomType = "Standard";
            Nights = 1;
        }

        // Parameterized Constructor
        public HotelBooking(string guestName, string roomType, int nights)
        {
            GuestName = guestName;
            RoomType = roomType;
            Nights = nights;
        }

        // Copy Constructor
        public HotelBooking(HotelBooking other)
        {
            GuestName = other.GuestName;
            RoomType = other.RoomType;
            Nights = other.Nights;
        }

        // Method to Display Booking Details
        public void DisplayBookingDetails()
        {
            Console.WriteLine($"Guest Name: {GuestName}");
            Console.WriteLine($"Room Type: {RoomType}");
            Console.WriteLine($"Nights: {Nights}");
        }
    }
}
