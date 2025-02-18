using System;
using System.Collections.Generic;


namespace GenericsProject
{
    // Abstract base class for warehouse items
    public abstract class WarehouseItem
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public WarehouseItem(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public abstract void DisplayInfo();
    }

    // Derived classes for specific item types
    public class Electronics : WarehouseItem
    {
        public string Brand { get; set; }

        public Electronics(string name, double price, string brand) : base(name, price)
        {
            Brand = brand;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Electronics: {Name}, Brand: {Brand}, Price: ${Price}");
        }
    }

    public class Groceries : WarehouseItem
    {
        public string ExpiryDate { get; set; }

        public Groceries(string name, double price, string expiryDate) : base(name, price)
        {
            ExpiryDate = expiryDate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Grocery: {Name}, Expiry Date: {ExpiryDate}, Price: ${Price}");
        }
    }

    public class Furniture : WarehouseItem
    {
        public string Material { get; set; }

        public Furniture(string name, double price, string material) : base(name, price)
        {
            Material = material;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Furniture: {Name}, Material: {Material}, Price: ${Price}");
        }
    }

    // Generic class with constraints for storing warehouse items
    public class Storage<T> where T : WarehouseItem
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void DisplayItems()
        {
            foreach (var item in items)
            {
                item.DisplayInfo();
            }
        }
    }

    // Main method for testing
    class Program1
    {
        static void Main()
        {
            Storage<Electronics> electronicsStorage = new Storage<Electronics>();
            electronicsStorage.AddItem(new Electronics("Laptop", 1200, "Dell"));
            electronicsStorage.AddItem(new Electronics("Smartphone", 800, "Samsung"));

            Storage<Groceries> groceriesStorage = new Storage<Groceries>();
            groceriesStorage.AddItem(new Groceries("Milk", 3.5, "2025-02-28"));
            groceriesStorage.AddItem(new Groceries("Bread", 2.0, "2025-02-20"));

            Storage<Furniture> furnitureStorage = new Storage<Furniture>();
            furnitureStorage.AddItem(new Furniture("Chair", 150, "Wood"));
            furnitureStorage.AddItem(new Furniture("Table", 300, "Metal"));

            Console.WriteLine("--- Electronics Storage ---");
            electronicsStorage.DisplayItems();

            Console.WriteLine("\n--- Groceries Storage ---");
            groceriesStorage.DisplayItems();

            Console.WriteLine("\n--- Furniture Storage ---");
            furnitureStorage.DisplayItems();
        }
    }
}