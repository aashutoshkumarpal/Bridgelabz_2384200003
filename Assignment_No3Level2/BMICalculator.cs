using System;

namespace Assignment_No3Level2
{
    class BMICalculator
    {
        public void CalculateBMI()
        {
            
            Console.Write("Enter weight (in kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (in cm): ");
            double heightCm = Convert.ToDouble(Console.ReadLine());

            // Convert height from cm to meters
            double heightMeters = heightCm / 100;

            // Ensure valid input
            if (weight <= 0 || heightMeters <= 0)
            {
                Console.WriteLine("Please enter valid positive values for weight and height.");
                return;
            }

            // Calculate BMI
            double bmi = weight / (heightMeters * heightMeters);

            // Display BMI value
            Console.WriteLine($"Your BMI is: {bmi:F2}");

            // Determine weight status
            if (bmi < 18.5)
            {
                Console.WriteLine("Weight Status: Underweight");
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                Console.WriteLine("Weight Status: Normal weight");
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                Console.WriteLine("Weight Status: Overweight");
            }
            else
            {
                Console.WriteLine("Weight Status: Obesity");
            }
        }
    }
}
