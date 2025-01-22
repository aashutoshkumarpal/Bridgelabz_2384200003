using System;

namespace new_project
{
    // Class to calculate discount on a given fee
    class DiscountCalculator
    {
        public void CalculateFee()
        {
            // Define the original fee and the discount percentage
            int fee = 125000;
            int discountPercent = 10;

            // Calculate the discount amount
            double discount = fee * discountPercent / 100.0;

            // Calculate the final discounted fee
            double discountedFee = fee - discount;

            // Display the discount amount and final fee
            Console.WriteLine($@"
            The discount amount is INR {discount:F2} and final discounted fee is INR {discountedFee:F2}");
        }
    }
}
