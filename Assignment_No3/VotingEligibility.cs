using System;

namespace Assignment_No3
{
    class VotingEligibility
    {
        public void CheckVotingEligibility()
        {
            // Input the age
            Console.Write("Enter the person's age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            // Check voting eligibility
            if (age >= 18)
            {
                // If age is 18 or older
                Console.WriteLine($"The person's age is {age} and can vote.");
            }
            else
            {
                // If age is less than 18
                Console.WriteLine($"The person's age is {age} and cannot vote.");
            }
        }
    }
}
