using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecptionHandlingAssignment
{
    internal class PropagatingExceptions
    {
        // Method that throws an ArithmeticException
        public void Method1()
        {
            int result = 10/0; // This will throw DivideByZeroException (ArithmeticException)
        }

        // Method that calls Method1()
        public void Method2()
        {
            Method1(); // Exception propagates from here
        }

        public void InputMethod()
        {
            try
            { 
                Method2(); // Calls Method2, which calls Method1
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Handled exception in Main.");
            }
        }
    }
}
