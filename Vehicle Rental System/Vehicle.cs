using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental_System
{
    abstract class Vehicle
    {
        private string vehicleNumber;
        private string type;
        private double rentalRate;

        public string  VehicleNumber
        {
            get { return vehicleNumber; }
            set { vehicleNumber = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double RentalRate
        {
            get { return rentalRate; }
            set { rentalRate = value; }
        }

        public Vehicle(string vehicleNumber, string type, double rentalRate)
        { 
            this.vehicleNumber = vehicleNumber;
            this.type = type;
            this.rentalRate = rentalRate;
        }

        public abstract double CalCulateRentalCost(int days);

        public virtual void DisplayDetails(int days)
        {
            Console.WriteLine($"Vehicle Number : {vehicleNumber}, Vehicle type {type} , Rental rate :{rentalRate}");
        }
    }

    interface IInsurable
    {
        double CalculateInsurance();
        string GetInsuranceDetails();
    }

    class Car : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Car(string vehicleNumber, double rentalRate, string insurancePolicy) : base(vehicleNumber, "Car", rentalRate)
        {
            this.insurancePolicyNumber = insurancePolicy;
        }

        public double CalculateInsurance()
        {
            return RentalRate * 0.02;
        }

        public override double CalCulateRentalCost(int days)
        {
            return RentalRate * days ;
        }

        public string GetInsuranceDetails()
        {
            return $"Car Insurance (Policy No: {insurancePolicyNumber}), Cost: {CalculateInsurance():C}";
        }
    }

    class Bike : Vehicle
    {
        public Bike(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Bike", rentalRate) { }

        public override double CalCulateRentalCost(int days)
        {
            return RentalRate * days * 0.9;
        }
    }

    class Truck : Vehicle, IInsurable
    {
        private string insurancePolicyNumber;

        public Truck(string vehicleNumber, double rentalRate, string insurancePolicy):base(vehicleNumber, "Truck", rentalRate)
        {
            this.insurancePolicyNumber = insurancePolicy;
        }
        public double CalculateInsurance()
        {
            return RentalRate * 0.05; // 5% of rental rate
        }

        public override double CalCulateRentalCost(int days)
        {
            return RentalRate * days + 500; // Additional flat fee
        }

        public string GetInsuranceDetails()
        {
            return $"Truck Insurance (Policy No: {insurancePolicyNumber}), Cost: {CalculateInsurance():C}";
        }
    }
}
