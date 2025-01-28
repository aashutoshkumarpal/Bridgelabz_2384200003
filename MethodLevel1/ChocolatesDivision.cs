using System;

namespace MethodLevel1
{
    class ChocolatesDivision
    {
        public void InputMethod()
        {
            // Get user input for number of chocolates and number of children
            Console.Write("Enter the number of chocolates: ");
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of children: ");
            int numberOfChildren = Convert.ToInt32(Console.ReadLine());

            // Call the method to find the quotient and remainder
            int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

            // Display the result
            Console.WriteLine($"Each child will get {result[0]} chocolates.");
            Console.WriteLine($"Remaining chocolates: {result[1]}");
        }

        // Method to find the number of chocolates each child gets and the remaining chocolates
        public static int[] FindRemainderAndQuotient(int numberOfChocolates, int numberOfChildren)
        {
            int chocolatesPerChild = numberOfChocolates / numberOfChildren;
            int remainingChocolates = numberOfChocolates % numberOfChildren;

            return new int[] { chocolatesPerChild, remainingChocolates };
        }
    }
}
