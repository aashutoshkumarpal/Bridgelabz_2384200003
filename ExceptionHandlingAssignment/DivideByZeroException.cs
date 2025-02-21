using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecptionHandlingAssignment
{
    internal class DivideByZero
    {
        public void InputMethod()
        {
            try
            {
                Console.Write("Enter the numerator: ");
                double numerator = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the denominator: ");
                double denominator = Convert.ToDouble(Console.ReadLine());

                double result = numerator / denominator;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input! Please enter numeric values.");
            }
        }
    }
}
