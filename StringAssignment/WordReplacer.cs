using System;

namespace StringAssignment
{
    class WordReplacer
    {
        public void InputMethod()
        {
            Console.Write("Enter the sentence: ");
            string? sentence = Console.ReadLine();

            Console.Write("Enter the word to replace: ");
            string? oldWord = Console.ReadLine();

            Console.Write("Enter the new word: ");
            string? newWord = Console.ReadLine();
			
			if(string.IsNullOrWhiteSpace(sentence) || string.IsNullOrWhiteSpace(oldWord) || string.IsNullOrWhiteSpace(newWord))
			{
				Console.WriteLine("No value Provided");
				return;
			}

            string modifiedSentence = ReplaceWord(sentence, oldWord, newWord);

            Console.WriteLine($"Modified Sentence: \"{modifiedSentence}\"");
        }

        static string ReplaceWord(string sentence, string oldWord, string newWord)
        {
            string[] words = sentence.Split(' '); // Split the sentence into words
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == oldWord) // Check for exact match
                {
                    words[i] = newWord; // Replace the word
                }
            }

            return string.Join(" ", words); // Join words back into a sentence
        }
    }
}
