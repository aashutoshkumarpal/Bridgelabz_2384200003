using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    internal class Program
    {
        static void CalculateRentalAndInsurance(List<Vehicle> vehicles, int days)
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.DisplayDetails(days);
                if (vehicle is IInsurable insurable)
                {
                    Console.WriteLine(insurable.GetInsuranceDetails());
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("MH12AB1234", 1000, "CAR12345"),
            new Bike("MH14CD5678", 500),
            new Truck("MH10EF9012", 2000, "TRK67890")
        };

            int rentalDays = 5;
            CalculateRentalAndInsurance(vehicles, rentalDays);
        }
    }
}
