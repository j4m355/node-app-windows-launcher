using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace library
{
    public class ApplicationService
    {
        public string JsonPath { get; set; }
        public Model Applications { get; set; }
        private List<int> Pids { get; set; } 

        public ApplicationService()
        {
            Pids = new List<int>();
        }

        public void Read(string applicationJsonPath)
        {
            JsonPath = applicationJsonPath;
            Read();
        }

        private void Read()
        {
            var streamReader = new StreamReader(JsonPath);
            var output = streamReader.ReadToEnd();
            streamReader.Close();
            Applications = JsonConvert.DeserializeObject<Model>(output);
        }

        public void StartApplications(string jsonPath)
        {
            JsonPath = jsonPath;
            Read();

            foreach (var a in Applications.Application)
            {
                var aCopy = a;
                Task.Factory.StartNew(() => Execute(aCopy.Command, aCopy.Path, aCopy.Parameters));
                
            }
           
        }

        public void StopApplications()
        {
            foreach (var process in Pids.Select(Process.GetProcessById))
            {
                process.Kill();
            }
        }

        private void Execute(string command, string path, string parameters)
        {
            var process = new Process();
            var startInfo = new ProcessStartInfo
                                {
                                    WindowStyle = ProcessWindowStyle.Hidden,
                                    WorkingDirectory = path,
                                    FileName = command,
                                    Arguments = parameters
                                };
            process.StartInfo = startInfo;
            process.Start();
            Pids.Add(process.Id);
            process.WaitForExit(Int32.MaxValue);
        }

    }
}
