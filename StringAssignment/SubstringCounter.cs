using System;

namespace StringAssignment
{
    class SubstringCounter
    {
        public void InputMethod()
        {
            Console.Write("Enter the main string: ");
            string? mainString = Console.ReadLine();

            Console.Write("Enter the substring to count: ");
            string? subString = Console.ReadLine();
			
			if(string.IsNullOrWhiteSpace(mainString) || string.IsNullOrWhiteSpace(subString))
			{
				Console.WriteLine("No value Provided");
				return;
			}

            int count = CountSubstringOccurrences(mainString, subString);

            Console.WriteLine($"The substring '{subString}' appears {count} times in the main string.");
        }

        static int CountSubstringOccurrences(string mainString, string subString)
        {
            if (string.IsNullOrEmpty(mainString) || string.IsNullOrEmpty(subString))
                return 0;

            int count = 0;
            int mainLength = mainString.Length;
            int subLength = subString.Length;

            for (int i = 0; i <= mainLength - subLength; i++)
            {
                bool match = true;

                for (int j = 0; j < subLength; j++)
                {
                    if (mainString[i + j] != subString[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
