using System;

namespace MethodLevel2
{
    public class QuadraticEquationSolver
    {
        // Method to find the roots of the quadratic equation
        public static double[] FindRoots(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - 4 * a * c; // Compute the discriminant

            if (delta > 0)
            {
                // Two distinct real roots
                double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
                return new double[] { root1, root2 };
            }
            else if (delta == 0)
            {
                // One real root
                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {
                // No real roots, delta < 0
                return new double[0];
            }
        }

        // Input and output handling
        public static void InputAndSolve()
        {
            Console.WriteLine("Enter the coefficients of the quadratic equation (a, b, c):");

            Console.Write("a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Invalid input: 'a' cannot be zero for a quadratic equation.");
                return;
            }

            // Call method to find the roots
            double[] roots = FindRoots(a, b, c);

            // Display the results
            if (roots.Length == 2)
            {
                Console.WriteLine($"The equation has two distinct real roots: x1 = {roots[0]:F2}, x2 = {roots[1]:F2}");
            }
            else if (roots.Length == 1)
            {
                Console.WriteLine($"The equation has one real root: x = {roots[0]:F2}");
            }
            else
            {
                Console.WriteLine("The equation has no real roots.");
            }
        }
    }
}
