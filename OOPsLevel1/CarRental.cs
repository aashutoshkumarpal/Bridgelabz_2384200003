using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsLevel1
{
    internal class CarRental
    {

        // Properties
        public string CustomerName { get; set; }
        public string CarModel { get; set; }
        public int RentalDays { get; set; }
        private const double DailyRate = 50.0; // Fixed daily rental rate

        // Default Constructor
        public CarRental()
        {
            CustomerName = "Unknown";
            CarModel = "Economy";
            RentalDays = 1;
        }

        // Parameterized Constructor
        public CarRental(string customerName, string carModel, int rentalDays)
        {
            CustomerName = customerName;
            CarModel = carModel;
            RentalDays = rentalDays;
        }

        // Copy Constructor
        public CarRental(CarRental other)
        {
            CustomerName = other.CustomerName;
            CarModel = other.CarModel;
            RentalDays = other.RentalDays;
        }

        // Method to Calculate Total Cost
        public double CalculateTotalCost()
        {
            return RentalDays * DailyRate;
        }

        // Method to Display Rental Details
        public void DisplayRentalDetails()
        {
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Car Model: {CarModel}");
            Console.WriteLine($"Rental Days: {RentalDays}");
            Console.WriteLine($"Total Cost: ${CalculateTotalCost():F2}");
        }
    }
}
