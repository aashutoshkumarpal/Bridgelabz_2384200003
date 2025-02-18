using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
    // Step 1: Define an Interface for Meal Plans
    interface IMealPlan
    {
        string GetMealDetails();
    }

    // Step 2: Implement Different Meal Plan Types
    class VegetarianMeal : IMealPlan
    {
        public string GetMealDetails()
        {
            return "Vegetarian Meal: Grilled Vegetables, Lentil Soup, Brown Rice";
        }
    }

    class VeganMeal : IMealPlan
    {
        public string GetMealDetails()
        {
            return "Vegan Meal: Quinoa Salad, Avocado Toast, Almond Milk Smoothie";
        }
    }

    class KetoMeal : IMealPlan
    {
        public string GetMealDetails()
        {
            return "Keto Meal: Grilled Chicken, Avocado, Cheese, Nuts";
        }
    }

    class HighProteinMeal : IMealPlan
    {
        public string GetMealDetails()
        {
            return "High-Protein Meal: Egg Whites, Grilled Salmon, Greek Yogurt";
        }
    }

    // Step 3: Generic Class to Manage Meals
    class Meal<T> where T : IMealPlan, new()
    {
        private List<T> mealList = new List<T>();

        // Generic Method to Add a Meal
        public void AddMeal(T meal)
        {
            mealList.Add(meal);
        }

        // Generic Method to Display Meals
        public void DisplayMeals()
        {
            foreach (var meal in mealList)
            {
                Console.WriteLine(meal.GetMealDetails());
            }
        }

        // Generic Method to Validate and Generate Meal Plan
        public static T GenerateMealPlan()
        {
            return new T(); // Correctly instantiate the meal type
        }
    }

    // Step 4: Main Program to Run Meal Plan Generator
    class Program6
    {
        static void Main()
        {
            // Vegetarian Meal Plan
            Meal<VegetarianMeal> vegetarianPlan = new Meal<VegetarianMeal>();
            vegetarianPlan.AddMeal(new VegetarianMeal());

            // Vegan Meal Plan
            Meal<VeganMeal> veganPlan = new Meal<VeganMeal>();
            veganPlan.AddMeal(new VeganMeal());

            // Keto Meal Plan
            Meal<KetoMeal> ketoPlan = new Meal<KetoMeal>();
            ketoPlan.AddMeal(new KetoMeal());

            // High-Protein Meal Plan
            Meal<HighProteinMeal> highProteinPlan = new Meal<HighProteinMeal>();
            highProteinPlan.AddMeal(new HighProteinMeal());

            // Display Meals
            Console.WriteLine("Vegetarian Meal Plan:");
            vegetarianPlan.DisplayMeals();

            Console.WriteLine("\nVegan Meal Plan:");
            veganPlan.DisplayMeals();

            Console.WriteLine("\nKeto Meal Plan:");
            ketoPlan.DisplayMeals();

            Console.WriteLine("\nHigh-Protein Meal Plan:");
            highProteinPlan.DisplayMeals();

            // Generating a New Meal Plan Dynamically (No errors now)
            Console.WriteLine("\nGenerating a New Keto Meal Plan:");
            var newKetoMeal = Meal<KetoMeal>.GenerateMealPlan();
            Console.WriteLine(newKetoMeal.GetMealDetails());
        }
    }
}