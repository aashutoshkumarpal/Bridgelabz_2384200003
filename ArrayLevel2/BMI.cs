using System;

namespace ArrayLevel2
{
    class BMI
    {
        
        public void CalculateBMI()
        {
            // Take input for the number of persons
            Console.Write("Enter the number of persons: ");
            int numPersons = Convert.ToInt32(Console.ReadLine());

            // Create arrays to store weight, height, BMI, and status
            double[] weight = new double[numPersons];
            double[] height = new double[numPersons];
            double[] bmi = new double[numPersons];
            string[] status = new string[numPersons];

            // Take input for each person's weight and height
            for (int i = 0; i < numPersons; i++)
            {
                Console.WriteLine($"\nEnter details for person {i + 1}:");

                // Input weight and height for each person
                Console.Write("Weight (in kg): ");
                weight[i] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Height (in meters): ");
                height[i] = Convert.ToDouble(Console.ReadLine());

                // Calculate BMI for each person
                bmi[i] = weight[i] / (height[i] * height[i]);

                // Determine weight status based on BMI
                if (bmi[i] < 18.5)
                    status[i] = "Underweight";
                else if (bmi[i] >= 18.5 && bmi[i] < 24.9)
                    status[i] = "Normal weight";
                else if (bmi[i] >= 25 && bmi[i] < 29.9)
                    status[i] = "Overweight";
                else
                    status[i] = "Obesity";
            }

            // Display the results
            Console.WriteLine("\nBMI and Weight Status for each person:");

            // Loop to display height, weight, BMI, and weight status
            for (int i = 0; i < numPersons; i++)
            {
                Console.WriteLine($"\nPerson {i + 1}:");
                Console.WriteLine($"Height: {height[i]} m");
                Console.WriteLine($"Weight: {weight[i]} kg");
                Console.WriteLine($"BMI: {bmi[i]:0.00}");
                Console.WriteLine($"Status: {status[i]}");
            }
        }
    }
}
