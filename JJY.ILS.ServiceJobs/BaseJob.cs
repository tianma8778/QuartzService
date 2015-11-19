using LHJ.SYNC.ServiceBase;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LHJ.SYNC.ServiceJobs
{
    /// <summary>
    /// 后台任务基类
    /// 任务默认只允许运行一个实例
    /// 如果需运行多个实例，需直接继承IInterruptableJob接口，并考虑多实例运行机制
    /// </summary>
    public abstract class BaseJob : IInterruptableJob
    {
        //同步锁
        private static object SYNC_LOCK = new object();

        protected virtual ILogger Logger
        {
            get;
            set;
        }

        public virtual void Interrupt()
        { }

        public virtual void Execute(JobExecutionContext context)
        {
            Logger = new ServiceLogger(context.JobDetail.Name);

            if (Monitor.TryEnter(SYNC_LOCK, 3000) == false)
            {
                Logger.Debug("上一次调度未完成,本次调度放弃运行");
                return;
            }

            try
            {
                Logger.Info("调度开始执行");

                InnerExecute(context);

                Logger.Info("调度正常结束");
            }
            catch (Exception e)
            {
                Logger.Error("调度执行时发生异常: " + e);
            }
            finally
            {
                Monitor.Exit(SYNC_LOCK);
            }
        }

        protected abstract void InnerExecute(JobExecutionContext context);
    }
}
