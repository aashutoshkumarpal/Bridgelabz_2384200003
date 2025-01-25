using System;

namespace ArrayLevel2
{
    class BMIUsing2DArray
    {
        
        public void CalculateBMI()
        {
            // Take input for the number of persons
            Console.Write("Enter the number of persons: ");
            int numPersons = Convert.ToInt32(Console.ReadLine());

            // Create a multi-dimensional array to store weight, height, and BMI (3 columns: height, weight, bmi)
            double[][] personData = new double[numPersons][];
            string[] weightStatus = new string[numPersons];

            // Take input for each person's weight and height, and calculate BMI
			
            for (int i = 0; i < numPersons; i++)
            {
                personData[i] = new double[3]; 
                
                // Input weight with validation for positive values
                do
                {
                    Console.WriteLine($"\nEnter details for person {i + 1}:");
                    Console.Write("Weight (in kg): ");
                    personData[i][1] = Convert.ToDouble(Console.ReadLine());
                } while (personData[i][1] <= 0);  

                // Input height with validation for positive values
                do
                {
                    Console.Write("Height (in meters): ");
                    personData[i][0] = Convert.ToDouble(Console.ReadLine());
                } while (personData[i][0] <= 0);  // Ensure height is positive

                // Calculate BMI for each person and store in the 2D array (personData[i][2])
                personData[i][2] = personData[i][1] / (personData[i][0] * personData[i][0]);

                // Determine weight status based on BMI
                if (personData[i][2] < 18.5)
                    weightStatus[i] = "Underweight";
                else if (personData[i][2] >= 18.5 && personData[i][2] < 24.9)
                    weightStatus[i] = "Normal weight";
                else if (personData[i][2] >= 25 && personData[i][2] < 29.9)
                    weightStatus[i] = "Overweight";
                else
                    weightStatus[i] = "Obesity";
            }

            // Display the results
            Console.WriteLine("\nBMI and Weight Status for each person:");

            // Loop to display height, weight, BMI, and weight status
            for (int i = 0; i < numPersons; i++)
            {
                Console.WriteLine($"\nPerson {i + 1}:");
                Console.WriteLine($"Height: {personData[i][0]} m");
                Console.WriteLine($"Weight: {personData[i][1]} kg");
                Console.WriteLine($"BMI: {personData[i][2]:0.00}");
                Console.WriteLine($"Status: {weightStatus[i]}");
            }
        }
    }
}
