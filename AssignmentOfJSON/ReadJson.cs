using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json.Linq;


namespace AssignmentOfJSON
{
    public class ReadJson
    {
        public void Read()
        {

            string jsonFilePath = "C:\\Users\\91870\\source\\repos\\AssignmentOfJSON\\Data.json";

            string json = File.ReadAllText("data.json");
            using JsonDocument doc = JsonDocument.Parse(json);

            foreach (var property in doc.RootElement.EnumerateObject())
            {
                Console.WriteLine($"{property.Name}: {property.Value}");
            }
        }
    }
    }
}
