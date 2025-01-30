using System;

namespace StringAssignment
{
    class MostFrequentCharacterFinder
    {
        public void InputMethod()
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            char mostFrequentChar = FindMostFrequentCharacter(inputString);

            Console.WriteLine($"Most Frequent Character: '{mostFrequentChar}'");
        }

        static char FindMostFrequentCharacter(string str)
        {
            if (string.IsNullOrEmpty(str))
                return '\0'; // Return null character if the string is empty

            int[] frequency = new int[256]; // ASCII character frequency array
            int maxCount = 0;
            char mostFrequentChar = '\0';

            foreach (char ch in str)
            {
                frequency[ch]++; // Increment count for the character

                if (frequency[ch] > maxCount)
                {
                    maxCount = frequency[ch];
                    mostFrequentChar = ch;
                }
            }

            return mostFrequentChar;
        }
    }
}
