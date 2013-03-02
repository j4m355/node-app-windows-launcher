using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using library;

namespace ServiceTestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            var applicationService = new ApplicationService();
            
            applicationService.StartApplications(args[0]);
            Console.Read();
            applicationService.StopApplications();
        }
    }
}
