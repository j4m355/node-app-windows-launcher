using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceProcess;

namespace library
{
    public class ServiceService
    {
        private string ServiceName { get; set; }
        public ServiceController Service { get; set; }

        public ServiceService(string serviceName)
        {
            ServiceName = serviceName;
            Service = new ServiceController(ServiceName);
        }

        public void StartService(int timeoutMilliseconds)
        {
            try
            {
                var timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                Service.Start();
                Service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void StopService(int timeoutMilliseconds)
        {
            try
            {
                var timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                Service.Stop();
                Service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void RestartService(int timeoutMilliseconds)
        {
 
            try
            {
                var millisec1 = Environment.TickCount;
                var timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                Service.Stop();
                Service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                // count the rest of the timeout
                var millisec2 = Environment.TickCount;
                timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));

                Service.Start();
                Service.WaitForStatus(ServiceControllerStatus.Running, timeout);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
