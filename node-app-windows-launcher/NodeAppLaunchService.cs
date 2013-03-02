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
            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            ApplicationService.StartApplications(appDataPath + "\\Node-App-Windows-Launcher\\applications.json");
        }

        protected override void OnStop()
        {
            ApplicationService.StopApplications();
        } 
    }
}
