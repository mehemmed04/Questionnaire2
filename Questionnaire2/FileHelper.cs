using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questionnaire2
{
    public class FileHelper
    {
        public static void WriteToJson(List<Customer> customerList,string filename)
        {
            var serializer = new JsonSerializer();

            using (var sw = new StreamWriter( $"{filename}.json"))
            {

                using (var jw = new JsonTextWriter(sw))
                {
                    jw.Formatting = Formatting.Indented;
                    serializer.Serialize(jw, customerList);
                }
            }
        }

        public static List<Customer> ReadFromJson( string filename)
        {
            List<Customer> resultDatabase = null;
            var serializer = new JsonSerializer();
            using (var sr = new StreamReader($"{filename}.json"))
            {
                using (var jr = new JsonTextReader(sr))
                {
                    resultDatabase = serializer.Deserialize<List<Customer>>(jr);
                }
            }
            return resultDatabase;
        }
    }
}
