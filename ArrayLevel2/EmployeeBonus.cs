using System;

namespace ArrayLevel2
{
    class EmployeeBonus
    {
        
        public void CalculateBonus()
        {
            // Define arrays for salary, years of service, new salary, and bonus for 10 employees
            double[] oldSalary = new double[10];
            double[] yearsOfService = new double[10];
            double[] bonus = new double[10];
            double[] newSalary = new double[10];

            // Variables to calculate total bonus, total old salary, and total new salary
            double totalBonus = 0;
            double totalOldSalary = 0;
            double totalNewSalary = 0;

            // Loop to take input for 10 employees
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Enter details for Employee {i + 1}:");

                // Input for years of service using Convert.ToDouble()
                while (true)
                {
                    Console.Write("Enter years of service: ");
                    try
                    {
                        yearsOfService[i] = Convert.ToDouble(Console.ReadLine());
                        if (yearsOfService[i] < 0)
                        {
                            Console.WriteLine("Years of service cannot be negative. Please enter a valid value.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for years of service.");
                    }
                }

                // Input for old salary using Convert.ToDouble()
                while (true)
                {
                    Console.Write("Enter old salary: ");
                    try
                    {
                        oldSalary[i] = Convert.ToDouble(Console.ReadLine());
                        if (oldSalary[i] < 0)
                        {
                            Console.WriteLine("Salary cannot be negative. Please enter a valid value.");
                        }
                        else
                        {
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number for salary.");
                    }
                }

                // If the salary or years of service are invalid, decrement the index counter to re-enter data
                if (yearsOfService[i] < 0 || oldSalary[i] < 0)
                {
                    Console.WriteLine("Invalid data entered. Please re-enter the information.");
                    i--;
                    continue;
                }
            }

            // Calculate bonus, new salary, and totals in a loop
            for (int i = 0; i < 10; i++)
            {
                // Bonus Calculation based on years of service
                if (yearsOfService[i] > 5)
                {
                    bonus[i] = oldSalary[i] * 0.05;  // 5% bonus for more than 5 years
                }
                else
                {
                    bonus[i] = oldSalary[i] * 0.02;  // 2% bonus for 5 years or less
                }

                // Calculate new salary
                newSalary[i] = oldSalary[i] + bonus[i];

                // Update total bonus, total old salary, and total new salary
                totalBonus += bonus[i];
                totalOldSalary += oldSalary[i];
                totalNewSalary += newSalary[i];
            }

            // Print the results
            Console.WriteLine("\nTotal Bonus and Salary Information for 10 Employees:");
            Console.WriteLine($"Total Bonus Payout: {totalBonus:C}");
            Console.WriteLine($"Total Old Salary: {totalOldSalary:C}");
            Console.WriteLine($"Total New Salary: {totalNewSalary:C}");
        }
    }
}
