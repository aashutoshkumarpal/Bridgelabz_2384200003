using System;

namespace Assignment_No2
{
    class TemperatureConversion2
    {
        public void ConvertFahrenheitToCelsius()
        {
            // Ask the user to enter the temperature in Fahrenheit
            Console.Write("Enter the temperature in Fahrenheit: ");
            
            // Read the input and convert it to a double
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            
            // Use the formula to convert Fahrenheit to Celsius
            double celsiusResult = (fahrenheit - 32) * 5 / 9;
            
            // Print the result in a clear and friendly way
            Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsiusResult:F2} Celsius.");
        }
    }
}
