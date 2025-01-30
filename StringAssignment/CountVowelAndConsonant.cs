using System;

namespace StringAssignment
{
	class CountVowelAndConsonant
	{
		public void Count()
		{
			int count = 0;

			Console.Write("Enter a string: ");
			string? str = Console.ReadLine(); // Allow null

			if (string.IsNullOrEmpty(str))
			{
				Console.WriteLine("No input provided.");
				return;
			}

			string vowels = "AEIOUaeiou";

			foreach (char c in str)
			{
				
					foreach( char b in vowels)
					{
						if(c == b) count++ ;
					}
					//if (vowels.Contains(c))
					//	count++;
				
			}

			int consonantCount = str.Count(char.IsLetter) - count;

			Console.WriteLine($"Total vowels in \"{str}\" is {count} and consonants is {consonantCount}");
		}
	}
}
