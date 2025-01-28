using System;

namespace MethodLevel2
{
    static class UnitConverter
    {
        // Method to convert kilometers to miles
        public static double ConvertKmToMiles(double km)
        {
            double km2miles = 0.621371;
            return km * km2miles;
        }

        // Method to convert miles to kilometers
        public static double ConvertMilesToKm(double miles)
        {
            double miles2km = 1.60934;
            return miles * miles2km;
        }

        // Method to convert meters to feet
        public static double ConvertMetersToFeet(double meters)
        {
            double meters2feet = 3.28084;
            return meters * meters2feet;
        }

        // Method to convert feet to meters
        public static double ConvertFeetToMeters(double feet)
        {
            double feet2meters = 0.3048;
            return feet * feet2meters;
        }
    }

    class UnitConverterDemo
    {
        public void InputMethod()
        {
            // Demonstrate all conversions
            Console.WriteLine("Unit Converter Demo:");

            // Kilometers to Miles
            Console.Write("Enter kilometers to convert to miles: ");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{km} kilometers is {UnitConverter.ConvertKmToMiles(km)} miles.");

            // Miles to Kilometers
            Console.Write("Enter miles to convert to kilometers: ");
            double miles = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{miles} miles is {UnitConverter.ConvertMilesToKm(miles)} kilometers.");

            // Meters to Feet
            Console.Write("Enter meters to convert to feet: ");
            double meters = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{meters} meters is {UnitConverter.ConvertMetersToFeet(meters)} feet.");

            // Feet to Meters
            Console.Write("Enter feet to convert to meters: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{feet} feet is {UnitConverter.ConvertFeetToMeters(feet)} meters.");
        }
    }
}
