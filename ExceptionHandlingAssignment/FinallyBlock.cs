using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecptionHandlingAssignment
{
    internal class FinallyBlock
    {
        public void InputMethod()
        {
            try
            {
                Console.Write("Enter the numerator: ");
                int numerator = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the denominator: ");
                int denominator = Convert.ToInt32(Console.ReadLine());

                int result = numerator / denominator;
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
            finally
            {
                Console.WriteLine("Operation completed.");
            }
        }
    }
}
