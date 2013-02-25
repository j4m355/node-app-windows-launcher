using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace library
{
    public class ApplicationService
    {
        public string JsonPath { get; set; }
        public List<Application> Applications { get; set; }
 
        public ApplicationService(string jsonPath)
        {
            JsonPath = jsonPath;
        }

        public void Read()
        {
            var StreamReader = new StreamReader(JsonPath);
            var output = StreamReader.ReadToEnd();
            StreamReader.Close();

            var egg = JsonConvert.DeserializeObject<List<Application>>(output);

        }

        public void StartApplications()
        {
           /* foreach (var application in Applications)
            {
                
            }*/
        }
    }
}
