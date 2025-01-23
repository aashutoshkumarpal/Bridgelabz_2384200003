using System;

namespace Assignment_No3
{
    class RocketLaunchCountdown2
    {
        public void StartCountdown()
        {
            // Get user input for the countdown start value
            Console.Write("Enter the countdown start value: ");
            int counter = Convert.ToInt32(Console.ReadLine());

            // For loop for countdown
            for (int i = counter; i >= 1; i--)
            {
                Console.WriteLine(i);
            }

            // Print final message when countdown is finished
            Console.WriteLine("Launch!");
        }
    }
}
