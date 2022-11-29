using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace Zadatak5WindowsService
{
    [RunInstaller(true)]
    public partial class ProjectInstaller : System.Configuration.Install.Installer
    {
        public ProjectInstaller()
        {
            InitializeComponent();
            this.serviceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            //this.serviceProcessInstaller1.Password = null;
            //this.serviceProcessInstaller1.Username = null;
            this.serviceInstaller1.ServiceName = "ServiceLogTest";
            this.serviceInstaller1.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
        }

        private void serviceInstaller1_AfterInstall(object sender, InstallEventArgs e)
        {
            using (System.ServiceProcess.ServiceController serviceController = new
 System.ServiceProcess.ServiceController(serviceInstaller1.ServiceName))
            {
                serviceController.Start();

            }
        }
    }
}
