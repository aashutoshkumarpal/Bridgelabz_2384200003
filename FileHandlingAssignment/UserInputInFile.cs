using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingAssignment
{
    internal class UserInputInFile
    {
        public void InputMethod( string filePath)
        {
            try
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter your age: ");
                int age;
                while (!int.TryParse(Console.ReadLine(), out age) || age <= 0)
                {
                    Console.Write("Error: Please enter a valid positive number for age: ");
                }

                Console.Write("Enter your favorite programming language: ");
                string favoriteLanguage = Console.ReadLine();

                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    writer.WriteLine($" Name : {name}");
                    writer.WriteLine($" Age : {age}");
                    writer.WriteLine($" Favorite Language :{favoriteLanguage}");
                    writer.WriteLine("---------------------------------");
                }


                Console.WriteLine("User data saved successfully!");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while writing to the file: " + ex.Message);
            }
        }
    }
}
