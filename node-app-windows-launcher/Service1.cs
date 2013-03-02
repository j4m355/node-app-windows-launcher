using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using library;

namespace node_app_windows_launcher
{
    public partial class Service1 : ServiceBase
    {
        public ApplicationService ApplicationService { get; set; }

        public Service1()
        {
            InitializeComponent();
            ApplicationService = new ApplicationService();
            //ApplicationService.Read("applications.json");
        }

        protected override void OnStart(string[] args)
        {
            
            //var applicationService = new ApplicationService();

            ApplicationService.StartApplications("C:\\code\\node-app-windows-launcher\\node-app-windows-launcher\\applications.json");

          /*  _thread = new Thread(new ApplicationService().StartApplications("C:\\code\\node-app-windows-launcher\\node-app-windows-launcher\\applications.json"));
            _thread.Start();
           */
        }

        protected override void OnStop()
        {
            ApplicationService.StopApplications();
        }
    }
}
