using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace LHJ.SYNC.WinService
{
    public partial class JobCronTriggerSetting : UserControl
    {
        public JobCronTriggerSetting()
        {
            InitializeComponent();
        }

        private string m_cronExpression = "";
        private string m_expressionFormat = "{0} {1} {2} {3} {4} {5}";
        /// <summary>
        /// 调度表达式
        /// </summary>
        public string CronExpression
        {
            set
            {
                m_cronExpression = value;
            }
            get
            {
                return m_cronExpression;
            }

        }



        public void LoadSetting(string expression)
        {
            this.m_cronExpression = expression;
            string[] strs = this.m_cronExpression.Split(' ');
            if (strs == null)
                return;
            int day = 0;
            if (Int32.TryParse(strs[3], out day))
            {
                this.rbtnMonth.Checked = true;
                this.txtDay.Text = strs[3];
                this.txtMHours.Text = strs[2];
                this.txtMMinutes.Text = strs[1];
            }
            else if (strs[3] == "?")
            {
                this.rbtnWeek.Checked = true;
                this.txtWeek.Text = GetWeekValue(strs[5]);
                this.txtWHour.Text = strs[2];
                this.txtWMinute.Text = strs[1];
            }
            else
            {
                this.rbtnDay.Checked = true;
                this.txtDHours.Text = strs[2];
                this.txtDMinutes.Text = strs[1];
            }
        }

        private void SetSetting()
        {
            if (this.rbtnDay.Checked)
            {
                this.m_cronExpression = string.Format(this.m_expressionFormat, "0", this.txtDMinutes.Text, this.txtDHours.Text, "*", "*", "?");
            }
            else if (this.rbtnMonth.Checked)
            {
                this.m_cronExpression = string.Format(this.m_expressionFormat, "0", this.txtMMinutes.Text, this.txtMHours.Text, this.txtDay.Text, "*", "?");
            }
            else
            {
                this.m_cronExpression = string.Format(this.m_expressionFormat, "0", this.txtWMinute.Text, this.txtWHour.Text, "?", "*", this.GetWeekStr(this.txtWeek.Text.Trim()));
            }


            this.txtBuildExpression.Text = this.m_cronExpression;

        }
        private string GetWeekStr(string strNum)
        {
            string result = "";
            switch (strNum)
            {
                case "1": result = "MON"; break;
                case "2": result = "TUE"; break;
                case "3": result = "WED"; break;
                case "4": result = "THU"; break;
                case "5": result = "FRI"; break;
                case "6": result = "SAT"; break;
                case "7": result = "SUN"; break;
                default:
                    result = "*";
                    break;
            }
            return result;
        }

        private string GetWeekValue(string strNum)
        {
            string result = "";
            switch (strNum)
            {
                case "MON": result = "1"; break;
                case "TUE": result = "2"; break;
                case "WED": result = "3"; break;
                case "THU": result = "4"; break;
                case "FRI": result = "5"; break;
                case "SAT": result = "6"; break;
                case "SUN": result = "7"; break;
                default:
                    result = "*";
                    break;
            }
            return result;
        }

        private void rbtnDay_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnDay.Checked)
            {
                this.gboxDay.Enabled = true;
                this.gboxMonth.Enabled = false;
                this.gbxWeek.Enabled = false;
                SetSetting();

            }
        }

        private void rbtnMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnMonth.Checked)
            {
                this.gboxDay.Enabled = false;
                this.gboxMonth.Enabled = true;
                this.gbxWeek.Enabled = false;
                SetSetting();
            }
        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {
            this.SetSetting();
        }

        private void rbtnWeek_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtnWeek.Checked)
            {
                this.gboxDay.Enabled = false;
                this.gboxMonth.Enabled = false;
                this.gbxWeek.Enabled = true;
                SetSetting();
            }
        }
       
    }
}
