using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Hailing_Application
{
    internal class Program
    {
        static void ProcessRides(List<Vehicle> rides, double distance)
        {
            foreach (var vehicle in rides)
            {
                vehicle.GetVehicleDetails();
                Console.WriteLine($"Fare for {distance} km: {vehicle.CalculateFare(distance):C}\n");

                if (vehicle is IGPS gpsVehicle)
                {
                    gpsVehicle.UpdateLocation("Downtown Center");
                    gpsVehicle.GetCurrentLocation();
                }

                Console.WriteLine();
            }
        }

        static void Main()
        {
            List<Vehicle> rides = new List<Vehicle>
        {
            new Car("C001", "John Doe", 15.0),
            new Bike("B001", "Alice Smith", 5.0),
            new Auto("A001", "Bob Brown", 8.0)
        };

            ProcessRides(rides, 10); // Calculate fares for a 10 km ride
        }
    }
}
