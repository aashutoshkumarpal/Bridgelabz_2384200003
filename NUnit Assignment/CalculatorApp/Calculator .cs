using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
         // Adds two integers
            public int Add(int a, int b)
            {
                return a + b;
            }

            // Subtracts the second integer from the first
            public int Subtract(int a, int b)
            {
                return a - b;
            }

            // Multiplies two integers
            public int Multiply(int a, int b)
            {
                return a * b;
            }

            // Divides the first integer by the second
            public double Divide(int a, int b)
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("Cannot divide by zero.");
                }
                return (double)a / b; // Cast to double for accurate result
            }
       
    }
}
