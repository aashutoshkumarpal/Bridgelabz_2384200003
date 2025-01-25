using System;

namespace ArrayLevel2
{
    class NumberDigits
    {
        
        public void FindLargestAndSecondLargest()
        {
            // Take user input for the number
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Define the array to store digits and set the maxDigits size to 10
            int maxDigit = 10;
            int[] digits = new int[maxDigit];
            int index = 0;

            // Loop to extract the digits from the number
            while (number != 0)
            {
                if (index == maxDigit) break;  

                digits[index] = number % 10;  
                number = number / 10;  
                index++;  
            }

            // Variables to store the largest and second largest digits
            int largest = -1;
            int secondLargest = -1;

            // Loop to find the largest and second largest digits
            for (int i = 0; i < index; i++)
            {
                if (digits[i] > largest)  // Find largest
                {
                    secondLargest = largest;
                    largest = digits[i];
                }
                else if (digits[i] > secondLargest && digits[i] != largest)  // Find second largest
                {
                    secondLargest = digits[i];
                }
            }

            // Display the largest and second largest numbers
            if (largest != -1 && secondLargest != -1)
            {
                Console.WriteLine($"The largest digit is: {largest}");
                Console.WriteLine($"The second largest digit is: {secondLargest}");
            }
            else
            {
                Console.WriteLine("There are not enough unique digits to find the second largest.");
            }
        }
    }
}
