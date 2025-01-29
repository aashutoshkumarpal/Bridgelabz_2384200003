using System;

namespace StringAssignment
{
    class ToggleCaseProgram
    {
        public void InputMethod()
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            string toggledString = ToggleCase(inputString);

            Console.WriteLine("Toggled Case String: " + toggledString);
        }

        static string ToggleCase(string str)
        {
            char[] toggledChars = new char[str.Length];

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];

                if (ch >= 'A' && ch <= 'Z')  // Uppercase to Lowercase
                {
                    toggledChars[i] = (char)(ch + 32);
                }
                else if (ch >= 'a' && ch <= 'z')  // Lowercase to Uppercase
                {
                    toggledChars[i] = (char)(ch - 32);
                }
                else  // Non-alphabet characters remain unchanged
                {
                    toggledChars[i] = ch;
                }
            }

            return new string(toggledChars);
        }

        static void Main()
        {
            InputMethod();
        }
    }
}
