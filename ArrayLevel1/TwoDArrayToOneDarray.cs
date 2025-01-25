using System;
namespace ArrayLevel1
{
    class TwoDArrayToOneDarray
    {
        
        public void CreateAndCopyArray()
        {
            // Take user input for the number of rows and columns
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            // Create a 2D array (matrix) with user-specified dimensions
            int[,] matrix = new int[rows, columns];

            // Take user input for each element in the 2D array
            Console.WriteLine("Enter the elements of the matrix:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Element at [{i}, {j}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Create a 1D array of size rows * columns
            int[] singleDimArray = new int[rows * columns];

            // Define an index variable to store the position in the 1D array
            int index = 0;

            // Loop through the 2D array and copy each element to the 1D array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    singleDimArray[index] = matrix[i, j];
                    index++;
                }
            }

            // Display the 1D array after copying
            Console.WriteLine("The elements of the 1D array:");
            foreach (int value in singleDimArray)
            {
                Console.Write(value + " ");
            }
        }
    }
}
