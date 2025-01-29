using System;

namespace StringAssignment
{
    class AnagramChecker
    {
        static void InputMethod()
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            bool result = AreAnagrams(str1, str2);

            if (result)
                Console.WriteLine("The strings are anagrams.");
            else
                Console.WriteLine("The strings are NOT anagrams.");
        }

        static bool AreAnagrams(string str1, string str2)
        {
            if (str1.Length != str2.Length)
                return false; // Different lengths, not anagrams

            int[] charCounts = new int[256]; // ASCII character frequency array

            // Count frequency of each character in the first string
            foreach (char ch in str1)
                charCounts[ch]++;

            // Decrease frequency for characters in the second string
            foreach (char ch in str2)
            {
                charCounts[ch]--;
                if (charCounts[ch] < 0)
                    return false; // If any count goes negative, not an anagram
            }

            return true; // If all character counts match, it's an anagram
        }
    }
}
