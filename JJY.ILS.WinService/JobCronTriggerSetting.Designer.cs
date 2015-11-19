namespace LHJ.SYNC.WinService
{
    partial class JobCronTriggerSetting
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtWeek = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtWHour = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbxWeek = new System.Windows.Forms.GroupBox();
            this.txtWMinute = new System.Windows.Forms.TextBox();
            this.rbtnWeek = new System.Windows.Forms.RadioButton();
            this.txtBuildExpression = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gboxMonth = new System.Windows.Forms.GroupBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMHours = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMMinutes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gboxDay = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDMinutes = new System.Windows.Forms.TextBox();
            this.txtDHours = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnMonth = new System.Windows.Forms.RadioButton();
            this.rbtnDay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxWeek.SuspendLayout();
            this.gboxMonth.SuspendLayout();
            this.gboxDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtWeek
            // 
            this.txtWeek.Location = new System.Drawing.Point(49, 16);
            this.txtWeek.Name = "txtWeek";
            this.txtWeek.Size = new System.Drawing.Size(37, 21);
            this.txtWeek.TabIndex = 11;
            this.txtWeek.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(232, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "分触发";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 12);
            this.label11.TabIndex = 10;
            this.label11.Text = "星期";
            // 
            // txtWHour
            // 
            this.txtWHour.Location = new System.Drawing.Point(116, 16);
            this.txtWHour.Name = "txtWHour";
            this.txtWHour.Size = new System.Drawing.Size(37, 21);
            this.txtWHour.TabIndex = 5;
            this.txtWHour.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(166, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 7;
            this.label13.Text = "点";
            // 
            // gbxWeek
            // 
            this.gbxWeek.Controls.Add(this.txtWeek);
            this.gbxWeek.Controls.Add(this.label9);
            this.gbxWeek.Controls.Add(this.label11);
            this.gbxWeek.Controls.Add(this.txtWHour);
            this.gbxWeek.Controls.Add(this.txtWMinute);
            this.gbxWeek.Controls.Add(this.label13);
            this.gbxWeek.Enabled = false;
            this.gbxWeek.Location = new System.Drawing.Point(76, 152);
            this.gbxWeek.Name = "gbxWeek";
            this.gbxWeek.Size = new System.Drawing.Size(366, 46);
            this.gbxWeek.TabIndex = 22;
            this.gbxWeek.TabStop = false;
            this.gbxWeek.Text = "按周";
            // 
            // txtWMinute
            // 
            this.txtWMinute.Location = new System.Drawing.Point(189, 16);
            this.txtWMinute.Name = "txtWMinute";
            this.txtWMinute.Size = new System.Drawing.Size(37, 21);
            this.txtWMinute.TabIndex = 8;
            this.txtWMinute.Text = "0";
            // 
            // rbtnWeek
            // 
            this.rbtnWeek.AutoSize = true;
            this.rbtnWeek.Location = new System.Drawing.Point(17, 167);
            this.rbtnWeek.Name = "rbtnWeek";
            this.rbtnWeek.Size = new System.Drawing.Size(53, 16);
            this.rbtnWeek.TabIndex = 21;
            this.rbtnWeek.Text = "按周:";
            this.rbtnWeek.UseVisualStyleBackColor = true;
            // 
            // txtBuildExpression
            // 
            this.txtBuildExpression.Location = new System.Drawing.Point(91, 214);
            this.txtBuildExpression.Name = "txtBuildExpression";
            this.txtBuildExpression.ReadOnly = true;
            this.txtBuildExpression.Size = new System.Drawing.Size(351, 21);
            this.txtBuildExpression.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "分触发";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "生成表达式:";
            // 
            // gboxMonth
            // 
            this.gboxMonth.Controls.Add(this.txtDay);
            this.gboxMonth.Controls.Add(this.label5);
            this.gboxMonth.Controls.Add(this.label8);
            this.gboxMonth.Controls.Add(this.txtMHours);
            this.gboxMonth.Controls.Add(this.label7);
            this.gboxMonth.Controls.Add(this.txtMMinutes);
            this.gboxMonth.Controls.Add(this.label6);
            this.gboxMonth.Enabled = false;
            this.gboxMonth.Location = new System.Drawing.Point(76, 97);
            this.gboxMonth.Name = "gboxMonth";
            this.gboxMonth.Size = new System.Drawing.Size(366, 46);
            this.gboxMonth.TabIndex = 18;
            this.gboxMonth.TabStop = false;
            this.gboxMonth.Text = "按月";
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(49, 16);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(37, 21);
            this.txtDay.TabIndex = 11;
            this.txtDay.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "每月,";
            // 
            // txtMHours
            // 
            this.txtMHours.Location = new System.Drawing.Point(115, 16);
            this.txtMHours.Name = "txtMHours";
            this.txtMHours.Size = new System.Drawing.Size(37, 21);
            this.txtMHours.TabIndex = 5;
            this.txtMHours.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "日";
            // 
            // txtMMinutes
            // 
            this.txtMMinutes.Location = new System.Drawing.Point(189, 16);
            this.txtMMinutes.Name = "txtMMinutes";
            this.txtMMinutes.Size = new System.Drawing.Size(37, 21);
            this.txtMMinutes.TabIndex = 8;
            this.txtMMinutes.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "点";
            // 
            // gboxDay
            // 
            this.gboxDay.Controls.Add(this.label4);
            this.gboxDay.Controls.Add(this.txtDMinutes);
            this.gboxDay.Controls.Add(this.txtDHours);
            this.gboxDay.Controls.Add(this.label3);
            this.gboxDay.Controls.Add(this.label2);
            this.gboxDay.Location = new System.Drawing.Point(76, 47);
            this.gboxDay.Name = "gboxDay";
            this.gboxDay.Size = new System.Drawing.Size(366, 40);
            this.gboxDay.TabIndex = 17;
            this.gboxDay.TabStop = false;
            this.gboxDay.Text = "按日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "分触发";
            // 
            // txtDMinutes
            // 
            this.txtDMinutes.Location = new System.Drawing.Point(116, 17);
            this.txtDMinutes.Name = "txtDMinutes";
            this.txtDMinutes.Size = new System.Drawing.Size(37, 21);
            this.txtDMinutes.TabIndex = 3;
            this.txtDMinutes.Text = "0";
            // 
            // txtDHours
            // 
            this.txtDHours.Location = new System.Drawing.Point(50, 16);
            this.txtDHours.Name = "txtDHours";
            this.txtDHours.Size = new System.Drawing.Size(37, 21);
            this.txtDHours.TabIndex = 0;
            this.txtDHours.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "点";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "每日,";
            // 
            // rbtnMonth
            // 
            this.rbtnMonth.AutoSize = true;
            this.rbtnMonth.Location = new System.Drawing.Point(17, 114);
            this.rbtnMonth.Name = "rbtnMonth";
            this.rbtnMonth.Size = new System.Drawing.Size(53, 16);
            this.rbtnMonth.TabIndex = 16;
            this.rbtnMonth.Text = "按月:";
            this.rbtnMonth.UseVisualStyleBackColor = true;
            // 
            // rbtnDay
            // 
            this.rbtnDay.AutoSize = true;
            this.rbtnDay.Checked = true;
            this.rbtnDay.Location = new System.Drawing.Point(17, 64);
            this.rbtnDay.Name = "rbtnDay";
            this.rbtnDay.Size = new System.Drawing.Size(53, 16);
            this.rbtnDay.TabIndex = 15;
            this.rbtnDay.TabStop = true;
            this.rbtnDay.Text = "按日:";
            this.rbtnDay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "调度方式(24小时格式):";
            // 
            // JobCronTriggerSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbxWeek);
            this.Controls.Add(this.rbtnWeek);
            this.Controls.Add(this.txtBuildExpression);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.gboxMonth);
            this.Controls.Add(this.gboxDay);
            this.Controls.Add(this.rbtnMonth);
            this.Controls.Add(this.rbtnDay);
            this.Controls.Add(this.label1);
            this.Name = "JobCronTriggerSetting";
            this.Size = new System.Drawing.Size(457, 256);
            this.gbxWeek.ResumeLayout(false);
            this.gbxWeek.PerformLayout();
            this.gboxMonth.ResumeLayout(false);
            this.gboxMonth.PerformLayout();
            this.gboxDay.ResumeLayout(false);
            this.gboxDay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWeek;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtWHour;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbxWeek;
        private System.Windows.Forms.TextBox txtWMinute;
        private System.Windows.Forms.RadioButton rbtnWeek;
        private System.Windows.Forms.TextBox txtBuildExpression;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gboxMonth;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMMinutes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gboxDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDMinutes;
        private System.Windows.Forms.TextBox txtDHours;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtnMonth;
        private System.Windows.Forms.RadioButton rbtnDay;
        private System.Windows.Forms.Label label1;

    }
}
