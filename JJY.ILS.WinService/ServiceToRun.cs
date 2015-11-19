using LHJ.SYNC.ServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHJ.SYNC.WinService
{
    static class ServiceToRun
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {

            System.ServiceProcess.ServiceBase[] ServicesToRun;
            //Thread.Sleep(10000); //调试服务用
            ServiceEntryType entryType = ServiceEntryType.Application;
            if (args.Length > 0 && args[0].Equals("SERVICE", StringComparison.OrdinalIgnoreCase))
            {
                entryType = ServiceEntryType.Service;
            }
            MainService.Instance = new MainService();
            switch (entryType)
            {
                case ServiceEntryType.Application:
                    MainService.Instance.args = args;
                    MainService.Instance.EntryType = ServiceEntryType.Application;

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm(MainService.Instance));
                    //Application.Run(new DebugForm());
                    break;
                case ServiceEntryType.Service:
                    MainService.Instance.EntryType = ServiceEntryType.Service;
                    ServicesToRun = new System.ServiceProcess.ServiceBase[] { MainService.Instance };

                    System.ServiceProcess.ServiceBase.Run(ServicesToRun);
                    break;
                default:
                    break;
            }
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MainForm());
        }
    }
}
