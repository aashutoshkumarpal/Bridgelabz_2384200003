using System;

namespace MethodLevel2
{
    public class BMIAnalyzer
    {
        public static void InputAndProcess()
        {
            double[,] data = new double[10, 3]; // 2D array: Column 0 = Weight, Column 1 = Height (cm), Column 2 = BMI
            string[] statuses = new string[10];

            // Input weight and height for 10 members
            Console.WriteLine("Enter the weight (in kg) and height (in cm) for 10 members:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Person {i + 1} - Weight (kg): ");
                data[i, 0] = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Person {i + 1} - Height (cm): ");
                data[i, 1] = Convert.ToDouble(Console.ReadLine());
            }

            // Calculate BMI and determine status
            CalculateBMI(data);
            statuses = DetermineBMIStatus(data);

            // Display the results
            Console.WriteLine("\nResults:");
            Console.WriteLine("Person\tWeight (kg)\tHeight (cm)\tBMI\t\tStatus");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}\t{data[i, 0]:F2}\t\t{data[i, 1]:F2}\t\t{data[i, 2]:F2}\t\t{statuses[i]}");
            }
        }

        // Method to calculate BMI and populate the array
        public static void CalculateBMI(double[,] data)
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                double weight = data[i, 0];
                double heightInMeters = data[i, 1] / 100; // Convert height from cm to meters
                data[i, 2] = weight / (heightInMeters * heightInMeters); // Calculate BMI
            }
        }

        // Method to determine BMI status
        public static string[] DetermineBMIStatus(double[,] data)
        {
            string[] statuses = new string[data.GetLength(0)];

            for (int i = 0; i < data.GetLength(0); i++)
            {
                double bmi = data[i, 2];

                if (bmi < 18.5)
                {
                    statuses[i] = "Underweight";
                }
                else if (bmi >= 18.5 && bmi < 24.9)
                {
                    statuses[i] = "Normal weight";
                }
                else if (bmi >= 25 && bmi < 29.9)
                {
                    statuses[i] = "Overweight";
                }
                else
                {
                    statuses[i] = "Obesity";
                }
            }

            return statuses;
        }
    }
}
