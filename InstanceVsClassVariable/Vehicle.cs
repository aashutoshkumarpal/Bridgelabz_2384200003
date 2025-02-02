using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVsClassVariable
{
    internal class Vehicle
    {
        // Instance Variables
        public string OwnerName { get; set; }
        public string VehicleType { get; set; }

        // Class Variable (Shared among all instances)
        private static double registrationFee = 100.00; // Default fee

        // Constructor to Initialize Vehicle
        public Vehicle(string ownerName, string vehicleType)
        {
            OwnerName = ownerName;
            VehicleType = vehicleType;
        }

        // Instance Method to Display Vehicle Details
        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"Owner Name: {OwnerName}");
            Console.WriteLine($"Vehicle Type: {VehicleType}");
            Console.WriteLine($"Registration Fee: Rs {registrationFee:F2}");
            Console.WriteLine();
        }

        // Class Method to Update Registration Fee
        public static void UpdateRegistrationFee(double newFee)
        {
            registrationFee = newFee;
            Console.WriteLine($"Registration Fee Updated to: Rs {registrationFee:F2}");
            Console.WriteLine();
        }
    }
}
