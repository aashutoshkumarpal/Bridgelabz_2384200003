using System;

namespace new_project
{
    // Class to convert kilometers to miles
    class KmToMiles
    {
        public void ConvertKmtoMiles()
        {
            // Define the distance in kilometers
            double distance = 10.8;

            // Convert the distance from kilometers to miles (1 mile ≈ 1.6 kilometers)
            double miles = distance * 1.6;

            // Display the result in miles
            Console.WriteLine($"The distance {distance} km in miles is {miles}");
        }
    }
}
