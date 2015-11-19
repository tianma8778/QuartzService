using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHJ.SYNC.ServiceJobs.JobTest
{
    class JobInTest : BaseJob
    {
        //public NotifySender msgSender { get; private set; }


        protected override void InnerExecute(JobExecutionContext context)
        {
            try
            {
                Logger.Info("开始发送OA消息");

                //MessageBox.Show("1");
                Logger.Info("1112212");
                //OATaskProxy proxy = new OATaskProxy();
                //proxy.SendOATask();

                Logger.Info("结束发送OA消息");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message, ex);
            }
        }
    }
}
