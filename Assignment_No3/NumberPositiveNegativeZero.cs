using System;

namespace Assignment_No3
{
    class NumberPositiveNegativeZero
    {
        public void CheckNumber()
        {
            // Input the number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is positive, negative, or zero
            if (number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else
            {
                Console.WriteLine("The number is zero.");
            }
        }
    }
}
