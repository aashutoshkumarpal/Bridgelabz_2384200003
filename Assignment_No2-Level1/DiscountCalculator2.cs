using System;

namespace new_project
{
    // Class to calculate and display the discount and final fee
    class DiscountCalculator2
    {
        public void CalculateFee()
        {
            // Read the fee and discount percentage from user input
            int fee = Convert.ToInt32(Console.ReadLine());
            int discountPercent = Convert.ToInt32(Console.ReadLine());

            // Calculate the discount amount and the discounted fee
            double discount = fee * discountPercent / 100.0;
            double discountedFee = fee - discount;

            // Display the discount and the final discounted fee
            Console.WriteLine($"The discount amount is INR {discount:F2} and final discounted fee is INR {discountedFee:F2}");
        }
    }
}
