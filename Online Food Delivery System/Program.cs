using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online_Food_Delivery_System
{
    internal class Program
    {
        static void ProcessFoodOrders(List<FoodItem> orders)
        {
            foreach (var item in orders)
            {
                item.GetItemDetails();

                if (item is IDiscountable discountableItem)
                {
                    discountableItem.ApplyDiscount(10); // Applying 10% discount
                    Console.WriteLine($"Final Price after Discount: {item.CalculateTotalPrice():C}\n");
                }
            }
        }

        static void Main()
        {
            List<FoodItem> orders = new List<FoodItem>
        {
            new VegItem("Paneer Butter Masala", 250, 2),
            new NonVegItem("Chicken Biryani", 350, 1)
        };

            ProcessFoodOrders(orders);
        }
    }
}
