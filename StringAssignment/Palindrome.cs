using System;

namespace StringAssignment
{
	class Palindrome
	{
		public void checkPalindrome()
		{
			Console.Write("Enter a string: ");
			string? str = Console.ReadLine(); // Allow null
			string str2 ="";
			if (string.IsNullOrEmpty(str))
			{
				Console.WriteLine("No input provided.");
				return;
			}

			for(int i = str.Length-1 ; i >= 0 ; i-- )
			{
				str2+=str[i];
			}
			
			if(str == str2 )
			{
				Console.WriteLine($" the reverse of {str} is {str2} and it is Palindrome");
			}
			else
			{
				Console.WriteLine($" the reverse of {str} is {str2} and it is not Palindrome");
			}
		}
	}
}
