using System;
using System.Collections.Generic;

namespace ObjectModeling
{
    public class Product
    {
        public string ProductName { get; }
        public decimal Price { get; }

        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"   Product: {ProductName}, Price: ${Price:F2}");
        }
    }

    public class Order
    {
        public int OrderID { get; }
        public Customer Customer { get; }
        private List<Product> products;
        private static int orderCounter = 1;

        public Order(Customer customer)
        {
            OrderID = orderCounter++;
            Customer = customer;
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"\nOrder ID: {OrderID}, Customer: {Customer.Name}");
            if (products.Count == 0)
            {
                Console.WriteLine("   No products in this order.");
            }
            else
            {
                foreach (var product in products)
                {
                    product.DisplayProduct();
                }
            }
        }
    }

    public class Customer
    {
        public string Name { get; }
        private List<Order> orders;

        public Customer(string name)
        {
            Name = name;
            orders = new List<Order>();
        }

        public void PlaceOrder(Order order)
        {
            orders.Add(order);
        }

        public void DisplayOrders()
        {
            Console.WriteLine($"\nCustomer: {Name}");
            if (orders.Count == 0)
            {
                Console.WriteLine("   No orders placed.");
            }
            else
            {
                foreach (var order in orders)
                {
                    order.DisplayOrder();
                }
            }
        }
    }

    public class ECommercePlatform
    {
        private List<Customer> customers;
        private List<Product> products;

        public ECommercePlatform()
        {
            customers = new List<Customer>();
            products = new List<Product>();
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DisplayPlatformData()
        {
            Console.WriteLine("\nE-Commerce Platform Data");

            Console.WriteLine("\nAvailable Products:");
            if (products.Count == 0)
            {
                Console.WriteLine("   No products available.");
            }
            else
            {
                foreach (var product in products)
                {
                    product.DisplayProduct();
                }
            }

            Console.WriteLine("\nCustomers and Their Orders:");
            if (customers.Count == 0)
            {
                Console.WriteLine("   No customers registered.");
            }
            else
            {
                foreach (var customer in customers)
                {
                    customer.DisplayOrders();
                }
            }
        }
    }

    public class ECommerceDemo
    {
        public void InputMethod()
        {
            // Creating e-commerce platform
            ECommercePlatform platform = new ECommercePlatform();

            // Creating products
            Product laptop = new Product("Laptop", 1200.99m);
            Product smartphone = new Product("Smartphone", 799.49m);
            Product headphones = new Product("Headphones", 149.99m);

            // Adding products to platform
            platform.AddProduct(laptop);
            platform.AddProduct(smartphone);
            platform.AddProduct(headphones);

            // Creating customers
            Customer alice = new Customer("Alice");
            Customer bob = new Customer("Bob");

            // Adding customers to platform
            platform.AddCustomer(alice);
            platform.AddCustomer(bob);

            // Alice places an order
            Order order1 = new Order(alice);
            order1.AddProduct(laptop);
            order1.AddProduct(headphones);
            alice.PlaceOrder(order1);

            // Bob places an order
            Order order2 = new Order(bob);
            order2.AddProduct(smartphone);
            bob.PlaceOrder(order2);

            // Displaying e-commerce platform data
            platform.DisplayPlatformData();
        }
    }
}
