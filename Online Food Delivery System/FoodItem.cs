using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_System
{
    // Abstract class FoodItem
    abstract class FoodItem
    {
        private string itemName;
        protected double price;
        protected int quantity;

        public string ItemName
        {
            get { return itemName; }
            private set { itemName = value; }
        }

        public double Price
        {
            get { return price; }
            protected set { price = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            protected set { quantity = value; }
        }

        public FoodItem(string itemName, double price, int quantity)
        {
            this.itemName = itemName;
            this.price = price;
            this.quantity = quantity;
        }

        public abstract double CalculateTotalPrice(); // Abstract method

        public virtual void GetItemDetails()
        {
            Console.WriteLine($"Item: {itemName}, Price: {price:C}, Quantity: {quantity}, Total Price: {CalculateTotalPrice():C}");
        }
    }

    // Interface IDiscountable
    interface IDiscountable
    {
        void ApplyDiscount(double percentage);
        double GetDiscountDetails();
    }

    // VegItem subclass (No additional charges)
    class VegItem : FoodItem, IDiscountable
    {
        private double discount = 0;

        public VegItem(string itemName, double price, int quantity)
            : base(itemName, price, quantity) { }

        public override double CalculateTotalPrice()
        {
            return (price * quantity) - discount;
        }

        public void ApplyDiscount(double percentage)
        {
            discount = (price * quantity) * (percentage / 100);
            Console.WriteLine($"Discount of {percentage}% applied on {ItemName}. Discount Amount: {discount:C}");
        }

        public double GetDiscountDetails()
        {
            return discount;
        }
    }

    // NonVegItem subclass (Includes 10% additional charge)
    class NonVegItem : FoodItem, IDiscountable
    {
        private double additionalCharge = 0;
        private double discount = 0;

        public NonVegItem(string itemName, double price, int quantity)
            : base(itemName, price, quantity)
        {
            additionalCharge = (price * quantity) * 0.10; // 10% extra charge for non-veg items
        }

        public override double CalculateTotalPrice()
        {
            return (price * quantity) + additionalCharge - discount;
        }

        public void ApplyDiscount(double percentage)
        {
            discount = ((price * quantity) + additionalCharge) * (percentage / 100);
            Console.WriteLine($"Discount of {percentage}% applied on {ItemName}. Discount Amount: {discount:C}");
        }

        public double GetDiscountDetails()
        {
            return discount;
        }
    }
}
