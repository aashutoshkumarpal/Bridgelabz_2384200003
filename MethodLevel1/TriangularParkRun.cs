using System;

namespace MethodLevel1
{
    class TriangularParkRun
    {
        public void InputMethod()
        {
            // Take user input for the three sides of the triangular park
            Console.Write("Enter the length of the first side of the park (in meters): ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of the second side of the park (in meters): ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of the third side of the park (in meters): ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            // Calculate the perimeter
            double perimeter = CalculatePerimeter(side1, side2, side3);

            // Calculate the number of rounds needed to complete 5 km
            double rounds = CalculateRounds(perimeter, 5000); // 5000 meters = 5 km

            // Display the result
            Console.WriteLine($"The athlete needs to complete {Math.Ceiling(rounds)} rounds to run 5 km.");
        }

        // Method to calculate the perimeter of the triangle
        public static double CalculatePerimeter(double side1, double side2, double side3)
        {
            return side1 + side2 + side3;
        }

        // Method to calculate the number of rounds
        public static double CalculateRounds(double perimeter, double distance)
        {
            return distance / perimeter;
        }
    }
}
