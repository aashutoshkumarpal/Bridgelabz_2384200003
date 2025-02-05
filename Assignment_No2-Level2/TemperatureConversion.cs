using System;

namespace Assignment_No2
{
    
    class TemperatureConversion
    {
        public void ConvertTemperature()
        {
            // Take the temperature in Celsius as input from the user
            Console.Write("Enter the temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // Convert Celsius to Fahrenheit using the formula: (°C × 9/5) + 32 = °F
            double fahrenheitResult = (celsius * 9 / 5) + 32;

            // Display the result
            Console.WriteLine($"The {celsius:F2} Celsius is {fahrenheitResult:F2} Fahrenheit");
        }
    }
}
