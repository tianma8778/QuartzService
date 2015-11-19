using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using Microsoft.Win32;
using LHJ.SYNC.ServiceBase;


namespace LHJ.SYNC.WinService
{
    [RunInstaller(true)]
    public partial class ServiceInstaller : System.Configuration.Install.Installer
    {
        public ServiceInstaller()
        {
            InitializeComponent();
        }

        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);

            RegistryKey system = Registry.LocalMachine.OpenSubKey("System");

            RegistryKey currentControlSet = system.OpenSubKey("CurrentControlSet");

            RegistryKey services = currentControlSet.OpenSubKey("Services");

            this.serviceInstaller1.ServiceName = ServiceMainSettings.GetConfig().ServiceName;
            RegistryKey service = services.OpenSubKey(this.serviceInstaller1.ServiceName, true);

            service.SetValue("Description", this.serviceInstaller1.Description);

            RegistryKey config = service.CreateSubKey("Parameters");
            config.SetValue("Arguments", "service");

            string path = service.GetValue("ImagePath") + " service";
            service.SetValue("ImagePath", path);
        }

        public override void Uninstall(IDictionary savedState)
        {
            try
            {
                RegistryKey system = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("System");
                RegistryKey currentControlSet = system.OpenSubKey("CurrentControlSet");
                RegistryKey services = currentControlSet.OpenSubKey("Services");
                RegistryKey service = services.OpenSubKey(this.serviceInstaller1.ServiceName, true);

                service.DeleteSubKeyTree("Parameters");
            }
            finally
            {
                base.Uninstall(savedState);
            }
        }

        private void serviceInstaller1_AfterInstall(object sender, InstallEventArgs e)
        {

        }
    }
}
