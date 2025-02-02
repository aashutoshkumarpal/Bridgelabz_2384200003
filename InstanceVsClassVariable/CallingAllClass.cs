using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceVsClassVariable
{
    internal class CallingAllClass
    {
        public void CallingProduct()
        {
            // Creating Products
            Product product1 = new Product("Laptop", 1200.99);
            Product product2 = new Product("Smartphone", 799.49);
            Product product3 = new Product("Headphones", 199.99);

            // Display Product Details
            Console.WriteLine("Product 1 Details:");
            product1.DisplayProductDetails();
            Console.WriteLine();

            Console.WriteLine("Product 2 Details:");
            product2.DisplayProductDetails();
            Console.WriteLine();

            Console.WriteLine("Product 3 Details:");
            product3.DisplayProductDetails();
            Console.WriteLine();

            // Display Total Products Created (Class Method)
            Product.DisplayTotalProducts();
        }

        public void CallingCourse()
        {
            // Creating Course Objects
            Course course1 = new Course("Web Development", 12, 599.99);
            Course course2 = new Course("Data Science", 16, 899.99);
            Course course3 = new Course("Machine Learning", 20, 1099.99);

            // Display Course Details
            Console.WriteLine("Course Details Before Updating Institute Name:");
            course1.DisplayCourseDetails();
            course2.DisplayCourseDetails();
            course3.DisplayCourseDetails();

            // Updating Institute Name
            Course.UpdateInstituteName("Tech Academy");

            // Display Course Details After Update
            Console.WriteLine("Course Details After Updating Institute Name:");
            course1.DisplayCourseDetails();
            course2.DisplayCourseDetails();
            course3.DisplayCourseDetails();
        }
        public void CallingVehicle()
        {
            // Creating Vehicle Objects
            Vehicle vehicle1 = new Vehicle("John Doe", "Car");
            Vehicle vehicle2 = new Vehicle("Alice Smith", "Motorcycle");
            Vehicle vehicle3 = new Vehicle("Robert Brown", "Truck");

            // Display Vehicle Details Before Fee Update
            Console.WriteLine("Vehicle Details Before Updating Registration Fee:");
            vehicle1.DisplayVehicleDetails();
            vehicle2.DisplayVehicleDetails();
            vehicle3.DisplayVehicleDetails();

            // Updating Registration Fee
            Vehicle.UpdateRegistrationFee(150.00);

            // Display Vehicle Details After Fee Update
            Console.WriteLine("Vehicle Details After Updating Registration Fee:");
            vehicle1.DisplayVehicleDetails();
            vehicle2.DisplayVehicleDetails();
            vehicle3.DisplayVehicleDetails();
        }
    }
}
