using System;

namespace MethodLevel1
{
    class TrigonometricFunctions
    {
        public void InputMethod()
        {
            // Get user input for the angle in degrees
            Console.Write("Enter the angle in degrees: ");
            double angle = Convert.ToDouble(Console.ReadLine());

            // Call the method to calculate trigonometric functions
            double[] results = CalculateTrigonometricFunctions(angle);

            // Display the results
            Console.WriteLine($"Sine of {angle}°: {results[0]}");
            Console.WriteLine($"Cosine of {angle}°: {results[1]}");
            Console.WriteLine($"Tangent of {angle}°: {results[2]}");
        }

        // Method to calculate trigonometric functions (sine, cosine, and tangent)
        public double[] CalculateTrigonometricFunctions(double angle)
        {
            // Convert angle from degrees to radians
            double radians = angle * (Math.PI / 180);

            // Calculate sine, cosine, and tangent
            double sine = Math.Sin(radians);
            double cosine = Math.Cos(radians);
            double tangent = Math.Tan(radians);

            // Return the results as an array
            return new double[] { sine, cosine, tangent };
        }
    }
}
