using System;

namespace DateTimeAssignment
{
    class DateFormatting
    {
        // Method to display the current date in different formats
        public void DisplayDateFormats()
        {
            // Get the current system date and time
            DateTime currentDate = DateTime.Now;

            // Display the date in different formats
            Console.WriteLine($"Current date in dd/MM/yyyy format: {currentDate:dd/MM/yyyy}"); // Example: 30/01/2025
            Console.WriteLine($"Current date in yyyy-MM-dd format: {currentDate:yyyy-MM-dd}"); // Example: 2025-01-30
            Console.WriteLine($"Current date in EEE, MMM dd, yyyy format: {currentDate:ddd, MMM dd, yyyy}"); // Example: Thu, Jan 30, 2025
        }
    }
}
