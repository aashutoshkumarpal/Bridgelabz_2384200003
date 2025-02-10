using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Platform
{
    class Program
    {
        static void CalculateFinalPrice(List<Product> products)
        {
            foreach (var product in products)
            {
                double discount = product.CalculateDiscount();
                double tax = product is ITaxable taxable ? taxable.CalculateTax() : 0;
                double finalPrice = product.Price + tax - discount;

                product.DisplayDetails();
                Console.WriteLine($"Discount: {discount:C}, Tax: {tax:C}, Final Price: {finalPrice:C}");

                if (product is ITaxable taxableProduct)
                {
                    Console.WriteLine(taxableProduct.GetTaxDetails());
                }

                Console.WriteLine();
            }
        }

        static void Main()
        {
            List<Product> products = new List<Product>
        {
            new Electronics(101, "Laptop", 60000),
            new Clothing(102, "T-Shirt", 1200),
            new Groceries(103, "Apples", 500)
        };

            CalculateFinalPrice(products);
        }
    }
}
