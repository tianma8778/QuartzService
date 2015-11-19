using LHJ.SYNC.Configuration;
using LHJ.SYNC.ServiceBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LHJ.SYNC.WinService
{
    public partial class MainForm : Form
    {
        private MainService mainService;

        //左侧目录树中的两个重要节点
        private TreeNode m_TnSummary, m_TnConfig;

        //服务控制对象
        private ServiceController m_ServiceController;
        private ScheduleConfig m_Config;

        private ILogger logger = new ServiceLogger(typeof(MainForm).Name);


        internal MainForm(MainService serviceMain)
        {
            InitializeComponent();

            Application.ThreadException += Application_ThreadException;

            this.mainService = serviceMain;
            this.mainService.CreateJobEvent += OnCreateJobEvent;


            //检测服务安装情况
            if (CheckServiceController())
            {
                if (this.m_ServiceController.Status == ServiceControllerStatus.Stopped)
                {
                    this.btnStartService.Enabled = true;
                    this.toolStripBtnStart.Enabled = true;

                    this.btnStopService.Enabled = false;
                    this.toolStripBtnStop.Enabled = false;
                }
                else
                {
                    this.btnStartService.Enabled = false;
                    this.btnStopService.Enabled = true;
                    this.toolStripBtnStart.Enabled = false;

                    this.toolStripBtnStop.Enabled = true;
                }

            }

            //装入配置文件
            LoadConfigFile();

            //初始化左侧目录树
            InitTreeView();

            InitControlState();

        }

        private void InitControlState()
        {

        }

        #region 控件事件

        /// <summary>
        /// 点击左侧目录树中项目后，切换右侧的面板和内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvLeft_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == m_TnSummary || e.Node == m_TnConfig)
            {
                pnlSummary.Visible = true;
                pnlConfig.Visible = false;

                if (tabControl1.TabPages.Contains(tabPage2))
                    tabControl1.TabPages.Remove(tabPage2);  //隐藏“扩展配置”项

                if (tabControl1.TabPages.Contains(tabPage3))
                    tabControl1.TabPages.Remove(tabPage3);

                this.ShowConfigSummary();
            }
            else
            {
                ScheduleItem item = this.m_Config.GetItemByTitle(e.Node.Text);
                if (item != null)
                {
                    pnlSummary.Visible = false;
                    pnlConfig.Visible = true;

                    if (tabControl1.TabPages.Contains(tabPage2) == false)
                        tabControl1.TabPages.Add(tabPage2);  //显示“扩展配置”项

                    if (tabControl1.TabPages.Contains(tabPage3) == false)
                        tabControl1.TabPages.Add(tabPage3);  //显示测试工具项

                    this.FillConfigPanel(item);
                }
            }
        }

        /// <summary>
        /// 在配置信息编辑区中，点击‘无限运行’复选框后，禁用或启用前面的文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            pnlEditBox.Enabled = chkActive.Checked;
        }

        /// <summary>
        /// 点击保存编辑结果的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveChange_Click(object sender, EventArgs e)
        {
            ScheduleItem item = this.m_Config.GetItemByTitle(txtTitle.Text);

            if (item == null)
            {
                logger.Debug("程序错误，查找配置项失败");
                MessageBox.Show(@"程序错误，查找配置项失败");
                return;
            }
            if (item.IsSimple)
            {
                item.RepeatInterval = (txtRepeatInterval.Value * 1000).ToString();
                item.RepeatCount = "-1";
                if (chkActive.Checked)
                {
                    DateTime startTime = txtStartTime.Value;
                    //Quartz只认0时区的时间，所以这里要减去当前时区值
                    startTime = startTime.Add(-TimeZoneInfo.Local.GetUtcOffset(startTime));

                    item.StartTime = startTime.ToString("yyyy-MM-ddTHH:mm:ss");
                    item.EndTime = new DateTime(9999, 1, 1).ToString("yyyy-MM-ddTHH:mm:ss");
                }
                else
                {
                    item.StartTime = "2010-01-01T00:00:00";
                    item.EndTime = item.StartTime;
                }
            }
            else
            {
                foreach (Control ctr in this.pnlEditBox.Controls)
                {
                    if (ctr is JobCronTriggerSetting)
                    {
                        JobCronTriggerSetting temp = ctr as JobCronTriggerSetting;
                        item.CronExpression = temp.CronExpression;
                    }

                }
            }

            try
            {
                this.m_Config.Save();

                TreeNode[] nodes = m_TnConfig.Nodes.Find(item.Name, false);
                if (nodes.Length > 0)
                {
                    nodes[0].ForeColor = item.Active == false ? Color.BurlyWood : Color.Empty;
                }

                logger.Debug("保存配置文件成功");
                MessageBox.Show(@"保存成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 点击打开当前文件夹的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpenDirectory_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", AppDomain.CurrentDomain.BaseDirectory);
        }

        /// <summary>
        /// 点击启动服务的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartService_Click(object sender, EventArgs e)
        {
            if (this.m_ServiceController.Status != ServiceControllerStatus.Running)
            {
                try
                {
                    //启动服务，并且等待状态变成Running
                    this.m_ServiceController.Start();
                    this.m_ServiceController.WaitForStatus(ServiceControllerStatus.Running);

                    string message = string.Format("服务'{0}'启动成功", ServiceMainSettings.GetConfig().ServiceName);

                    logger.Debug(message);
                    MessageBox.Show(message);
                }
                catch (Exception ex)
                {
                    string message = string.Format("服务'{0}'启动失败\n{1}", ServiceMainSettings.GetConfig().ServiceName, ex.Message);
                    logger.Error(message);
                    MessageBox.Show(message);
                }

                ShowConfigSummary();
            }
        }

        /// <summary>
        /// 点击停止服务的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStopService_Click(object sender, EventArgs e)
        {
            if (this.m_ServiceController.Status != ServiceControllerStatus.Stopped)
            {
                try
                {
                    //启动服务，并且等待知道状态变成Running
                    this.m_ServiceController.Stop();
                    this.m_ServiceController.WaitForStatus(ServiceControllerStatus.Stopped);

                    string message = string.Format("服务'{0}'停止成功", ServiceMainSettings.GetConfig().ServiceName);
                    logger.Debug(message);
                    MessageBox.Show(message);
                }
                catch (Exception ex)
                {
                    string message = string.Format("服务'{0}'停止失败\n{1}", ServiceMainSettings.GetConfig().ServiceName, ex.Message);
                    logger.Debug(message);
                    MessageBox.Show(message);
                }

                ShowConfigSummary();
            }
        }

        /// <summary>
        /// 在关闭窗口前激活，用户选择“否”则不退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KtvMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.m_ServiceController != null)
            {
                if (this.m_ServiceController.Status != ServiceControllerStatus.Running)
                {
                    if (MessageBox.Show(string.Format("服务'{0}'尚未运行，是否不启动服务而直接退出?", ServiceMainSettings.GetConfig().ServiceName),
                        @"警告",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                }
            }
        }

        /// <summary>
        /// 窗体加载事件的处理函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KtvMainForm_Load(object sender, EventArgs e)
        {

        }

        #endregion


        #region Private Method

        private void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            logger.Error("服务错误：" + e.Exception);
            MessageBox.Show(this, e.Exception.Message + "\n" + e.Exception.StackTrace, @"错误", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void OnCreateJobEvent(Object obj)
        {

        }



        /// <summary>
        /// 检测服务安装情况
        /// </summary>
        private bool CheckServiceController()
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController service in services)
            {
                if (service.ServiceName.Equals(this.mainService.ServiceName))
                {
                    this.m_ServiceController = service;
                    break;
                }
            }

            if (this.m_ServiceController == null)
            {
                return false;
                //MessageBox.Show(string.Format("没有找到已安装的服务: {0}", this.mainService.ServiceName));
            }

            return true;
        }

        /// <summary>
        /// 装入配置信息
        /// </summary>
        private void LoadConfigFile()
        {
            try
            {
                this.m_Config = new ScheduleConfig(ServiceMainSettings.GetConfig().ScheduleConfig);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("打开配置文件{0}失败\n\n{1}", ServiceMainSettings.GetConfig().ScheduleConfig, ex.Message));
            }
        }

        /// <summary>
        /// 初始化左侧目录树
        /// </summary>
        private void InitTreeView()
        {
            tvLeft.Nodes.Clear();

            //两个重要节点
            m_TnSummary = tvLeft.Nodes.Add("概述");
            m_TnConfig = tvLeft.Nodes.Add("功能配置");

            if (this.m_Config != null)
            {
                //添加全部配置项到左侧列表
                foreach (ScheduleItem item in this.m_Config.Items)
                {
                    TreeNode node = m_TnConfig.Nodes.Add(item.Name, item.Title);

                    if (item.Active == false)
                    {
                        node.ForeColor = Color.BurlyWood;
                    }
                }
            }

            tvLeft.ExpandAll();
        }

        /// <summary>
        /// 在右侧信息区显示服务状态和配置信息等概要信息，并设置按钮状态
        /// </summary>
        private void ShowConfigSummary()
        {
            //显示概要信息
            StringBuilder sb = new StringBuilder();

            if (this.m_ServiceController != null)
            {
                sb.AppendLine(string.Format("已安装的服务：{0}", ServiceMainSettings.GetConfig().ServiceName));
                sb.AppendLine(string.Format("服务运行状态：{0}", this.m_ServiceController.Status == ServiceControllerStatus.Running ? "正在运行" : "未启动"));
            }
            else
            {
                sb.AppendLine(string.Format("没有找到已安装的服务：{0}", ServiceMainSettings.GetConfig().ServiceName));
            }

            if (this.m_Config != null)
            {
                sb.AppendLine();
                sb.AppendLine("------------------");
                sb.AppendLine("有效的调度任务：");

                foreach (ScheduleItem item in this.m_Config.Items)
                {
                    if (item.Active == false) continue;

                    sb.AppendLine();

                    sb.AppendLine(string.Format("任务名称：{0}", item.Title));
                    if (item.IsSimple)
                    {
                        sb.AppendLine(string.Format("开始时间：{0}", item.GetStartTime().ToString("yyyy-MM-dd HH:mm:ss")));
                        sb.AppendLine(string.Format("重复间隔：{0}", ServiceUtility.TimeString(item.GetRepeatInterval())));
                    }
                    else
                    {
                        string[] strs = item.CronExpression.Split(' ');
                        if (strs != null)
                        {
                            int day = 0;
                            if (Int32.TryParse(strs[3], out day))
                            {
                                sb.AppendLine(string.Format("执行方式: 每月 {0} 日 {1} 时 {2} 分触发执行。", strs[3], strs[2], strs[1]));
                            }
                            else
                            {
                                sb.AppendLine(string.Format("执行方式: 每日 {0} 时 {1} 分触发执行。", strs[2], strs[1]));
                            }

                        }
                    }
                    sb.AppendLine(string.Format("任务描述：{0}", item.Description));
                }
            }
            else
            {
                sb.AppendLine();
                sb.AppendLine(string.Format("没有找到配置文件{0}", ServiceMainSettings.GetConfig().ScheduleConfig));
            }

            if (this.m_ServiceController == null || this.m_Config == null)
            {
                sb.AppendLine();
                sb.AppendLine("请检查原因或重新安装程序");
            }

            txtSummary.Text = sb.ToString();

            //设置按钮状态
            if (this.m_ServiceController == null)
            {
                btnStartService.Enabled = false;
                btnStopService.Enabled = false;

                this.toolStripBtnStart.Enabled = false;

                this.toolStripBtnStop.Enabled = false;
            }
            else if (this.m_ServiceController.Status == ServiceControllerStatus.Running)
            {
                btnStartService.Enabled = false;
                btnStopService.Enabled = true;

                this.toolStripBtnStart.Enabled = false;

                this.toolStripBtnStop.Enabled = true;

            }
            else
            {
                btnStartService.Enabled = true;
                btnStopService.Enabled = false;


                this.toolStripBtnStart.Enabled = true;

                this.toolStripBtnStop.Enabled = false;
            }
        }

        /// <summary>
        /// 在右侧配置编辑区域填充配置信息
        /// </summary>
        /// <param name="item"></param>
        private void FillConfigPanel(ScheduleItem item)
        {
            this.ClearCronSetCtr();
            txtTitle.Text = item.Title;
            txtDescription.Text = item.Description;

            chkActive.Checked = item.Active;
            if (item.IsSimple)
            {
                txtStartTime.Value = item.GetStartTime();

                txtRepeatInterval.Value = item.GetRepeatInterval();
            }
            else
            {
                JobCronTriggerSetting triggerSetCtr = new JobCronTriggerSetting();

                this.pnlEditBox.Controls.Add(triggerSetCtr);
                triggerSetCtr.Dock = DockStyle.Fill;
                triggerSetCtr.BringToFront();
                triggerSetCtr.LoadSetting(item.CronExpression);
            }

            chkActive_CheckedChanged(null, null);

            //填充"扩展配置"页
            FillExtendConfig(item);

            FillTestControl(item);
        }

        private void ClearCronSetCtr()
        {
            foreach (Control ctr in this.pnlEditBox.Controls)
            {
                if (ctr is JobCronTriggerSetting)
                {
                    this.pnlEditBox.Controls.Remove(ctr);
                    break;
                }

            }
        }

        private void FillTestControl(ScheduleItem item)
        {
            CreateTabControl(ServiceMainSettings.GetConfig().AddinConfigs, item, tabPage3);
        }

        /// <summary>
        /// 填充某个模块对应扩展配置项面板
        /// </summary>
        /// <param name="item"></param>
        private void FillExtendConfig(ScheduleItem item)
        {
            CreateTabControl(ServiceMainSettings.GetConfig().ExtendConfigs, item, tabPage2);
        }

        private void CreateTabControl(TypeConfigurationCollection configs, ScheduleItem item, TabPage tab)
        {
            tab.Controls.Clear();
            try
            {
                if (configs.ContainsKey(item.Name))
                {
                    TypeConfigurationElement typeElement = configs[item.Name];
                    UserControl uc = typeElement.CreateInstance() as UserControl;
                    if (uc != null)
                    {
                        tab.Controls.Clear();
                        uc.Dock = DockStyle.Fill;
                        tab.Controls.Add(uc);
                    }
                }
                else
                    tabControl1.TabPages.Remove(tab);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("加载扩展配置控件失败，异常信息：{0}", ex.Message));
                //移除扩展配置项
                tabControl1.TabPages.Remove(tab);
            }
        }

        #endregion

        private void StartService()
        {
            btnStartService_Click(this, null);
            this.toolStripBtnStop.Enabled = true;
            this.toolStripBtnStart.Enabled = false;
        }

        private void StopService()
        {
            btnStopService_Click(this, null);
            this.toolStripBtnStart.Enabled = true;
            this.toolStripBtnStop.Enabled = false;
        }

    }
}
