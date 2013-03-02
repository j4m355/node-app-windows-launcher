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
    public partial class NodeAppLaunchService : ServiceBase
    {
        public ApplicationService ApplicationService { get; set; }

        public NodeAppLaunchService()
        {
            InitializeComponent();
            ApplicationService = new ApplicationService();
           
        }

        protected override void OnStart(string[] args)
        {
           // "C:\\code\\node-app-windows-launcher\\node-app-windows-launcher\\applications.json"
            
            //doesnt work:
            //if (args[0] == null || string.IsNullOrEmpty(args[0]) || args == null) throw new Exception("Pass in path to applications.json");

            ApplicationService.StartApplications(args[0]);
        }

        protected override void OnStop()
        {
            ApplicationService.StopApplications();
        } 
    }
}
