using System;

namespace ArrayLevel1
{
	class FootballPayerMeanHeight
	{
		public void CalculateMean(){
			// Define array to store height of players
			double[] heights = new double[11];
			double total =0.0;
			double mean=0.0;
		
			//take user input of height
			for(int i=0; i<11; i++)
			{
				Console.WriteLine($"Enter the height of player{i+1}");
				heights[i]=Convert.ToInt32(Console.ReadLine());
			}
			
			//Calculating Sum of heights
			for(int i=0; i<11; i++)
			{
				total+=heights[i];
			}
		
			mean = total / 11;
		
			Console.WriteLine($"the mean height of the football team {mean}");
		}
	}
}