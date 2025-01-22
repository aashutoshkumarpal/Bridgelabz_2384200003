using System;

namespace Assignment_No2
{
    class QuotientRemainderCalculator
    {
        public void CalculateQuotientRemainder()
        {
            // Take two numbers as input from the user
            Console.Write("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter the second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            // Calculate the quotient and remainder using division and modulus operators
            int quotient = number1 / number2;
            int remainder = number1 % number2;

            // Display the result
            Console.WriteLine($"The Quotient is {quotient} and Remainder is {remainder} of two numbers {number1} and {number2}");
        }
    }
}
