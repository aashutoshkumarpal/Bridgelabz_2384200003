using System;

namespace Assignment_No3Level2
{
    class FriendsComparison
    {
        public void FindYoungestAndTallest()
        {
            // input for ages
            Console.Write("Enter Amar's age: ");
            int amarAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Akbar's age: ");
            int akbarAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Anthony's age: ");
            int anthonyAge = Convert.ToInt32(Console.ReadLine());

            // input for heights
            Console.Write("Enter Amar's height (in cm): ");
            int amarHeight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Akbar's height (in cm): ");
            int akbarHeight = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Anthony's height (in cm): ");
            int anthonyHeight = Convert.ToInt32(Console.ReadLine());

            // Determine the youngest friend
            if (amarAge < akbarAge && amarAge < anthonyAge)
            {
                Console.WriteLine("The youngest friend is Amar.");
            }
            else if (akbarAge < amarAge && akbarAge < anthonyAge)
            {
                Console.WriteLine("The youngest friend is Akbar.");
            }
            else if (anthonyAge < amarAge && anthonyAge < akbarAge)
            {
                Console.WriteLine("The youngest friend is Anthony.");
            }
            else
            {
                Console.WriteLine("Two or more friends are of the same youngest age.");
            }

            // Determine the tallest friend
            if (amarHeight > akbarHeight && amarHeight > anthonyHeight)
            {
                Console.WriteLine("The tallest friend is Amar.");
            }
            else if (akbarHeight > amarHeight && akbarHeight > anthonyHeight)
            {
                Console.WriteLine("The tallest friend is Akbar.");
            }
            else if (anthonyHeight > amarHeight && anthonyHeight > akbarHeight)
            {
                Console.WriteLine("The tallest friend is Anthony.");
            }
            else
            {
                Console.WriteLine("Two or more friends are of the same tallest height.");
            }
        }
    }
}
