namespace LHJ.SYNC.WinService
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripSet = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSaveSetting = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnStart = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnOpenFloder = new System.Windows.Forms.ToolStripButton();
            this.btnSaveChange = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvLeft = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.btnOpenDirectory = new System.Windows.Forms.Button();
            this.btnStartService = new System.Windows.Forms.Button();
            this.btnStopService = new System.Windows.Forms.Button();
            this.pnlConfig = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlEditBox = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRepeatInterval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.DateTimePicker();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.toolStripSet.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlSummary.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlConfig.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlEditBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepeatInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSet
            // 
            this.toolStripSet.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSet.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripSet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.tsBtnSaveSetting,
            this.toolStripBtnStart,
            this.toolStripBtnStop,
            this.toolStripBtnOpenFloder});
            this.toolStripSet.Location = new System.Drawing.Point(0, 0);
            this.toolStripSet.Name = "toolStripSet";
            this.toolStripSet.Size = new System.Drawing.Size(769, 25);
            this.toolStripSet.TabIndex = 31;
            this.toolStripSet.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.Image = global::LHJ.SYNC.WinService.Properties.Resources.Action_Undo;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Tag = "Exit";
            this.toolStripButton1.Text = "退出";
            // 
            // tsBtnSaveSetting
            // 
            this.tsBtnSaveSetting.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsBtnSaveSetting.Image = global::LHJ.SYNC.WinService.Properties.Resources.Save;
            this.tsBtnSaveSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSaveSetting.Name = "tsBtnSaveSetting";
            this.tsBtnSaveSetting.Size = new System.Drawing.Size(76, 22);
            this.tsBtnSaveSetting.Tag = "Save";
            this.tsBtnSaveSetting.Text = "保存修改";
            // 
            // toolStripBtnStart
            // 
            this.toolStripBtnStart.Image = global::LHJ.SYNC.WinService.Properties.Resources.Player_Play;
            this.toolStripBtnStart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnStart.Name = "toolStripBtnStart";
            this.toolStripBtnStart.Size = new System.Drawing.Size(76, 22);
            this.toolStripBtnStart.Tag = "Start";
            this.toolStripBtnStart.Text = "启动服务";
            // 
            // toolStripBtnStop
            // 
            this.toolStripBtnStop.Image = global::LHJ.SYNC.WinService.Properties.Resources.Player_Stop;
            this.toolStripBtnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnStop.Name = "toolStripBtnStop";
            this.toolStripBtnStop.Size = new System.Drawing.Size(76, 22);
            this.toolStripBtnStop.Tag = "Stop";
            this.toolStripBtnStop.Text = "停止服务";
            // 
            // toolStripBtnOpenFloder
            // 
            this.toolStripBtnOpenFloder.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripBtnOpenFloder.Image = global::LHJ.SYNC.WinService.Properties.Resources.Folder;
            this.toolStripBtnOpenFloder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpenFloder.Name = "toolStripBtnOpenFloder";
            this.toolStripBtnOpenFloder.Size = new System.Drawing.Size(88, 22);
            this.toolStripBtnOpenFloder.Tag = "OpenFloder";
            this.toolStripBtnOpenFloder.Text = "打开文件夹";
            // 
            // btnSaveChange
            // 
            this.btnSaveChange.Location = new System.Drawing.Point(673, 6);
            this.btnSaveChange.Name = "btnSaveChange";
            this.btnSaveChange.Size = new System.Drawing.Size(75, 32);
            this.btnSaveChange.TabIndex = 27;
            this.btnSaveChange.Text = "保存修改";
            this.btnSaveChange.UseVisualStyleBackColor = true;
            this.btnSaveChange.Click += new System.EventHandler(this.btnSaveChange_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSaveChange);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 468);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 41);
            this.panel2.TabIndex = 33;
            this.panel2.Visible = false;
            // 
            // tvLeft
            // 
            this.tvLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvLeft.HideSelection = false;
            this.tvLeft.Location = new System.Drawing.Point(0, 0);
            this.tvLeft.Name = "tvLeft";
            this.tvLeft.Size = new System.Drawing.Size(176, 441);
            this.tvLeft.TabIndex = 1;
            this.tvLeft.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvLeft_AfterSelect);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(769, 443);
            this.splitContainer1.SplitterDistance = 178;
            this.splitContainer1.TabIndex = 32;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(585, 441);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlSummary);
            this.tabPage1.Controls.Add(this.pnlConfig);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(577, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基础信息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlSummary
            // 
            this.pnlSummary.Controls.Add(this.panel5);
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSummary.Location = new System.Drawing.Point(3, 3);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Padding = new System.Windows.Forms.Padding(3);
            this.pnlSummary.Size = new System.Drawing.Size(571, 409);
            this.pnlSummary.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox1);
            this.panel5.Controls.Add(this.btnOpenDirectory);
            this.panel5.Controls.Add(this.btnStartService);
            this.panel5.Controls.Add(this.btnStopService);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(565, 403);
            this.panel5.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSummary);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 403);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务信息";
            // 
            // txtSummary
            // 
            this.txtSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSummary.Location = new System.Drawing.Point(3, 17);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSummary.Size = new System.Drawing.Size(559, 383);
            this.txtSummary.TabIndex = 0;
            // 
            // btnOpenDirectory
            // 
            this.btnOpenDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenDirectory.Location = new System.Drawing.Point(446, 8);
            this.btnOpenDirectory.Name = "btnOpenDirectory";
            this.btnOpenDirectory.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDirectory.TabIndex = 30;
            this.btnOpenDirectory.Text = "打开文件夹";
            this.btnOpenDirectory.UseVisualStyleBackColor = true;
            this.btnOpenDirectory.Visible = false;
            this.btnOpenDirectory.Click += new System.EventHandler(this.btnOpenDirectory_Click);
            // 
            // btnStartService
            // 
            this.btnStartService.Location = new System.Drawing.Point(18, 8);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(75, 23);
            this.btnStartService.TabIndex = 30;
            this.btnStartService.Text = "启动服务";
            this.btnStartService.UseVisualStyleBackColor = true;
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
            // 
            // btnStopService
            // 
            this.btnStopService.Location = new System.Drawing.Point(101, 8);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(75, 23);
            this.btnStopService.TabIndex = 31;
            this.btnStopService.Text = "停止服务";
            this.btnStopService.UseVisualStyleBackColor = true;
            this.btnStopService.Click += new System.EventHandler(this.btnStopService_Click);
            // 
            // pnlConfig
            // 
            this.pnlConfig.Controls.Add(this.groupBox2);
            this.pnlConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConfig.Location = new System.Drawing.Point(3, 3);
            this.pnlConfig.Name = "pnlConfig";
            this.pnlConfig.Padding = new System.Windows.Forms.Padding(3);
            this.pnlConfig.Size = new System.Drawing.Size(571, 409);
            this.pnlConfig.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.pnlEditBox);
            this.groupBox2.Controls.Add(this.chkActive);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 403);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置";
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTitle.Location = new System.Drawing.Point(1, 17);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(40, 12);
            this.txtTitle.TabIndex = 39;
            this.txtTitle.Text = "Title";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Location = new System.Drawing.Point(10, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 1);
            this.panel1.TabIndex = 38;
            // 
            // pnlEditBox
            // 
            this.pnlEditBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEditBox.Controls.Add(this.txtDescription);
            this.pnlEditBox.Controls.Add(this.label4);
            this.pnlEditBox.Controls.Add(this.label3);
            this.pnlEditBox.Controls.Add(this.txtRepeatInterval);
            this.pnlEditBox.Controls.Add(this.label1);
            this.pnlEditBox.Controls.Add(this.txtStartTime);
            this.pnlEditBox.Location = new System.Drawing.Point(10, 81);
            this.pnlEditBox.Name = "pnlEditBox";
            this.pnlEditBox.Size = new System.Drawing.Size(541, 313);
            this.pnlEditBox.TabIndex = 37;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.Window;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDescription.Location = new System.Drawing.Point(2, 67);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(347, 132);
            this.txtDescription.TabIndex = 44;
            this.txtDescription.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 43;
            this.label4.Text = "秒";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 41;
            this.label3.Text = "重复间隔: ";
            // 
            // txtRepeatInterval
            // 
            this.txtRepeatInterval.Location = new System.Drawing.Point(83, 40);
            this.txtRepeatInterval.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.txtRepeatInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtRepeatInterval.Name = "txtRepeatInterval";
            this.txtRepeatInterval.Size = new System.Drawing.Size(97, 21);
            this.txtRepeatInterval.TabIndex = 40;
            this.txtRepeatInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 37;
            this.label1.Text = "开始时间:";
            // 
            // txtStartTime
            // 
            this.txtStartTime.CustomFormat = "yyyy-MM-dd HH:mm";
            this.txtStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtStartTime.Location = new System.Drawing.Point(83, 13);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(126, 21);
            this.txtStartTime.TabIndex = 36;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(11, 52);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(108, 16);
            this.chkActive.TabIndex = 26;
            this.chkActive.Text = "允许此调度执行";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(577, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "扩展配置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(577, 415);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "测试工具";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 509);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStripSet);
            this.Name = "MainForm";
            this.Text = "家家悦后台服务";
            this.toolStripSet.ResumeLayout(false);
            this.toolStripSet.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlSummary.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlConfig.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlEditBox.ResumeLayout(false);
            this.pnlEditBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepeatInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripSet;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton tsBtnSaveSetting;
        private System.Windows.Forms.ToolStripButton toolStripBtnStart;
        private System.Windows.Forms.ToolStripButton toolStripBtnStop;
        private System.Windows.Forms.ToolStripButton toolStripBtnOpenFloder;
        private System.Windows.Forms.Button btnSaveChange;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvLeft;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnOpenDirectory;
        private System.Windows.Forms.Button btnStartService;
        private System.Windows.Forms.Button btnStopService;
        private System.Windows.Forms.Panel pnlConfig;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlEditBox;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtRepeatInterval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker txtStartTime;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSummary;

    }
}

