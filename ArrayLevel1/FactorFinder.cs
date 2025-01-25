using System;

namespace ArrayLevel1
{
    class FactorFinder
    {
        public void FindFactors()
        {
			// Take the number which we want factors
			Console.WriteLine("Enter the number");
			int number =Convert.ToInt32(Console.ReadLine());
			
            int maxFactor = 10;
			//initialise array 
            int[] factors = new int[maxFactor];
            int index = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    if (index == maxFactor)
                    {
                        maxFactor *= 2;
                        int[] temp = new int[maxFactor];
                        factors.CopyTo(temp, 0);     // Copy elements from factors to temp starting at index 0
                        factors = temp;
                    }
                    factors[index] = i;
                    index++;
                }
            }

            for (int i = 0; i < factors.Length && factors[i] != 0; i++)
            {
                Console.Write(factors[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
