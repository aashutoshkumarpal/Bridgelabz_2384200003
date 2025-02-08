using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Hybrid_Inheritance
{
    // Interface defining refueling capability
    interface Refuelable
    {
        void Refuel();
    }

    // Base class
    class Vehicle
    {
        public int MaxSpeed { get; set; }
        public string Model { get; set; }

        public Vehicle(int maxSpeed, string model)
        {
            MaxSpeed = maxSpeed;
            Model = model;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Max Speed: " + MaxSpeed + " km/h");
        }
    }

    // Subclass ElectricVehicle
    class ElectricVehicle : Vehicle
    {
        public int BatteryCapacity { get; set; }

        public ElectricVehicle(int maxSpeed, string model, int batteryCapacity)
            : base(maxSpeed, model)
        {
            BatteryCapacity = batteryCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Battery Capacity: " + BatteryCapacity + " kWh");
        }

        public void Charge()
        {
            Console.WriteLine("Charging electric vehicle...");
        }
    }

    // Subclass PetrolVehicle implementing Refuelable interface
    class PetrolVehicle : Vehicle, Refuelable
    {
        public int FuelTankCapacity { get; set; }

        public PetrolVehicle(int maxSpeed, string model, int fuelTankCapacity)
            : base(maxSpeed, model)
        {
            FuelTankCapacity = fuelTankCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Fuel Tank Capacity: " + FuelTankCapacity + " liters");
        }

        public void Refuel()
        {
            Console.WriteLine("Refueling petrol vehicle...");
        }
    }

}
