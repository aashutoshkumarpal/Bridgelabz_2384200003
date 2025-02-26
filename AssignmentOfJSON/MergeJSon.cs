using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AssignmentOfJSON
{
    internal class MergeJSon
    {
        public void Merge()
        {
            string json1 = "{ \"name\": \"Alice\", \"age\": 30 }";
            string json2 = "{ \"email\": \"alice@example.com\", \"city\": \"New York\" }";

            JObject obj1 = JObject.Parse(json1);
            JObject obj2 = JObject.Parse(json2);

            obj1.Merge(obj2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });

            Console.WriteLine(obj1.ToString(Formatting.Indented));
        }
    }
}
