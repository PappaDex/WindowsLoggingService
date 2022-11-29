using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Timer_Console;
namespace Zadatak5WindowsService
{
    public partial class Service1 : ServiceBase
    {
      
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Timer_Console.Timer.WriteToFile("-Servis je pokrenut");
            Timer_Console.Timer.ScheduleService();
        }

        protected override void OnStop()
        {
            Timer_Console.Timer.ScheduleService();
        }
    }
}
