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
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            var applicationService = new ApplicationService("applications.json");
            applicationService.Read();
            applicationService.StartApplications();
        }

        protected override void OnStop()
        {
        }
    }
}
