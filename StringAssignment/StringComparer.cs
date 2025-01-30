using System;

namespace StringAssignment
{
    class StringComparer
    {
        public void InputMethod()
        {
            Console.Write("Enter first string: ");
            string? str1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string? str2 = Console.ReadLine();

			if(string.IsNullOrWhiteSpace(str1) || string.IsNullOrWhiteSpace(str2))
			{
				Console.WriteLine("No value Provided");
				return;
			}
			
            int result = CompareStringsLexicographically(str1, str2);

            if (result < 0)
                Console.WriteLine($"\"{str1}\" comes before \"{str2}\" in lexicographical order.");
            else if (result > 0)
                Console.WriteLine($"\"{str1}\" comes after \"{str2}\" in lexicographical order.");
            else
                Console.WriteLine($"\"{str1}\" and \"{str2}\" are equal.");
        }

        static int CompareStringsLexicographically(string str1, string str2)
        {
            int len1 = str1.Length;
            int len2 = str2.Length;
            int minLength = (len1 < len2) ? len1 : len2;

            for (int i = 0; i < minLength; i++)
            {
                if (str1[i] < str2[i])
                    return -1; // str1 comes before str2
                else if (str1[i] > str2[i])
                    return 1; // str1 comes after str2
            }

            // If all compared characters are the same, compare lengths
            if (len1 < len2)
                return -1; // Shorter string comes first
            else if (len1 > len2)
                return 1; // Longer string comes after

            return 0; // Both strings are identical
        }
    }
}
