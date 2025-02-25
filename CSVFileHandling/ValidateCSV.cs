using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSVFileHandling
{
    internal class ValidateCSV
    {
        // Specify the path to your CSV file
        string file = @"C:\Users\91870\Desktop\contacts.csv";

        public void ValidateData()
        {
            try
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    // Read the header line
                    string headerLine = reader.ReadLine();
                    Console.WriteLine("Validating data...");

                    // Loop through each line in the CSV file
                    int lineNumber = 1; // To keep track of line numbers
                    while (!reader.EndOfStream)
                    {
                        lineNumber++;
                        // Read the next line
                        string line = reader.ReadLine();

                        // Split the line into columns
                        string[] columns = line.Split(',');

                        // Validate Email
                        string email = columns[2];
                        if (!IsValidEmail(email))
                        {
                            Console.WriteLine($"Invalid Email at line {lineNumber}: {email}");
                        }

                        // Validate Phone Number
                        string phone = columns[3];
                        if (!IsValidPhoneNumber(phone))
                        {
                            Console.WriteLine($"Invalid Phone Number at line {lineNumber}: {phone}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        // Method to validate email format
        private bool IsValidEmail(string email)
        {
            // Regular expression for validating an email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        // Method to validate phone number format
        private bool IsValidPhoneNumber(string phone)
        {
            // Check if the phone number contains exactly 10 digits
            return Regex.IsMatch(phone, @"^\d{10}$");
        }

    }
}
