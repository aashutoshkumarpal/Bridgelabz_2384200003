using System;

namespace StringAssignment
{
    class RemoveCharacterProgram
    {
        public void InputMethod()
        {
            Console.Write("Enter a string: ");
            string? inputString = Console.ReadLine();
			
			if(string.IsNullOrWhiteSpace(inputString) )
			{
				Console.WriteLine("No value Provided");
				return;
			}
			
            Console.Write("Enter the character to remove: ");
            char charToRemove = Console.ReadKey().KeyChar;
            Console.WriteLine(); // Move to the next line after character input

            string modifiedString = RemoveCharacter(inputString, charToRemove);

            Console.WriteLine($"Modified String: \"{modifiedString}\"");
        }

        static string RemoveCharacter(string str, char ch)
        {
            char[] resultArray = new char[str.Length];
            int index = 0;

            foreach (char currentChar in str)
            {
                if (currentChar != ch)
                {
                    resultArray[index] = currentChar;
                    index++;
                }
			}
			
			return resultArray.ToString();
		}
	}
}

    
