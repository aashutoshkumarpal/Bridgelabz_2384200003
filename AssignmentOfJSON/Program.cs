using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssignmentOfJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new students
            {
                Name = "Aashutosh",
                Age = 23,
                Subjects = new string[] { "hindi", "English", "Maths" }
            };

            string studentJson = JsonConvert.SerializeObject(student);
            Console.WriteLine(studentJson);


            var car = new Car
            {
                Brand = "Toyota",
                Model = "Camry",
                Year = 2021
            };

            string carJson = JsonConvert.SerializeObject(car);
            Console.WriteLine(carJson);

            string jsonFilePath = "C:\\Users\\91870\\source\\repos\\AssignmentOfJSON\\Data.json";
            string jsonContent = File.ReadAllText(jsonFilePath);
            var users = JsonConvert.DeserializeObject<List<User>>(jsonContent);

            foreach (var person in users)
            {
                Console.WriteLine($"Name: {person.Name}, Email: {person.Email}");
            }

            ValidateJson obj = new ValidateJson();
            obj.Validate();

            ReadJson obj2 = new ReadJson();
            obj2.Read();
        }
    }
}
