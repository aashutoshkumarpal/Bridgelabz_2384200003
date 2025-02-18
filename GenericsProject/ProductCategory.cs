using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
    // Abstract category class for products
    public abstract class ProductCategory { }

    public class BookCategory : ProductCategory { }
    public class ClothingCategory : ProductCategory { }

    // Generic Product class restricted to specific categories
    public class Product<T> where T : ProductCategory
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public T Category { get; set; }

        public Product(string name, double price, T category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: ${Price}, Category: {Category.GetType().Name}");
        }
    }

    // Generic method to apply discount
    public class Marketplace
    {
        public static void ApplyDiscount<T>(Product<T> product, double percentage) where T : ProductCategory
        {
            product.Price -= product.Price * (percentage / 100);
            Console.WriteLine($"Discount applied! New Price of {product.Name}: ${product.Price}");
        }
    }


    // Main method for testing
    class Program3
    {
        static void Main()
        {
            Product<BookCategory> book = new Product<BookCategory>("C# Programming", 50, new BookCategory());
            Product<ClothingCategory> shirt = new Product<ClothingCategory>("T-Shirt", 20, new ClothingCategory());

            Console.WriteLine("--- Product Catalog ---");
            book.DisplayInfo();
            shirt.DisplayInfo();

            Console.WriteLine("\n--- Applying Discounts ---");
            Marketplace.ApplyDiscount(book, 10);
            Marketplace.ApplyDiscount(shirt, 15);
        }
    }
}
