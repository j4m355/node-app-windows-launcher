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
        }

        protected override void OnStart(string[] args)
        {
            ApplicationService.Read("applications.json");
            ApplicationService.StartApplications();
        }

        protected override void OnStop()
        {
            ApplicationService.StopApplications();
        }
    }
}
