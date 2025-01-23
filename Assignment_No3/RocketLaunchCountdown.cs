using System;

namespace Assignment_No3
{
    class RocketLaunchCountdown
    {
        public void StartCountdown()
        {
		
			Console.Write("Enter the countdown start value: ");
			int counter = Convert.ToInt32(Console.ReadLine());
			
            // While loop for countdown
            while (counter >= 1)
            {
                Console.WriteLine(counter);
                counter--; 
            }

            // Print final message when countdown is finished
            Console.WriteLine("Launch!");
        }
    }
}
