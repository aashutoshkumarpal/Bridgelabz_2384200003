using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Platform
{
    abstract class Product
    {
        private int productId;
        private string name;
        private double price;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product(int productId, string name, double price)
        {
           this.productId = productId;
           this.name = name;
           this.price = price;
        }

        public abstract double CalculateDiscount();

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Product ID: {productId}, Name: {name}, Price: {price:C}");
        }
    }

    interface ITaxable
    {
        double CalculateTax();
        string GetTaxDetails();
    
    }

    class Electronics : Product, ITaxable
    {
        public Electronics(int productId, string name, double price) : base(productId, name, price) { }
        
        public override double CalculateDiscount()
        {
            return Price * 0.10;
        }

        public double CalculateTax()
        {
            return Price * 0.18;
        }

        public string GetTaxDetails()
        {
            return "Electronics 18% tax";
        }
    }

    class Clothing : Product, ITaxable
    {
        public Clothing(int productId, string name, double price) : base(productId, name, price) { }

        public override double CalculateDiscount()
        {
            return Price * 0.15;
        }

        public double CalculateTax()
        {
            return Price * 0.05;
        }

        public string GetTaxDetails()
        {
            return "Clothing Tax : 5%";
        }
    }

    class Groceries : Product
    {
        public Groceries(int id, string name, double price) : base(id, name, price) { }

        public override double CalculateDiscount()
        {
            return Price * 0.05; // 5% discount on groceries
        }
    }


}
