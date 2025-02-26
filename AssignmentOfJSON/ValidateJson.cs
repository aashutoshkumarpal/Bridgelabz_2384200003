using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json;

namespace AssignmentOfJSON
{
    internal class ValidateJson
    {
        public void Validate() {

            string json = "{ \"name\": \"Alice\", \"age\": 30 }";
            string schemaJson = @"{
            'type': 'object',
            'properties': {
                'name': { 'type': 'string' },
                'age': { 'type': 'integer' }
            },
            'required': ['name', 'age']
        }";

            JSchema schema = JSchema.Parse(schemaJson);
            JObject obj = JObject.Parse(json);

            bool isValid = obj.IsValid(schema, out IList<string> errors);
            Console.WriteLine($"Is JSON Valid: {isValid}");

            if (!isValid)
            {
                Console.WriteLine("Errors: " + string.Join(", ", errors));
            }
        }
    }
}
