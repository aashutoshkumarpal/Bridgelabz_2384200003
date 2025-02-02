using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVsClassVariable
{
    internal class Product
    {
        // Instance Variables
        public string ProductName { get; set; }
        public double Price { get; set; }

        // Class Variable (Shared among all products)
        private static int totalProducts = 0;

        // Constructor to Initialize Product
        public Product(string productName, double price)
        {
            ProductName = productName;
            Price = price;
            totalProducts++; // Increment total products when a new product is created
        }

        // Instance Method to Display Product Details
        public void DisplayProductDetails()
        {
            Console.WriteLine($"Product Name: {ProductName}");
            Console.WriteLine($"Price: Rs {Price:F2}");
        }

        // Class Method to Display Total Products Created
        public static void DisplayTotalProducts()
        {
            Console.WriteLine($"Total Products Created: {totalProducts}");
        }
    }
}
