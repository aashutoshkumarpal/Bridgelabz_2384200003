using System;

namespace StringAssignment
{
	class Duplicate
	{
		public void RemoveDuplicate()
		{
			Console.Write("Enter a string: ");
			string? str = Console.ReadLine(); // Allow null
			string str2 = "";

			if (string.IsNullOrEmpty(str))
			{
				Console.WriteLine("No input provided.");
				return;
			}
			str = str.ToLower();
			
			foreach (char c in str)
			{
				bool found = false;
				foreach( char b in str2)
					{
						if(c == b)
						{
							found=true;
							break;
						}
					}
				if(!found)
				{
					str2 += c;
				}
				//if (!str2.Contains(c)) // Fixed syntax error
				//{
				//	str2 += c;
				//}
			}

			Console.WriteLine($"String after removing duplicates: {str2}");
		}
	}
}
