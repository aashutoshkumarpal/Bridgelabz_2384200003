using System;

namespace ArrayLevel1
{
	class VoteValidity{
	
		public void CheckVoteValidity()
		{		
			// initialising Array with size 10 
			int[] students = new int[10];
			
			// taking input in Array
			Console.WriteLine("Enter the Age of 10 students");
			for(int i = 0; i< students.Length; i++)
			{
				students[i]= Convert.ToInt32(Console.ReadLine());
			}
			
			
			for(int i = 0 ; i<students.Length ;i++)
			{
				// Checking Age is Positive or not 
				if(students[i] < 0)
				{
					Console.WriteLine("Invalid Age");
				}else if(students[i] > 18)
				{
					Console.WriteLine($"The student with the age {students[i]} can vote");
				}else
				{
					Console.WriteLine($"The student with the age {students[i]} cannot vote");
				}
			}
		}	
	}
}