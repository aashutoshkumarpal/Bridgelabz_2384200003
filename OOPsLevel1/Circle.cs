using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsLevel1
{
    internal class Circle
    {
        // Property for Radius
        public double Radius { get; set; }

        // Default Constructor (Initializes Radius to 1.0)
        public Circle() : this(1.0) { }

        // Parameterized Constructor (Initializes Radius with User-Provided Value)
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Method to Calculate Area
        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        // Method to Calculate Circumference
        public double GetCircumference()
        {
            return 2 * Math.PI * Radius;
        }

        // Method to Display Circle Details
        public void DisplayCircleDetails()
        {
            Console.WriteLine($"Radius: {Radius}");
            Console.WriteLine($"Area: {GetArea():F2}");
            Console.WriteLine($"Circumference: {GetCircumference():F2}");
        }
    }
}
