using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherQuestion
{
    public class CalculatorApp2
    {
     

            // Divides the first integer by the second
            public double Divide(int a, int b)
            {
                if (b == 0)
                {
                    throw new ArithmeticException("Cannot divide by zero.");
                }
                return (double)a / b; // Cast to double for accurate result
            }
    }
}

