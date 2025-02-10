using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ride_Hailing_Application
{
    // Abstract class Vehicle
    abstract class Vehicle
    {
        private string vehicleId;
        private string driverName;
        protected double ratePerKm;

        public string VehicleId
        {
            get { return vehicleId; }
            private set { vehicleId = value; }
        }

        public string DriverName
        {
            get { return driverName; }
            private set { driverName = value; }
        }

        protected Vehicle(string vehicleId, string driverName, double ratePerKm)
        {
            this.vehicleId = vehicleId;
            this.driverName = driverName;
            this.ratePerKm = ratePerKm;
        }

        public abstract double CalculateFare(double distance); // Abstract method

        public virtual void GetVehicleDetails()
        {
            Console.WriteLine($"Vehicle ID: {vehicleId}, Driver: {driverName}, Rate per Km: {ratePerKm:C}");
        }
    }

    // Interface IGPS
    interface IGPS
    {
        void GetCurrentLocation();
        void UpdateLocation(string newLocation);
    }

    // Car subclass (Higher rate per km)
    class Car : Vehicle, IGPS
    {
        private string currentLocation;

        public Car(string vehicleId, string driverName, double ratePerKm)
            : base(vehicleId, driverName, ratePerKm) { }

        public override double CalculateFare(double distance)
        {
            return ratePerKm * distance;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine($"Car {VehicleId} is currently at: {currentLocation}");
        }

        public void UpdateLocation(string newLocation)
        {
            currentLocation = newLocation;
            Console.WriteLine($"Car {VehicleId} location updated to: {currentLocation}");
        }
    }

    // Bike subclass (Lower rate per km)
    class Bike : Vehicle, IGPS
    {
        private string currentLocation;

        public Bike(string vehicleId, string driverName, double ratePerKm)
            : base(vehicleId, driverName, ratePerKm) { }

        public override double CalculateFare(double distance)
        {
            return ratePerKm * distance;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine($"Bike {VehicleId} is currently at: {currentLocation}");
        }

        public void UpdateLocation(string newLocation)
        {
            currentLocation = newLocation;
            Console.WriteLine($"Bike {VehicleId} location updated to: {currentLocation}");
        }
    }

    // Auto subclass (Mid-range rate per km)
    class Auto : Vehicle, IGPS
    {
        private string currentLocation;

        public Auto(string vehicleId, string driverName, double ratePerKm)
            : base(vehicleId, driverName, ratePerKm) { }

        public override double CalculateFare(double distance)
        {
            return ratePerKm * distance;
        }

        public void GetCurrentLocation()
        {
            Console.WriteLine($"Auto {VehicleId} is currently at: {currentLocation}");
        }

        public void UpdateLocation(string newLocation)
        {
            currentLocation = newLocation;
            Console.WriteLine($"Auto {VehicleId} location updated to: {currentLocation}");
        }
    }

}
